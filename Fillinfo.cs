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

           
            check = false;

            while (!check)
            {
                Console.Write("Enter your email :");
                check = form.Email(Console.ReadLine());

                if (!check)
                {
                    Console.WriteLine("\nplease follow - please enter right email ");
                }
                else
                {
                    Console.WriteLine("*****done");
                }

            }

            check = false;
            Console.WriteLine("\nplease enter country code +91 and a space betweeen code and number");

            while (!check)
            {
                Console.Write("\nEnter your Mobile No. : ");
                check = form.MobileNumber(Console.ReadLine());
                if (!check)
                {
                    Console.WriteLine("\nplease follow - please enter country code +91 and a space betweeen code and number");
                }
                else
                {
                    Console.WriteLine("******done");
                }
            }

        }

    }
}
