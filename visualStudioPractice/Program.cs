//with useing we are save time from having to type the namespace all the time
using System;
using System.Threading;
using Microsoft.Win32;

class MainClass
    {

    static void Wait(int waitTime)
    {
        Console.WriteLine("Welcome to the cat food store");
        Thread.Sleep(waitTime);
    }

    static string Ask(String question)
    {
        Console.WriteLine(question);
        return Console.ReadLine();
        
    }

        public static void Main(string[] args)
        {
        Wait(3000);
        string entry = Ask("How many cans are you ordering?");
        //String interpolation, using the $ at the beginning of a string and calling the variable inside of curly braces
        Console.WriteLine($"You entered { entry } cans");
        }
     }

