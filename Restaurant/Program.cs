using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            var appetizer1 = new MenuItem();
            appetizer1.Name = "Chips and Salsa";
            appetizer1.Price = 3.0;
            appetizer1.Description = "Corn chips with spicy salsa.";
            appetizer1.Category = MenuItem.Categories.Appetizer;

            var appetizer2 = new MenuItem();
            appetizer2.Name = "Guacamole";
            appetizer2.Price = 5.0;
            appetizer2.Description = "Handmade guacamole.";
            appetizer2.Category = MenuItem.Categories.Appetizer;

            var mainCourse1 = new MenuItem();
            mainCourse1.Name = "Fish Tacos";
            mainCourse1.Price = 9.0;
            mainCourse1.Description = "Grilled or fried fish.";
            mainCourse1.Category = MenuItem.Categories.MainCourse;

            var mainCourse2 = new MenuItem();
            mainCourse2.Name = "Steak Fajita";
            mainCourse2.Price = 12.0;
            mainCourse2.Description = "Served in a skillet.";
            mainCourse2.Category = MenuItem.Categories.MainCourse;

            var dessert1 = new MenuItem();
            dessert1.Name = "Fried Ice Cream";
            dessert1.Price = 4.0;
            dessert1.Description = "Vanilla ice cream with a crispy crust.";
            dessert1.Category = MenuItem.Categories.Dessert;


            //Console.WriteLine(appetizer1.ToString());
            menu.AddItem(appetizer1);
            menu.AddItem(appetizer2);
            menu.AddItem(mainCourse1);
            menu.AddItem(mainCourse2);
            menu.AddItem(dessert1);
            Console.WriteLine(menu);

        }
    }
}
