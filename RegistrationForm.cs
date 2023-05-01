using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Pattern
    {
        public static string FirstName = @"^[A-Z]{1}[a-z]{2,}$";

    }

    internal class RegistrationForm
    {

        public bool Firstname(string userName)
        {
            Regex name = new Regex(Pattern.FirstName);
            return name.IsMatch(userName);
        }

    }
}
