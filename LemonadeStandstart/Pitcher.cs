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
        public int cups;
        //int pitcher = 16(cupsPerPitch);

        public Pitcher(Recipe recipe, Player player)
        {
            ReicpePerPitcher(recipe.lemonsUseForRecipe, recipe.sugarcubesUseForRecipe, recipe.icecubeUsesForRecipe, player);

        }
        //member methods
        public void ReicpePerPitcher(int lemonsUseForRecipe, int sugarcubesUseForRecipe, int icecubeUsesForRecipe, Player player)
        {
            int lemonsPerPitcher = lemonsUseForRecipe;
            int sugarcubesPerPitcher = sugarcubesUseForRecipe;
            int icecubesPerPitcher = icecubeUsesForRecipe;
            int cupsPerPitcher;



            //method of how many cups are in a a pitcher

          
                while(cups == 12 || cups == 24 || cups == 36 || cups == 48 || cups == 60 || cups == 72 || cups == 84 || cups == 96 || cups == 108)
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

                }
            }
        
    }
}
