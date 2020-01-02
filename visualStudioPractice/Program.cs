//with useing we are save time from having to type the namespace all the time
using System;
using System.Threading;


    class MainClass
    {

    static void Wait()
    {
        Console.WriteLine("Welcome to the cat food store");
        Thread.Sleep(3000);
        Console.WriteLine("What can i do for you?");
    }

    static void CountToThree()
    {
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
    }

        public static void Main(string[] args)
        {
        Wait();
        CountToThree();
        }
     }

