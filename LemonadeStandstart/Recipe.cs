using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        //member variables

        int lemonsUse;
        int sugarcubesUse;
        int cupsUse;
        int icecubeUses;
        public Inventory inventory;

        //constructor

        public Recipe()
        {
            inventory = new Inventory();
        }

        //member methods
        //While loop subtracting each item from the inventory while the simming a day
        //method for getting lemons
        //mehtod for getting sugarcubes
        //method for getting cups
        //method for getting icecubes
    }
}
