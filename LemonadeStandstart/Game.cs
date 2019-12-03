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
        Day days;
        Recipe recipe = new Recipe();
        Weather weather = new Weather();
        int numberOfCustomers;
        



        public Game()
        {
            player = new Player();
            store = new Store();
            
        }
        //member methods

        public void RunGame() 
        {
            UserInterface.WelcomeToGame();
            player.wallet.DisplayMoney();
            
            player.inventory.DisplayInventory();
            store.PlayerGoToStore(player);
            
            Console.Clear();
            AddDays();
            player.wallet.DisplayMoney();
            player.inventory.DisplayInventory();
            
            



        }
        public void AddDays() 
        {
            days = new Day(numberOfCustomers, recipe, player, weather);
            day.Add(days);
        }

    }
}
