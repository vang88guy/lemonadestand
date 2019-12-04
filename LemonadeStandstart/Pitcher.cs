using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        //member variables
        //public int cups
        //{ get; set; }
        //public List<Cup> cups;
        //int pitcher = 16(cupsPerPitch);
        Customer customer;


        public Pitcher()
        {
            
            //ReicpePerPitcher(recipe.lemonsUseForRecipe, recipe.sugarcubesUseForRecipe, recipe.icecubeUsesForRecipe, player);
            //cups += customer.newcups;
            //cups = new List<Cup>();
        }
        //member methods
        //public void AddUsedCups(int numberOfCups)
        //{
        //    for (int i = 0; i < numberOfCups; i++)
        //    {
        //        Cup cup = new Cup();
        //        cups.Add(cup);
        //    }
        //}

        public void ReicpePerPitcher(Recipe recipe, Player player, Customer customer)
        {
            int lemonsPerPitcher = recipe.lemonsUseForRecipe;
            int sugarcubesPerPitcher = recipe.sugarcubesUseForRecipe;
            int icecubesPerPitcher = recipe.icecubeUsesForRecipe;
            int count = customer.cups.Count;
            int newcount = count / 12;
            //int cupsPerPitcher;


            //if (day.CustomerList[i].pref == true)
            //{
            //    //method of how many cups are in a a pitcher
            //    if (player.inventory.cups.Count >= 1)
            //    {
            //        player.inventory.SubtractCupsFromInventory(1);
            //        player.wallet.AddMoney(recipe.pricePerCupForRecipe);


            //    }
            //    else
            //    {
            //        UserInterface.OutOfItems("cups");
            //    }
            //}
            //while (customer.cups.Count == 12 || customer.cups.Count == 24 || customer.cups.Count == 36 || customer.cups.Count == 48 || customer.cups.Count == 60 || customer.cups.Count == 72 || customer.cups.Count == 84 || customer.cups.Count == 96 || customer.cups.Count == 108)
            for (int i = 0; i < newcount; i++)
           
                {
                    if (player.inventory.lemons.Count >= 2)
                    {
                        player.inventory.SubtractLemonsFromInventory(lemonsPerPitcher);
                    }
                    else
                    {
                        UserInterface.OutOfItems("lemons");
                    }
                    if (player.inventory.iceCubes.Count >= 2)
                    {
                        player.inventory.SubtractIceCubesFromInventory(icecubesPerPitcher);
                    }
                    else
                    {
                        UserInterface.OutOfItems("ice cubes");
                    }
                    if (player.inventory.sugarCubes.Count >= 2)
                    {
                        player.inventory.SubtractSugarCubesFromInventory(sugarcubesPerPitcher);
                    }
                    else
                    {
                        UserInterface.OutOfItems("sugar");
                    }
                    break;
                }
            
        }   
    }
}
