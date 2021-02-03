using System;

namespace CarSpeed
{
    class Program
    {

        //sets the console setting
        public static void ConsoleSettings()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Winter Speed";

        }

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

        static void Main(string[] args)
        {
            ConsoleSettings();
            PrintIntoduction();

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
