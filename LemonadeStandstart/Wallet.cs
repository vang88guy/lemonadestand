using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 50.00;
        }

        public void DisplayMoney()
        {
            UserInterface.ShowMoney(money);
        }
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
        public void AddMoney(double transactionAmount)
        {
            money += transactionAmount;
        }
        //need method for adding money back into wallet.

    }
}
