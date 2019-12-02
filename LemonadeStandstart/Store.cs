using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        // constructor (SPAWNER)
        public Store()
        {
            pricePerLemon = .25;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .15;

        }

        // member methods (CAN DO)


        public void SellLemons(Player player)
        {
            UserInterface.DisplayPrice(pricePerLemon, "Lemons");
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            if (player.wallet.Money >= transactionAmount)
            {
                player.wallet.PayMoneyForItems(transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
            player.wallet.DisplayMoney();

        }

        public void SellSugarCubes(Player player)
        {
            UserInterface.DisplayPrice(pricePerSugarCube, "Sugar Cubes");
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar");
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }
            player.wallet.DisplayMoney();
        }

        public void SellIceCubes(Player player)
        {
            UserInterface.DisplayPrice(pricePerIceCube, "Ice Cubes");
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
            player.wallet.DisplayMoney();
        }

        public void SellCups(Player player)
        {
            UserInterface.DisplayPrice(pricePerCup, "Cups");
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
            }
            player.wallet.DisplayMoney();
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }

        public void PlayerGoToStore(Player player)
        {
            SellLemons(player);
            SellSugarCubes(player);
            SellIceCubes(player);
            SellCups(player);
            

        }
    }
}

