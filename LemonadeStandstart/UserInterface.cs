using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        

        public static void WelcomeToGame() 
        {
            Console.WriteLine("Welcome to the Lemonade Stand Game");
            Console.WriteLine();
            Console.WriteLine("You have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand! \n" +
                "You’ll have complete control over your business, including pricing, quality control, inventory control, and purchasing \n" +
                "supplies. Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine();
            Console.WriteLine("Press enter to contiune ");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ShowInventory(int numberofLemons, int numberofSugarCubes, int numberofIceCubes, int numberofCups)
        {
            Console.WriteLine("Invetory");
            Console.WriteLine("Lemons: " + numberofLemons +
                              "\nSugarcubes: " + numberofSugarCubes +
                              "\nIce Cubes: " + numberofIceCubes +
                              "\nCups: " + numberofCups);
            Console.ReadLine(); ;
        }
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static int GetRcipeItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like use?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
    }
}
