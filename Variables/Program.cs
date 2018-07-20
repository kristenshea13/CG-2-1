using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("what is your name?");
            Console.Write("Type your first name: ");
            String myFirstName;
            myFirstName = Console.ReadLine();

            //String myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();





        }
    }
}
