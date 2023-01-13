using System;
namespace Uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in antalet städer du har besökt");
            int antal = int.Parse(Console.ReadLine());
            string[] stad= new string[antal];
            

            for(int i=0; i<antal; i++)
            {
                Console.WriteLine("Skriv de städer du besökt:");
                stad[i]= Console.ReadLine();
                
            }

            Console.Write("Du har varit i städerna");
            for(int i=0; i<antal; i++)
            {
                Console.Write(" " + stad[i]);
            }
        }

    }
}
