using System;
using System.Collections.Generic;
using System.Text;

namespace CarSpeed
{
    class Car : ICar
    {

        //tires type
        public string tires { get; set; }
        public string transmission { get; set; }
        public double weight { get; set; }

        //a variable to save the safe speed
        public int perfectSpeed;

        //Checks all options for 4x4 transmission
        public int Check4x4Transmisson()
        {
            if (transmission == "4x4")
            {
                if (tires == "winter")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 30;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 27;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 23;
                    }
                }
                else if (tires == "summer")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 27;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 23;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 20;
                    }
                }
                else if (tires == "all season")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 29;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 26;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 22;
                    }
                }
            }
            return this.perfectSpeed;
        }

        //Checks all options for front transmission
        public int CheckFrontTransmission()
        {
            if (transmission == "front")
            {
                if (tires == "winter")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 28;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 25;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 21;
                    }
                }
                else if (tires == "summer")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 25;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 21;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 18;
                    }
                }
                else if (tires == "all season")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 27;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 24;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 20;
                    }
                }
            }
            return this.perfectSpeed;
        }

        //Checks al option for rear transmission
        public int CheckRearTransmission()
        {
            if (transmission == "rear")
            {
                if (tires == "winter")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 27;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 24;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 20;
                    }
                }
                else if (tires == "summer")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 24;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 20;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 17;
                    }
                }
                else if (tires == "all season")
                {
                    if (weight <= 2000)
                    {
                        return this.perfectSpeed = 26;
                    }
                    else if (weight > 2000 && weight <= 3000)
                    {
                        return this.perfectSpeed = 23;
                    }
                    else if (weight > 3000 && weight <= 4000)
                    {
                        return this.perfectSpeed = 19;
                    }
                }
            }
            return this.perfectSpeed;
        }

        //constructor
        public Car(string tires, string transmission, double weight)
        {
            this.tires = tires;
            this.transmission = transmission;
            this.weight = weight;
            Check4x4Transmisson();
            CheckFrontTransmission();
            CheckRearTransmission();
        }

        //Prints the safe speed to drive
        public override string ToString()
        {
            return $"Your speed should be: {this.perfectSpeed}";
        }
    }
}
