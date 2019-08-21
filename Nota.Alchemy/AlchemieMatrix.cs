using Mixin;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Nota.Alchemy
{
    [Mixin(typeof(Mixins.NotifyPropertyMixin))]
    public partial class AlchemieMatrix
    {
        public int Dicplacement { get; } = 1;

        public IReadOnlyList<IngredientSettings> OrderdIngredients { get; }

        private readonly List<IngredientSettings> entrys;

        public AlchemieMatrix(Recipient recipient)
        {
            this.Recipient = recipient;
            this.entrys = new List<IngredientSettings>();
            this.OrderdIngredients = this.entrys.AsReadOnly();
            (this.Recipient.Ingredients as INotifyCollectionChanged).CollectionChanged += this.IngredientsChanged;
            this.Update();
        }

        private void IngredientsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.Update();
        }

        private void Update()
        {
            this.entrys.Clear();
            if (this.Recipient.Ingredients.Count < 3)
                return;

            foreach (var item in this.entrys)
                item.PropertyChanged -= this.EntryChanged;

            this.entrys.AddRange(this.Recipient.Ingredients.Where(x => x.Ammount > 0).OrderBy(x => x.Ingredient.Order / (double)x.Ammount).ThenBy(x => x.Ingredient.Order));
            this.FirePropertyChanged(nameof(this.OrderdIngredients));
            this.FirePropertyChanged(nameof(this.Rows));
            this.FirePropertyChanged("Items");

            foreach (var item in this.entrys)
                item.PropertyChanged += this.EntryChanged;

        }

        private void EntryChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IngredientSettings.Ammount) || e.PropertyName == nameof(IngredientSettings.Processing))
                this.Update();
        }

        public int Columns => 3;
        public int Rows => this.entrys.Count;

        public Recipient Recipient { get; }

        public AlchemPack this[int x, int y]
        {
            get
            {
                var row = y;
                row += x * this.Dicplacement * -1 + this.Rows;
                row %= this.Rows;

                var ingredientSettings = this.entrys[row];

                AlchemKey alchemieKey;
                if (ingredientSettings.Processing != null)
                    alchemieKey = ingredientSettings.Processing.Process(ingredientSettings.Ingredient.AlchemieKey);
                else
                    alchemieKey = ingredientSettings.Ingredient.AlchemieKey;

                return alchemieKey[x];

            }
        }
    }
}
