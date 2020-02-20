using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public enum Categories
        {
            Appetizer, MainCourse, Dessert
        }
        public Categories Category { get; set; }
        private DateTime _dateAdded;
        public DateTime DateAdded
        {
            get { return _dateAdded; }
            set { _dateAdded = DateTime.Now; }
        }

        public override String ToString()
        {
            string menuItemPrint = "";

            menuItemPrint = Name + " - $" + Price + "\n" + Description + "\n";

            return menuItemPrint;
        }

        public override bool Equals(Object o)
        {

            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            MenuItem menuItemObj = o as MenuItem;
            return Name == menuItemObj.Name;
        }

        public bool CheckNew()
        {
            return (DateAdded.Date >= DateTime.Now.Date.AddMonths(-3));
        }
    }
}
