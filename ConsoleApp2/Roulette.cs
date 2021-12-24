using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Roulette
    {
        public double amount { get; set; }

        public Roulette() { amount = 1000; }

        public void Spin()
        {
            string keyWord;
            int money;
            string choice;
            int ChosenNumber;

            int[] red = { 32, 19, 21, 25, 34, 27, 36, 30, 23, 5, 16, 1, 14, 9, 18, 7, 12, 3 };
            
            int[] black = { 15, 4, 2, 17, 6, 13, 11, 8, 10, 24, 33, 20, 31, 22, 29, 28, 35, 26 };
            
            while (true)
            {
                Random r = new Random();
                int randNum = r.Next(0, 37);

                Console.WriteLine("Do you want play? (type y or n): ");
                keyWord = Console.ReadLine().ToUpper();

                if (keyWord == "Y")
                {
                    Console.WriteLine("Enter amount of bet: ");
                    int.TryParse(Console.ReadLine(), out money);
                    if (money > 0 && money <= 60)
                    {
                        Console.WriteLine("Choose slot: a. number; b. Red; c. Black; ");
                        choice = Console.ReadLine().ToUpper();

                        if (choice == "A")
                        {
                            Console.WriteLine("Enter your lucky number (:D) :");
                            int.TryParse(Console.ReadLine(), out ChosenNumber);

                            if (ChosenNumber > 0 && ChosenNumber <= 36)
                            {
                                if (randNum == ChosenNumber)
                                {
                                    amount = amount + money;
                                    Console.WriteLine($"You win! You have {amount} lari.");
                                    
                                }
                                else
                                {
                                    amount = amount - money;
                                    Console.WriteLine($"You lost! you have {amount} lari.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("your number is out of range!");
                                continue;
                            }
                        }else if (choice == "B")
                        {
                            if (red.Contains(randNum))
                            {
                                amount = amount + money * (1.0) / 5;
                                Console.WriteLine($"You win! You have {amount} lari.");
                            }else
                            {
                                amount = amount - money;
                                Console.WriteLine($"You lost! you have {amount} lari.");
                            }
                        }else if (choice == "C")
                        {
                            if (black.Contains(randNum))
                            {
                                amount = amount + money * (1.0) / 5;
                                Console.WriteLine($"You win! You have {amount} lari.");
                            }else{
                                amount = amount - money;
                                Console.WriteLine($"You lost! you have {amount} lari.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalide Choice!");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"your bet is out of range!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Game over! \n You have {amount} lari.");
                    break;
                }
            }
        }
    }
}
