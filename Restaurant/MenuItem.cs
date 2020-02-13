using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        string Name { get; set; }
        double Price { get; set; }
        string Description { get; set; }
        string Category { get; set; }
        DateTime DateAdded
        {
            get { return DateAdded; }
            set { DateAdded = DateTime.Now; }
        }
        bool IsNew
        {
            set { IsNew = (DateAdded.Date >= DateTime.Now.Date.AddMonths(-3)); }
        }

    }
}
