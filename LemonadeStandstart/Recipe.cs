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

        public int lemonsUseForRecipe = 0;
        public int sugarcubesUseForRecipe = 0;
        public int cupsUseForRecipe = 0;
        public int icecubeUsesForRecipe = 0 ;
        public double pricePerCupForRecipe = 0;
        public Inventory inventory;

        //constructor

        public Recipe()
        {
            inventory = new Inventory();
            
        }

        //member methods
        //While loop subtracting each item from the inventory while the simming a day
        //method for getting lemons

        public void GetLemons(Player player)
        {
            int lemonsUse = UserInterface.GetRcipeItems("lemons");
            
            if (player.inventory.lemons.Count >= 0)
            {              
                player.inventory.SubtractLemonsFromInventory(lemonsUse);
            }
            else 
            { 
               Console.WriteLine("Not enough lemons"); 
            }
            lemonsUseForRecipe += lemonsUse;

        }

        //mehtod for getting sugarcubes
        public void SugarCubes(Player player)
        {
            int sugarUse = UserInterface.GetRcipeItems("sugar");

            if (player.inventory.sugarCubes.Count >= 0)
            {
                player.inventory.SubtractSugarCubesFromInventory(sugarUse);
            }
            //else
            //{

            //}
            sugarcubesUseForRecipe += sugarUse;
        }
        //method for getting icecubes
        public void IceCubes(Player player)
        {
            int iceCubeUse = UserInterface.GetRcipeItems("ice cubes");

            if (player.inventory.iceCubes.Count >= 0)
            {
                player.inventory.SubtractIceCubesFromInventory(iceCubeUse);
            }
            //else
            //{

            //}
            icecubeUsesForRecipe += iceCubeUse;
        }

        //method for getting cups
        public void Cups(Player player)
        {
            int cupUse = UserInterface.GetRcipeItems("cups");

            if (player.inventory.cups.Count >= 0)
            {
                player.inventory.SubtractIceCubesFromInventory(cupUse);
            }
            //else
            //{

            //}
            cupsUseForRecipe += cupUse;
        }

        public void ReicpePerPitcher() 
        { 
            
        }

    }
}
