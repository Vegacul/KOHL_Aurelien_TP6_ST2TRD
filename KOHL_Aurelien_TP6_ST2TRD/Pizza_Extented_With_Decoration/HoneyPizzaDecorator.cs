using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Extented_With_Decoration
{
    public class HoneyPizzaDecorator : PizzaDecorator
    {
        public HoneyPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }


        public override IPizza SaucedPizza()
        {
            pizza.SaucedPizza();
            AddHoneySauce(pizza);
            return pizza;
        }

        public void AddHoneySauce(IPizza pizza)
        {
            if (pizza is ConcreteRecette)
            {
                ConcreteRecette ConcreteRecette = (ConcreteRecette)pizza;
                ConcreteRecette.Sauce = "Honey";
                
            }
        }
    }
}
