﻿using System;
namespace ArrayDemo1
{
    class Program
    {
        static void PrintMenu(string[] theItems, decimal[] thePrices)
        {
            Console.WriteLine("Here is our menu:");
            for (int i = 0; i < theItems.Length; i++)
            {
                Console.WriteLine($"{theItems[i],-12}{thePrices[i],12}");
            }

        }
        static int FindItem(string[] theItems, string search)
        {
            for (int i = 0; i < theItems.Length; i++)
            {
                if (theItems[i].ToLower() == search.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            /*
             *
             *Create a menu used at a coffee house
             *
             *     Item                Price
             *     ----                -----
             *     Coffee              2.00
             *     Espresso            2.50
             *     Muffin              3.50
             *     Croissant           4.00
             * 
             * 
             * 
             */

            // For now we're creating two separate arrays
            string[] items = new string[] { "Coffee", "Espresso", "Muffin", "Croissant" };
            decimal[] prices = new decimal[] { 2.00m, 2.50m, 3.50m, 4.00m };

            PrintMenu(items, prices);
                         
            
            Console.WriteLine("Please make a selection:");
            string entry = Console.ReadLine();
            int index = FindItem(items, entry);
            Console.WriteLine(index);

            if (index > -1)
            {
                Console.WriteLine($"The price of {items[index]} is {prices[index]}");
            }
            else
            {
                Console.WriteLine($"Sorry, we do not have {entry}.");
            }



            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == entry)
                {
                    Console.WriteLine($"The price of the {entry} is {prices[i]}");
                    break;
                }
            }


        }

    }

}