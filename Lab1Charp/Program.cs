#nullable enable
using System;

namespace Lab1
{
    public class Lab1
    {
        static void task2_10()
        {
            Console.Write("2-digit number = ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                int digit_1 = number % 10;
                int digit_2 = number / 10;
                int sum = digit_1 + digit_2;
                if (sum % 2 == 1)
                {
                    Console.WriteLine("Sum is odd");
                }
                else
                {
                    Console.WriteLine("Sum is even");
                }
            }
            else
            {
                Console.WriteLine("Incorrect value. Input correct value.");
            }
        }

        static void task3_10()
        {
            double minY = -100;
            Console.Write("Enter the x-coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the y-coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double triglY = -Math.Abs(x);

            if (y < triglY && y > minY)
            {
                Console.WriteLine("Yes");
            }
            else if (y == minY || y == triglY)
            {
                Console.WriteLine("On the border");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void task4_10()
        {
            Console.Write("Enter the number of days (n > 0): ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n > 0)
            {
                if (n > 0)
                {
                    DateTime currentData = DateTime.Now;
                    DateTime searchData = currentData.AddDays(-n);
                    Console.WriteLine(
                        "Result : "
                            + searchData.Day
                            + "."
                            + searchData.Month
                            + "."
                            + searchData.Year
                    );
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number of days (n > 0).");
            }
        }

        static int SquareOfSum(int a, int b)
        {
            int sum = a + b;
            int square = sum * sum;
            return square;
        }

        static void task5_10()
        {
            Console.Write("Input a : ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int a))
            {
                Console.Write("Input b : ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int b))
                {
                    int result = SquareOfSum(a, b);
                    Console.WriteLine("Result : " + result);
                }
                else
                {
                    Console.WriteLine("Incorrect value. Input correct value b.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect value. Input correct value a.");
            }
        }

        static void task6_10()
        {
            Console.Write("Input a : ");
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double a))
            {
                Console.Write("Input b : ");
                input = Console.ReadLine();
                if (double.TryParse(input, out double b))
                {
                    double result = 5 + (b / ((b * b) + 1)) + (a - b) / (a + b);
                    Console.WriteLine("Result : " + result);
                }
                else
                {
                    Console.WriteLine("Incorrect value. Input correct value b.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect value. Input correct value a.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine("Select a task:");
                Console.WriteLine("1. Task 2");
                Console.WriteLine("2. Task 3");
                Console.WriteLine("3. Task 4");
                Console.WriteLine("4. Task 5");
                Console.WriteLine("5. Task 6");
                Console.WriteLine("6. Exit");
                Console.WriteLine("=========================================================");
                Console.Write("Enter your choice >>> ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        task2_10();
                        break;

                    case "2":
                        task3_10();
                        break;

                    case "3":
                        task4_10();
                        break;

                    case "4":
                        task5_10();
                        break;

                    case "5":
                        task6_10();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
#nullable disable
