using System;
using System.Collections.Generic;

namespace Design_Patterns
{
    internal class cafe
    {
        class CustomMeal
        {
            private string _mealType;
            private Dictionary<string, string> _items = new Dictionary<string, string>();

            public CustomMeal(string mealType)
            {
                _mealType = mealType;
            }

            public string this[string key]
            {
                get { return _items[key]; }
                set { _items[key] = value; }
            }

            public void Display()
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Meal type: {0}", _mealType);
                Console.WriteLine("Special Dish: {0} ", _items["specialDish"]);
                Console.WriteLine("Signature Drink: {0} ", _items["signatureDrink"]);
                Console.WriteLine("Delicious Dessert: {0} ", _items["deliciousDessert"]);
                Console.WriteLine("Exclusive Toy: {0} ", _items["exclusiveToy"]);
            }
        }

        abstract class MealCreator
        {
            protected CustomMeal customMeal;

            public CustomMeal CustomMeal { get { return customMeal; } }

            public abstract void CreateSpecialDish();
            public abstract void CreateSignatureDrink();
            public abstract void CreateDeliciousDessert();
            public abstract void CreateExclusiveToy();
        }

        class SignatureMealCreator : MealCreator
        {
            public SignatureMealCreator()
            {
                customMeal = new CustomMeal("Signature Meal");
            }

            public override void CreateSpecialDish()
            {
                customMeal["specialDish"] = "Chef's Special Pasta";
            }

            public override void CreateSignatureDrink()
            {
                customMeal["signatureDrink"] = "Premium Mocktail";
            }

            public override void CreateDeliciousDessert()
            {
                customMeal["deliciousDessert"] = "Decadent Chocolate Cake";
            }

            public override void CreateExclusiveToy()
            {
                customMeal["exclusiveToy"] = "Collector's Edition Toy X";
            }
        }

        class DeluxeMealCreator : MealCreator
        {
            public DeluxeMealCreator()
            {
                customMeal = new CustomMeal("Deluxe Meal");
            }

            public override void CreateSpecialDish()
            {
                customMeal["specialDish"] = "Grilled Salmon with Lemon Butter";
            }

            public override void CreateSignatureDrink()
            {
                customMeal["signatureDrink"] = "Refreshing Fruit Smoothie";
            }

            public override void CreateDeliciousDessert()
            {
                customMeal["deliciousDessert"] = "Tiramisu Delight";
            }

            public override void CreateExclusiveToy()
            {
                customMeal["exclusiveToy"] = "Exclusive Plush Toy Y";
            }
        }

        class PremiumMealCreator : MealCreator
        {
            public PremiumMealCreator()
            {
                customMeal = new CustomMeal("Premium Meal");
            }

            public override void CreateSpecialDish()
            {
                customMeal["specialDish"] = "Truffle-infused Steak";
            }

            public override void CreateSignatureDrink()
            {
                customMeal["signatureDrink"] = "Champagne Bliss";
            }

            public override void CreateDeliciousDessert()
            {
                customMeal["deliciousDessert"] = "Creme Brulee Indulgence";
            }

            public override void CreateExclusiveToy()
            {
                customMeal["exclusiveToy"] = "Luxury Collectible Toy Z";
            }
        }

        class MealHouse
        {
            public void PrepareMeal(MealCreator mealCreator)
            {
                mealCreator.CreateSpecialDish();
                mealCreator.CreateSignatureDrink();
                mealCreator.CreateDeliciousDessert();
                mealCreator.CreateExclusiveToy();
            }
        }

        static void Main(string[] args)
        {
            MealCreator creator;

            MealHouse mealHouse = new MealHouse();

            creator = new SignatureMealCreator();
            mealHouse.PrepareMeal(creator);
            creator.CustomMeal.Display();

            creator = new DeluxeMealCreator();
            mealHouse.PrepareMeal(creator);
            creator.CustomMeal.Display();

            creator = new PremiumMealCreator();
            mealHouse.PrepareMeal(creator);
            creator.CustomMeal.Display();

            Console.ReadKey();
        }
    }
}
