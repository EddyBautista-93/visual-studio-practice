using System;

namespace visualStudioPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
      
                //Creating a new random number Generator
                System.Random generator = new System.Random();
                //generate a floating point number between 0 and 1
                double randomNumber = generator.NextDouble();
                //Round a number to a single decimal place
                double roundedNumber = System.Math.Round(randomNumber, 1);
                //pring out the random number
                System.Console.WriteLine(roundedNumber);
        }
    }
}
