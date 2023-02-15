using System;
namespace Uppgift_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt namn.");
            string ord1 = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn.");
            string ord2 = Console.ReadLine();

            if (ord1.CompareTo(ord2) < 0) 

                Console.WriteLine("Ditt förnamn kommer först i bokstavsordning");

            else
                Console.WriteLine("Ditt efternamn kommer först i bokstavsordning ");
            
        }
    }
}