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
        int currentDay;
        public Store store;
        public Player player;
        
        public Game()
        {
            player = new Player();
            store = new Store();
            

        }
        //member methods

        public void RunGame() 
        {
            UserInterface.WelcomeToGame();
           
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellIceCubes(player);

        }


    }
}
