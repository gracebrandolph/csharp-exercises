using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        private DateTime _dateUpdated;

        DateTime DateUpdated
        {
            get { return _dateUpdated; }
            set { _dateUpdated = value; }
        }
        List<MenuItem> CurrentMenu { get; set; }

        public Menu()
        {
            CurrentMenu = new List<MenuItem>();
        }

        public void AddItem(MenuItem newItem)
        {
            newItem.DateAdded = DateTime.Now;
            CurrentMenu.Add(newItem);
            DateUpdated = DateTime.Now;
        }

        public void RemoveItem(MenuItem toRemove)
        {
            CurrentMenu.Remove(toRemove);
            DateUpdated = DateTime.Now;
        }

        //create a string to print the entire menu
        public override String ToString()
        {
            string appetizers = "";
            string mainCourses = "";
            string desserts = "";
            string fullMenu = "";

            fullMenu += "--- MENU ---\nLast Updated: " + DateUpdated + "\n\n";

            foreach (MenuItem i in CurrentMenu)
            {

                if (i.Category == MenuItem.Categories.Appetizer)
                {
                    if (i.CheckNew())
                    {
                        appetizers += "**New!**\n";
                    }

                    appetizers += i.ToString() + "\n";
                }
                else if (i.Category == MenuItem.Categories.MainCourse)
                {
                    if (i.CheckNew())
                    {
                        mainCourses += "**New!**\n";
                    }

                    mainCourses += i.ToString() + "\n";
                }
                else if (i.Category == MenuItem.Categories.Dessert)
                {
                    if (i.CheckNew())
                    {
                        desserts += "**New!**\n";
                    }

                    desserts += i.ToString() + "\n";
                }
            }

            fullMenu += "- Appetizers -\n" + appetizers + "\n";
            fullMenu += "- Main Course -\n" + mainCourses + "\n";
            fullMenu += "- Desserts -\n" + desserts + "\n";

            return fullMenu;
        }
    }
}
