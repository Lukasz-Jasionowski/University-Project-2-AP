using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2
{
    internal class Flowers
    {
        private int firstRandomFlower;
        private int secondRandomFlower;
        private int thirdRandomFlower;
        private int fourthRandomFlower;
        private int choice;
        private string firstFlower;
        private string secondFlower;
        private string thirdFlower;
        private string fourthFlower;
        private string[] flowers = { "Rose", "Violet", "Daisy", "Orchid" };
        Random randomFlower = new Random();
        Price flowersPrice = new Price();

        public Flowers()
        {
        }
        public void GenerateFlowers()
        {
            firstRandomFlower = randomFlower.Next(flowers.Length);
            secondRandomFlower = randomFlower.Next(flowers.Length);
            thirdRandomFlower = randomFlower.Next(flowers.Length);
            fourthRandomFlower = randomFlower.Next(flowers.Length);
            firstFlower = flowers[firstRandomFlower];
            secondFlower = flowers[secondRandomFlower];
            thirdFlower = flowers[thirdRandomFlower];
            fourthFlower = flowers[fourthRandomFlower];
        }
        public void TotalPrice()
        {
            flowersPrice.TotalAmount += flowersPrice.OrderAmount;
        }
        public void GenerateOrder()
        {
            try
            {
                Console.WriteLine("Welcome to our flower shop.\nEnter the number of how many flowers you want to purchase a bouquet from.\nSpecify a number from 1 to 4.");
                do
                {
                    GenerateFlowers();
                    TotalPrice();
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Thank you for shopping at our flower shop.");
                            break;
                        case 1:
                            WhatKindOfFlowers();
                            Console.WriteLine($"Flowers from which the bouquet was created: {firstFlower}\nThe order amount is: {flowersPrice.OrderAmount} PLN");
                            break;
                        case 2:
                            WhatKindOfFlowers();
                            Console.WriteLine($"Flowers from which the bouquet was created: {firstFlower}, {secondFlower}\nThe order amount is: {flowersPrice.OrderAmount} PLN");
                            break;
                        case 3:
                            WhatKindOfFlowers();
                            Console.WriteLine($"Flowers from which the bouquet was created: {firstFlower}, {secondFlower}, {thirdFlower}\nThe order amount is: {flowersPrice.OrderAmount} PLN");
                            break;
                        case 4:
                            WhatKindOfFlowers();
                            Console.WriteLine($"Flowers from which the bouquet was created: {firstFlower}, {secondFlower}, {thirdFlower}, {fourthFlower}\nThe order amount is: {flowersPrice.OrderAmount} PLN");
                            break;
                        default:
                            Console.WriteLine("Incorrect value.\nSpecify a number from 1 to 4.");
                            break;
                    }
                } while (choice != 0);
                Console.WriteLine($"\nToday's profit = {flowersPrice.TotalAmount} PLN");
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect value.\nSpecify a number.");
            }
        }
        public void WhatKindOfFlowers()
        {
            switch (choice)
            {
                case 1:
                    if (firstFlower == "Rose")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[0];
                    }
                    if (firstFlower == "Violet")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[1];
                    }
                    if (firstFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[2];
                    }
                    if (firstFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[3];
                    }
                    break;
                case 2:
                    if (firstFlower == "Rose")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[0];
                    }
                    if (firstFlower == "Violet")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[1];
                    }
                    if (firstFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[2];
                    }
                    if (firstFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[3];
                    }
                    if (secondFlower == "Rose")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[0];
                    }
                    if (secondFlower == "Violet")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[1];
                    }
                    if (secondFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[2];
                    }
                    if (secondFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[3];
                    }
                    break;
                case 3:
                    if (firstFlower == "Rose")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[0];
                    }
                    if (firstFlower == "Violet")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[1];
                    }
                    if (firstFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[2];
                    }
                    if (firstFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[3];
                    }
                    if (secondFlower == "Rose")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[0];
                    }
                    if (secondFlower == "Violet")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[1];
                    }
                    if (secondFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[2];
                    }
                    if (secondFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[3];
                    }
                    if (thirdFlower == "Rose")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[0];
                    }
                    if (thirdFlower == "Violet")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[1];
                    }
                    if (thirdFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[2];
                    }
                    if (thirdFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[3];
                    }
                    break;
                case 4:
                    if (firstFlower == "Rose")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[0];
                    }
                    if (firstFlower == "Violet")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[1];
                    }
                    if (firstFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[2];
                    }
                    if (firstFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount = flowersPrice.price[3];
                    }
                    if (secondFlower == "Rose")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[0];
                    }
                    if (secondFlower == "Violet")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[1];
                    }
                    if (secondFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[2];
                    }
                    if (secondFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[3];
                    }
                    if (thirdFlower == "Rose")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[0];
                    }
                    if (thirdFlower == "Violet")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[1];
                    }
                    if (thirdFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[2];
                    }
                    if (thirdFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[3];
                    }
                    if (fourthFlower == "Rose")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[0];
                    }
                    if (fourthFlower == "Violet")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[1];
                    }
                    if (fourthFlower == "Daisy")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[2];
                    }
                    if (fourthFlower == "Orchid")
                    {
                        flowersPrice.OrderAmount += flowersPrice.price[3];
                    }
                    break;
            }
        }
    }
}