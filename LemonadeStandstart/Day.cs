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
        List<Customer> Customer = new List<Customer>();
        public Day()
        {
            weather = new Weather();
            
        }

        public void AddCustomer(int numberOfCustomers, Recipe recipe, Player player) 
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customer = new Customer(recipe, player);
                Customer.Add(customer);
            }
            
        }   
    }
}
