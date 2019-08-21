using Microsoft.AspNetCore.Components;
using Nota.Alchemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nota.Alchemy.Web.Pages
{
    public partial class AlchemieBase : ComponentBase
    {

        protected Recipient Recipient;

        protected override Task OnInitializedAsync()
        {

            this.InitIngredients();

            this.Recipient = new Recipient(this.baseData);

            foreach (var item in this.ingredients)
            {
                //item.PropertyChanged += this.IngredientsSelectionChanged;
                item.PropertyChanged += (sender, e) =>
                {
                    if (item.Selection)
                        this.Recipient.Add(item.Ingredient);
                    else
                        this.Recipient.Remove(item.Ingredient);
                };
            }

            return Task.CompletedTask;
        }

        //private void IngredientsSelectionChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{

        //    var selected = this.ingredients.Where(x => x.Selection).Select(x => x.Ingredient);

        //    if (selected.Count() >= 3)
        //        this.Recipient = new Recipient(selected);
        //    else
        //        this.Recipient = null;

        //    System.Diagnostics.Debug.WriteLine($"Number Of Selected Items {selected.Count()}");
        //    //this.StateHasChanged();

        //}

        protected class IngredientSelection : System.ComponentModel.INotifyPropertyChanged
        {
            //private readonly AlchemieBase page;

            public Ingredient Ingredient { get; }
            private bool selection;
            public bool Selection
            {
                get => this.selection; set
                {
                    if (this.selection != value)
                    {
                        this.selection = value;
                        this.Fire();
                    }
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            private void Fire([System.Runtime.CompilerServices.CallerMemberName]string property = null)
            {
                this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }

            public IngredientSelection(/*AlchemieBase page,*/ Ingredient ingredient)
            {
                //this.page = page;
                this.Ingredient = ingredient;
            }

        }
    }
}
