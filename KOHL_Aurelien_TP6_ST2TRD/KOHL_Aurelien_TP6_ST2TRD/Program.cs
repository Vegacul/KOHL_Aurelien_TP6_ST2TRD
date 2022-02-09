using System;
using System.Collections.Generic;

namespace KOHL_Aurelien_TP6_ST2TRD
{
    // The Recette interface specifies methods for creating the different parts
    // of the Pizza objects.
    public interface IPizza
    {
        void IngredientTomate();

        void IngredientCreme();

        void IngredientFromage();

        void IngredientJambon();

        void IngredientAnanas();

        void IngredientChampignon();

        void IngredientSaumon();

        void IngredientHerbes();


    }

    // The Concrete Recette classes follow the Recette interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class ConcreteRecette : IPizza
    {
        private Pizza _pizza = new Pizza();

        // A fresh recette instance should contain a blank Pizza object, which
        // is used in further assembly.
        public ConcreteRecette()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new Pizza();
        }

        // All production steps work with the same Pizza instance.
        public void IngredientTomate()
        {
            this._pizza.Add("Tomate");
        }

        public void IngredientCreme()
        {
            this._pizza.Add("Creme");
        }

        public void IngredientFromage()
        {
            this._pizza.Add("Fromage");
        }

        public void IngredientJambon()
        {
            this._pizza.Add("Jambon");
        }

        public void IngredientAnanas()
        {
            this._pizza.Add("Ananas");
        }


        public void IngredientChampignon()
        {
            this._pizza.Add("Champignon");
        }

        public void IngredientSaumon()
        {
            this._pizza.Add("Saumon");
        }
        
        public void IngredientHerbes()
        {
            this._pizza.Add("Herbes");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Recette interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a recette
        // instance is expected to be ready to start producing another Pizza.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetPizza` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Pizza GetPizza()
        {
            Pizza result = this._pizza;

            this.Reset();

            return result;
        }
    }

    // It makes sense to use the Recette pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Pizza
    {
        private List<object> _pizza = new List<object>();

        public void Add(string part)
        {
            this._pizza.Add(part);
        }

        public string ListIngredients()
        {
            string str = string.Empty;

            for (int i = 0; i < this._pizza.Count; i++)
            {
                str += this._pizza[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Pizza parts: " + str + "\n";
        }
    }

    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Pizzaiolo
    {
        private IPizza _pizza;

        public IPizza Recette
        {
            set { _pizza = value; }
        }

        // The Director can construct several Pizza variations using the same
        // building steps.
        public void BuildLaPizzaDuPauvre()
        {
            this._pizza.IngredientTomate();
        }

        public void BuildLaPizzaDuFou()
        {
            this._pizza.IngredientTomate();
            this._pizza.IngredientFromage();
            this._pizza.IngredientJambon();
            this._pizza.IngredientAnanas();
        }

        public void BuildNorvegiene()
        {
            this._pizza.IngredientCreme();
            this._pizza.IngredientSaumon();
            this._pizza.IngredientHerbes();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a recette object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the recette object.
            var Marco = new Pizzaiolo();
            var recette = new ConcreteRecette();
            Marco.Recette = recette;

            Console.WriteLine("Margharita Pizza:");
            Marco.BuildLaPizzaDuPauvre();
            Console.WriteLine(recette.GetPizza().ListIngredients());

            Console.WriteLine("Hawai Pizza:");
            Marco.BuildLaPizzaDuFou();
            Console.WriteLine(recette.GetPizza().ListIngredients());

            Console.WriteLine("Norvegiene Pizza:");
            Marco.BuildNorvegiene();
            Console.WriteLine(recette.GetPizza().ListIngredients());

            // Remember, the Recette pattern can be used without a Director
            // class.
            Console.WriteLine("Custom Pizza Reine:");
            recette.IngredientTomate();
            recette.IngredientJambon();
            recette.IngredientChampignon();
            Console.Write(recette.GetPizza().ListIngredients());
        }
    }
}
