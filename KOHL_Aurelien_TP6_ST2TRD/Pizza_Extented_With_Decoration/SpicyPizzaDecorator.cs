using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Extented_With_Decoration
{
    public class SpicyPizzaDecorator : PizzaDecorator
    {
        public SpicyPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override IPizza SaucedPizza()
        {
            pizza.SaucedPizza();
            AddSpicySauce(pizza);
            return pizza;
        }

        public void AddSpicySauce(IPizza pizza)
        {
            if (pizza is ConcreteRecette)
            {
                ConcreteRecette ConcreteRecette = (ConcreteRecette)pizza;
                ConcreteRecette.Sauce = "Spicy";

            }
        }
    }
}
