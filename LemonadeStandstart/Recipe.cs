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
        public int cups = 1;
        public double pricePerCupForRecipe = 0;

        public Inventory inventory;

        //constructor

        public Recipe()
        {
            inventory = new Inventory();
            
        }

        //member methods
        //While loop subtracting each item from the inventory while simming a day
        //method for getting lemons

        public int GetLemons(Player player)
        {
            int lemonsUse = UserInterface.GetRcipeItems("lemons");
            
            if (player.inventory.lemons.Count >= 0)
            {              
                player.inventory.SubtractLemonsFromInventory(lemonsUse);
            }
            else 
            {
                UserInterface.OutOfItems("lemons");
            }
            return lemonsUseForRecipe += lemonsUse;

        }

        //mehtod for getting sugarcubes
        public int SugarCubes()
        {
            int sugarUse = UserInterface.GetRcipeItems("sugar");

            //if (player.inventory.sugarCubes.Count >= 0)
            //{
            //    player.inventory.SubtractSugarCubesFromInventory(sugarUse);
            //}
            //else
            //{
            //    UserInterface.OutOfItems("sugar");
            //}
            return sugarcubesUseForRecipe += sugarUse;
        }
        //method for getting icecubes                            
        public int IceCubes(Player player)
        {
            int iceCubeUse = UserInterface.GetRcipeItems("ice cubes");

            if (player.inventory.iceCubes.Count >= 0)
            {
                player.inventory.SubtractIceCubesFromInventory(iceCubeUse);
            }
            else
            {
                UserInterface.OutOfItems("ice cubes");
            }
            return icecubeUsesForRecipe += iceCubeUse;
        }

        //method for getting cups
        public double Cups()
        {
            double cupUse = UserInterface.PriceOfCups("cups");

           
            return pricePerCupForRecipe += cupUse;
        }

        public void ReicpePerPitcher(int lemonsUseForRecipe, int sugarcubesUseForRecipe, int icecubeUsesForRecipe, Player player) 
        {
            int lemonsPerPitcher = lemonsUseForRecipe;
            int sugarcubesPerPitcher = sugarcubesUseForRecipe;
            int icecubesPerPitcher = icecubeUsesForRecipe;
            int cupsPerPitcher;

            
        }

    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
}
