﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2A_testScores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Select the following option:");
            Console.WriteLine("1. Add numbers together.");
            Console.WriteLine("2. Average ten (10) exam scores to determine raw and letter grades.");
            Console.WriteLine("3. Average up to 100 exam scores to determine raw and letter grades.");
            Console.WriteLine("4. Enter exam scores and let me count how many to determine the raw and letter grades.");

            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You have selected to add numbers together.";
                Console.WriteLine(message);
                addNumbers();
                return false;
            }

            else if (userValue == "2")
            {
                string message = "Average ten (10) exam scores to determine raw and letter grades.";
                Console.WriteLine(message);
                averageTen();
                return false;
            }

            else if (userValue == "3")
            {
                string message = "Average up to 100 exam scores to determine raw and letter grades.";
                Console.WriteLine(message);
                averageNTests();
                return false;
            }

            else if (userValue == "4")
            {
                string message = "Enter exam scores and let me count how many to determine the raw and letter grades.";
                Console.WriteLine(message);
                YouRLazy(); // Write this method!!!!
                return false;
            }
            else
            {
                string message = "Invalid entry, please try again";
                Console.WriteLine(message);
                return true;
            }
        }

        static void addNumbers()
        {
            Console.WriteLine("How many numbers would you like to add together? ");
            int.TryParse(Console.ReadLine(), out int t);

            int sum = 0;
            int num = 0;
            int i = 0;

            for (i = 0; i < t; i++)
            {
                Console.WriteLine("Please enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.Clear();
            Console.WriteLine("The sum of your numbers is: " + sum);
            Console.WriteLine();
            Console.WriteLine("Press enter to return to the Main Menu.");
            Console.ReadLine();

            Console.Clear();
            MainMenu();
        }

        static void averageTen()
        {
            double count = 0;
            double sum = 0;
            double num = 0;
            double i = 0;
            double avg = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a test score between 0 and 100: ");
                num = double.Parse(Console.ReadLine());
                count++;
                sum += num;
                avg = sum / count;
                count++;
            }
            Console.Clear();
            Console.WriteLine("The average of your raw scores is: " + Math.Round(avg, 2) + "%" + " with a letter grade of: " + LetterGrade(avg));
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to return to the Main Menu.");
            Console.ReadLine();

            Console.Clear();
            MainMenu();
        }
        static void averageNTests()
        {
            Console.WriteLine("How many test scores would you like to average? ");
            double.TryParse(Console.ReadLine(), out double t);

            double count = 0;
            double sum = 0;
            double num = 0;
            double i = 0;
            double avg = 0;

            for (i = 0; i < t; i++)
            {
                Console.WriteLine("Please enter a test score between 0 and 100: ");
                num = double.Parse(Console.ReadLine());
                sum += num;
                count++;
                avg = sum / t;
                if (count < t)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("The average of your raw scores is: " + Math.Round(avg, 2) + "%" + " with a letter grade of: " + LetterGrade(avg));
            Console.WriteLine();
            Console.WriteLine("Press enter to return to the Main Menu.");
            Console.ReadLine();

            Console.Clear();
            MainMenu();
        }
        static void YouRLazy()
        {
            double count = 0;
            double sum = 0;
            double avg = 0;
            double num = 0;

            try
            {
                while (num >= 0 && num <= 100)
                {
                    count += 1;
                    Console.WriteLine("Please enter a test score between 0 and 100 (press enter on an empty line to exit and calculate): ");
                    num = double.Parse(Console.ReadLine());
                    sum += num;
                    avg = sum / count;

                    if (num < 0 || num > 100)
                    {
                        sum = sum - num;
                        count = count - 1;
                        avg = sum / count;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch
            {
                Console.WriteLine("You have decided to calculate your total or selected an invalid input. the average of your correctly entered inputs are totalled below.");
            }
            finally
            {
                Console.WriteLine("The average of your raw scores is: " + Math.Round(avg, 2) + "%" + " with a letter grade of: " + LetterGrade(avg));
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the Main Menu.");
                Console.Clear();
            }
            MainMenu();
            Console.ReadLine();
        }
        public static string LetterGrade(double g)
        {
            if (g >= 90)
            {
                return "A";
            }
                else if (g >= 80)
            {
                return "B";
            }
                else if (g >= 70)
            {
                return "C";
            }
                else if (g >= 60)
            {
                return "D";
            }
                else
            {
                return "F";
            }
        }     

    }

}


    

