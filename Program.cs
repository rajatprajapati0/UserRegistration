using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" welcome User_Registration Program");

            Fillinfo fillinfo = new Fillinfo();
            fillinfo.fill();

        }
    }
}
