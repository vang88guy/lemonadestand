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
        int cupsPerPitch = 1;
        //int pitcher = 16(cupsPerPitch);

        public Pitcher()
        {

        }
        //member methods
        //method of how many cups are in a a pitcher
        while (player.inventory.cups.Count >= 1) 
            {
                for(cups = 16, cups++) 
                {
                    if (player.inventory.lemons.Count >= 0)
                    {
                        player.inventory.SubtractLemonsFromInventory(lemonsPerPitcher);
                    }
                    else
                    {
                        UserInterface.OutOfItems("lemons");
                    }
                    if (player.inventory.iceCubes.Count >= 0)
                    {
                        player.inventory.SubtractIceCubesFromInventory(icecubesPerPitcher);
                    }
                    else
                    {
                        UserInterface.OutOfItems("ice cubes");
                    }
                    if (player.inventory.sugarCubes.Count >= 0)
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
