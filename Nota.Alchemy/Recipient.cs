using Mixin;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Nota.Alchemy
{

    [Mixin(typeof(Mixins.NotifyPropertyMixin))]
    public partial class IngredientSettings
    {
        private int ammount = 1;

        public int Ammount
        {
            get { return this.ammount; }
            set
            {
                if (this.ammount != value)
                {
                    this.ammount = value;
                    this.FirePropertyChanged();
                }
            }
        }

        private IngredientProcessing processing;

        public IngredientSettings(Ingredient ingredient, AlchemieBaseData baseData)
        {
            this.Ingredient = ingredient;
            this.AllowedProcessing = baseData.IngredientProcessings.Where(x => x.SupportedIngredientPropertys.Intersect(ingredient.Propertys).Any()).ToImmutableHashSet();
        }

        public IngredientProcessing Processing
        {
            get { return this.processing; }
            set
            {
                if (this.processing != value)
                {
                    this.processing = value;
                    this.FirePropertyChanged();
                }
            }
        }

        public ImmutableHashSet<IngredientProcessing> AllowedProcessing { get; }
        public Ingredient Ingredient { get; }
    }

    [Mixin(typeof(Mixins.NotifyPropertyMixin))]
    public partial class Recipient
    {
        public ReadOnlyObservableCollection<IngredientSettings> Ingredients { get; }

        private readonly ObservableCollection<IngredientSettings> ingredients;
        public readonly AlchemieBaseData baseData;

        public IReadOnlyList<AlchemPack> ColumResult { get; private set; }
        public IReadOnlyList<AlchemPack> RowResult { get; private set; }


        public void Add(Ingredient ingredient)
        {
            var old = this.ingredients.FirstOrDefault(x => x.Ingredient == ingredient);

            if (old is null)
                this.ingredients.Add(new IngredientSettings(ingredient, this.baseData));
            else
                old.Ammount++;
        }

        public void Remove(Ingredient ingredient)
        {
            var old = this.ingredients.FirstOrDefault(x => x.Ingredient == ingredient);

            if (old != null)
                this.ingredients.Remove(old);
        }




        public AlchemieMatrix Matrix { get; private set; }

        public Recipient(AlchemieBaseData baseData)
        {
            this.ingredients = new ObservableCollection<IngredientSettings>();
            this.Ingredients = new ReadOnlyObservableCollection<IngredientSettings>(this.ingredients);
            this.Matrix = new AlchemieMatrix(this);

            this.Matrix.PropertyChanged += this.Matrix_PropertyChanged;

            this.UpdateData();
            this.baseData = baseData;
        }

        private void Matrix_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Items")
                this.UpdateData();
        }

        private void UpdateData()
        {


            var list = new MyList<AlchemPack>(this.Matrix.Columns);

            for (int x = 0; x < this.Matrix.Columns; x++)
            {
                AlchemPack pack = default;
                for (int y = 0; y < this.Matrix.Rows; y++)
                    pack += this.Matrix[x, y];
                list.Add(pack);
            }
            this.ColumResult = list.AsReadOnly();

            list = new MyList<AlchemPack>(this.Matrix.Rows);
            for (int y = 0; y < this.Matrix.Rows; y++)
            {
                AlchemPack pack = default;
                for (int x = 0; x < this.Matrix.Columns; x++)
                    pack += this.Matrix[x, y];
                list.Add(pack);
            }
            this.RowResult = list.AsReadOnly();
        }
    }

    class MyList<T> : List<T>
    {
        public MyList()
        {
        }

        public MyList(IEnumerable<T> collection) : base(collection)
        {
        }

        public MyList(int capacity) : base(capacity)
        {
        }
    }

    public class AlchemieBaseData
    {
        public AlchemieBaseData(IEnumerable<Ingredient> ingredients, IEnumerable<IngredientProcessing> ingredientProcessings)
        {
            this.Ingredients = ingredients.ToImmutableArray();
            this.IngredientProcessings = ingredientProcessings.ToImmutableArray();
        }

        public ImmutableArray<Ingredient> Ingredients { get; }
        public ImmutableArray<IngredientProcessing> IngredientProcessings { get; }
    }
}
