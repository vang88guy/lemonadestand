using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    
    class Day
    {
        public Weather weather;
        public Customer customer;
        public List<Customer> CustomerList;
        
        public Day(Recipe recipe, Player player)
        {
            CustomerList = new List<Customer>();
            weather = new Weather();

            AddWeather();
            TempCustomer(recipe, player);

        }
        public void AddWeather() 
        {
            weather.WeatherTemp();
            weather.WeatherCondition();
        }
        public void TempCustomer(Recipe recipe, Player player)
        {

            switch (weather.weatherCon)
            {
                case "Sunny":
                    AddCustomer(80, recipe, player);
                    break;
                case "Cloudy":
                    AddCustomer(70, recipe, player);
                    break;
                case "Rainy":
                    AddCustomer(40, recipe, player);
                    break;
                case "Windy":
                    AddCustomer(50, recipe, player);
                    break;
            }
        }
        public void AddCustomer(int numberOfCustomers, Recipe recipe, Player player) 
        {
            
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer(recipe, player);
                CustomerList.Add(customer);
            }
            
        }
        
    }
}
