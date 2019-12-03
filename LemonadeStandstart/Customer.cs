using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    
    class Customer
    {
        //member variables
        int lemonsWant;
        int sugarWant;
        int cups;
        int icecubesWant;
        Pitcher pitcher;
        //List<string> names;


        public Customer(Recipe recipe, Player player)
        {
            BuyLogic(recipe, player);
        }


        //methods
        public bool BuyLogic(Recipe recipe, Player player) 
        {
            Random ran = new Random();
            lemonsWant = ran.Next(4, 10);
            sugarWant = ran.Next(4, 10);
            icecubesWant = ran.Next(4, 15);

            if(lemonsWant-1 <= recipe.lemonsUseForRecipe  && sugarWant-1 <= recipe.sugarcubesUseForRecipe && icecubesWant-1 <= recipe.icecubeUsesForRecipe) 
            {
                if (player.inventory.cups.Count >= 1)
                {
                    player.inventory.SubtractCupsFromInventory(1);
                    player.wallet.AddMoney(recipe.pricePerCupForRecipe);
                    cups++;
                    pitcher.cups = cups;
                }
                else 
                {
                    UserInterface.OutOfItems("cups");
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        public void SetPerf() 
        { 
        
        }

    }

   

}
