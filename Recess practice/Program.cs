using System;

namespace Recess_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double itemPrice;
            double LoyaltyPoint = 0;
            double TotalPrice = 0;
            Console.Write("Are you a student (y/n):");
            char Student = char.Parse(Console.ReadLine());
            while (true)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Enter the item Price:");
                    itemPrice = double.Parse(Console.ReadLine());
                    if (itemPrice == 0)
                        break;
                    TotalPrice += itemPrice;
                }


                if (Student == 'Y')
                {
                    if (TotalPrice >= 80)
                    {
                        LoyaltyPoint = (int)(TotalPrice / 8);
                    }

                }

                else if (Student == 'n')
                {
                    if (TotalPrice >= 120)
                    {
                        LoyaltyPoint = (int)(TotalPrice / 15); // Calculate loyalty points for non-students
                    }
                }

                Console.WriteLine("You are{0} a student, have spent {1:C} today, and have earned {2} loyalty points.",
                                  (Student == 'y') ? "" : " not", TotalPrice, LoyaltyPoint);

                Console.ReadLine(); // Ensure the program waits for user input at the end
            }

        }
        }
    }

