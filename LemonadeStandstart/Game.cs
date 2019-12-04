using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variables
        List<Day> day = new List<Day>();
        public Store store;
        public Player player;
        public Day days;
        Recipe recipe;
        public Pitcher pitcher;





        Customer customer;



        public Game()
        {
            //days = new Day(recipe, player);
            player = new Player();
            store = new Store();
            recipe = new Recipe();
            
        }
        //member methods

        public void RunGame() 
        {
            
            UserInterface.WelcomeToGame();
            player.wallet.DisplayMoney();
            
            player.inventory.DisplayInventory();
            store.PlayerGoToStore(player);

            recipe.MasterRecipe();
            AddDays();
            player.pitcher.ReicpePerPitcher(recipe, player, customer);
            
         
            
            player.wallet.DisplayMoney();
            player.inventory.DisplayInventory();
            
            



        }
        public void AddDays()
        {
            for (int i = 0; i < 7; i++)
            {
                days = new Day(recipe, player);
                day.Add(days);
            }
        }

    }
}
