//with useing we are save time from having to type the namespace all the time
using System;

namespace visualStudioPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
      
                //Creating a new random number Generator
                Random generator = new Random();
                //generate a floating point number between 0 and 1
                double randomNumber = generator.NextDouble();
                //Round a number to a single decimal place
                double roundedNumber = Math.Round(randomNumber, 1);
                //pring out the random number
                Console.WriteLine(roundedNumber);
        }
    }
}
