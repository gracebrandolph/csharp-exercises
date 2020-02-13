using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        DateTime DateUpdated { get; set; }
        List<MenuItem> CurrentMenu { get; set; }
    }
}
