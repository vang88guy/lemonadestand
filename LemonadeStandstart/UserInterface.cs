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

        public static void ShowMoney(double money)
        {

            Console.WriteLine("Money: " + money);
            Console.WriteLine();
            Console.ReadLine(); ;
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
        public static void DisplayPrice(double item, string name) 
        {
            Console.WriteLine(name + " cost " + item + " cents per unit.");
            Console.WriteLine();
        }
        public static void DisplayWeather(string condition)
        {
            Console.WriteLine("It will be " + condition +" today.");
            Console.WriteLine();
        }
        public static void DisplayWeatherTemp(int temp)
        {
            Console.WriteLine("It will be " + temp + " degrees today.");
            Console.WriteLine();
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
        public static double PriceOfCups(string price)
        {
          
            double quantityOfItem;

            
            {
                Console.WriteLine("How much would you like to charge per " + price + "?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                if(! double.TryParse(Console.ReadLine(), out quantityOfItem));
            }

            return quantityOfItem;
        }

        public static void DisplayPricePerCup(double money) 
        {
            Console.WriteLine("Cups: " + money + " cents each");        
        }
        public static void OutOfItems(string item) 
        {
            Console.WriteLine("Out of " + item);
        }
    }
}
