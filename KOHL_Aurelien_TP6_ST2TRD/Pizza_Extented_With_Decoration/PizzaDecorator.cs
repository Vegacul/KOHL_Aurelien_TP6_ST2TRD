using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Extented_With_Decoration
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;
        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public void IngredientAnanas()
        {
            this.pizza.IngredientAnanas();
        }

        public void IngredientChampignon()
        {
            this.pizza.IngredientChampignon();
        }

        public void IngredientCreme()
        {
            this.pizza.IngredientCreme();
        }

        public void IngredientFromage()
        {
            this.pizza.IngredientFromage();
        }

        public void IngredientHerbes()
        {
            this.pizza.IngredientHerbes();
        }

        public void IngredientJambon()
        {
            this.pizza.IngredientJambon();
        }

        public void IngredientSaumon()
        {
            this.pizza.IngredientSaumon();
        }

        public void IngredientTomate()
        {
            this.pizza.IngredientTomate();
        }

        public virtual IPizza SaucedPizza()
        {
            return pizza.SaucedPizza();
        }
    }
}
