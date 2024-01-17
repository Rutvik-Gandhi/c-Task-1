using System;

namespace ConsoleApp1Assignment1Prog2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables for program

            int choice = 1;
            double total = 0.0;
            double subTotal = 0.0;
            double basePrice = 0.0;
            double weight = 0.0;
            int numberOfItemPurchased = 0;

            //using while loop

            while(true) {

                //printing items and price chart

                Console.WriteLine("Items available, 1-Grapes, 2-Mangoes, 3-Pears, 4-Peaches, 5-Banana, 6-Kiwi and 0-Print Receipt");
                Console.WriteLine();
                Console.WriteLine("Price chart, Grapes - 0.59, Mangoes - 1.69, Pears - 0.49, Peaches - 1.99, Banana - 1.23, Kiwi - 1.25");
                Console.WriteLine();
                Console.WriteLine();

                //taking choice from user

                Console.Write("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                //breaking loop if user choose 0

                if (choice == 0)
                    break;

                //User has to be select number from 1 to 6 otherwise it shows invalid item code message and he/she will not able to enter weight of item.
               
                if (choice >= 1 && choice <= 6){
                    Console.Write("Enter the weight: ");
                    weight = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine("Please enter valid item Number");
                    Console.WriteLine();
                    Console.WriteLine();
                    continue;
                }
               
                //switch case to calculate price for particular item
                switch (choice)
                {
                    case 1:
                        basePrice = 0.59;
                        subTotal += basePrice * weight;
                        break;
                            
                    case 2:
                        basePrice = 1.69;
                        subTotal += basePrice * weight;
                        break;

                    case 3:
                        basePrice = 0.49;
                        subTotal += basePrice * weight;
                        break;

                    case 4:
                        basePrice = 1.99;
                        subTotal += basePrice * weight;
                        break;

                    case 5:
                        basePrice = 1.23;
                        subTotal += basePrice * weight;
                        break;

                    case 6:
                        basePrice = 1.25;
                        subTotal += basePrice * weight;
                        break;


                }
                //to count number of item purchased

                numberOfItemPurchased++;
            }

            //calculating total

            total = subTotal + subTotal * 0.13;

            //printing receipt

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Number of items puchased are {numberOfItemPurchased}");
            Console.WriteLine($"All the item cost subtotal is {subTotal}");
            Console.WriteLine($"HST amount is {subTotal * 0.13}");
            Console.WriteLine();
            Console.WriteLine($"Grand total is {total}");

        }
    }
}
