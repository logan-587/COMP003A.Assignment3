/*
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Week 3 Assignment
 */


namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Welcome to the Terrordome");
            Console.WriteLine("\n*************************************************************************************************\n");
            //If-Else Section

            Console.WriteLine("What grade are you going to get on your organic chemistry midterm?");
            Console.Write("Enter a numberic grade (0-100): ");
            double numericGrade = Convert.ToDouble(Console.ReadLine());

            if (numericGrade > 0 && numericGrade <= 100)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            if(numericGrade == 100)
            {
                Console.WriteLine("\tlol whatever you say");
            }

            if(numericGrade >= 90)
            {
                if (numericGrade < 100)
                {
                    Console.WriteLine("\tLetter Grade: A");
                }
                else if(numericGrade == 100)
                {
                    Console.WriteLine("\tLetter Grade: 'A'");
                }

            }
            else if(numericGrade >= 80)
            {
                Console.WriteLine("\tLetter Grade: B");
            }
            else if(numericGrade >= 70)
            {
                Console.WriteLine("\tLetter Grade: C");
            }
            else if(numericGrade >= 60)
            {
                Console.WriteLine("\tLetter Grade: D");
            }
            else if(numericGrade >= 0 && numericGrade <= 100)
            {
                Console.WriteLine("\tLetter Grade: F");
            }
            
            if(numericGrade < 0 || numericGrade > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t!! Invalid Input !!");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }


            Console.WriteLine("\n*************************************************************************************************\n");
            //Switch Statement Section (love me some alliteration)

            Console.WriteLine("What's your favorite day of the week?");
            Console.Write("Put your answer as an integer 1-7 (Mondays are 1, Tuesdays 2, ... , Sundays 7): ");
            int numericDay = Convert.ToInt32(Console.ReadLine());

            switch (numericDay)
            {
                case 1:
                    Console.WriteLine("\tString Day: Mondays!");
                    break;

                case 2:
                    Console.WriteLine("\tString Day: Tuesdays!");
                    break;

                case 3:
                    Console.WriteLine("\tString Day: Wednesdays!");
                    break;

                case 4:
                    Console.WriteLine("\tString Day: Thursdays!");
                    break;

                case 5:
                    Console.WriteLine("\tString Day: Fridays!");
                    break;

                case 6:
                    Console.WriteLine("\tString Day: Saturdays!");
                    break;

                case 7:
                    Console.WriteLine("\tString Day: Sundays!");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t!! Invalid Input !!");
                    if (i == 1)
                    {
                        Console.WriteLine("\tso you think you're funny, huh? or a bugtester...");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine("\n*************************************************************************************************\n");
        }
    }
}