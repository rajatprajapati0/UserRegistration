using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    internal class Fillinfo
    {
        public void fill()
        {

            RegistrationForm form = new RegistrationForm();
            bool check = false;
            Console.WriteLine("\nFirst name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("\nEnter your Name :");
                check = form.Firstname(Console.ReadLine());

                if (!check)
                {
                    Console.WriteLine("\nplease follow - First name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("******done");
                }


            }

            form = new RegistrationForm();
            check = false;
            Console.WriteLine("\nLast name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("\nEnter your Name :");
                check = form.LastName(Console.ReadLine());

                if (!check)
                {
                    Console.WriteLine("\nplease follow - Last name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("******done");
                }


            }

        }

    }
}
