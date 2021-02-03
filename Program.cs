using System;

namespace CarSpeed
{
    class Program
    {

        //Sets the console setting

        public static void PrintIntoduction()
        {
            Console.WriteLine("Hello! Welcome to the console program that tells you with how much speed you should drive in winter.");
        }

        public static void PrintTireInput()
        {
            Console.WriteLine("Which type of tire are on your car (winter, summer, all season)?");
        }

        public static void PrintTransmissionInput()
        {
            Console.WriteLine("Which is your type of transmisson (front, rear, 4x4)?");
        }

        public static void PrintWeightInput()
        {
            Console.WriteLine("How much weights your car?");
        }

        public static void PrintTextColorInput()
        {
            Console.WriteLine("Which color you would like to be the text (red, cyan, blue, green, black, white or gray)?");
        }

        public static void TextColor(string textColor)
        {
            if (textColor == "green" || textColor == "Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (textColor == "blue" || textColor == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (textColor == "red" || textColor == "Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (textColor == "cyan" || textColor == "Cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (textColor == "black" || textColor == "Black")
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (textColor == "gray" || textColor == "Gray")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (textColor == "white" || textColor == "White")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Not existing color! The text will be with default color.");
            }
        }

        public static void PrintBackgroundColorInput()
        {
            Console.WriteLine("Which color you would like to be the background (red, cyan, blue, green, black, white or gray)?");
        }

        public static void BackgroundColor(string backgroundColor)
        {
            if (backgroundColor == "green" || backgroundColor == "Green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (backgroundColor == "blue" || backgroundColor == "Blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (backgroundColor == "red" || backgroundColor == "Red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (backgroundColor == "cyan" || backgroundColor == "Cyan")
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if (backgroundColor == "black" || backgroundColor == "Black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (backgroundColor == "gray" || backgroundColor == "Gray")
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else if (backgroundColor == "white" || backgroundColor == "White")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Not existing color! The background will be with default color.");
            }
        }

        public static void PrintDateAndTime()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString());
        }

        public static void SetConsoleTitle()
        {
            Console.Title = "Winter speed";
        }

        static void Main(string[] args)
        {

            SetConsoleTitle();
            PrintDateAndTime();
            PrintIntoduction();

            PrintBackgroundColorInput();
            string backgroundColor = Console.ReadLine();
            BackgroundColor(backgroundColor);

            PrintTextColorInput();
            string textColor = Console.ReadLine();
            TextColor(textColor);

            PrintTireInput();
            string tires = Console.ReadLine();
            PrintTransmissionInput();
            string transmission = Console.ReadLine();
            PrintWeightInput();
            double weight = Double.Parse(Console.ReadLine());

            Car car1 = new Car(tires, transmission, weight);

            Console.WriteLine(car1);

        }
    }
}
