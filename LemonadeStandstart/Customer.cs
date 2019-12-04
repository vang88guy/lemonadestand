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
        int icecubesWant;
        public int newcup;
        public bool pref;

        public List<Cup> cups = new List<Cup>();
        //List<string> names;


        public Customer(Recipe recipe, Player player)
        {
            BuyLogic(recipe, player);
            //pref = BuyLogic(recipe); 
            
        }


        //methods
        public bool  BuyLogic(Recipe recipe, Player player)
        {
            Random ran = new Random();
            lemonsWant = ran.Next(4, 10);
            sugarWant = ran.Next(4, 10);
            icecubesWant = ran.Next(4, 15);
             int cups = 0;


            if (lemonsWant - 2 <= recipe.lemonsUseForRecipe && sugarWant - 2 <= recipe.sugarcubesUseForRecipe && icecubesWant - 5 <= recipe.icecubeUsesForRecipe)
            {

                if (player.inventory.cups.Count >= 1)
                {
                    player.inventory.SubtractCupsFromInventory(1);
                    player.wallet.AddMoney(recipe.pricePerCupForRecipe);
                    cups++;
                    newcup += cups;
                    AddUsedCups();
                    
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



        public void AddUsedCups()
        {
          
                Cup cup = new Cup();
                cups.Add(cup);
            
        }

    }



}
