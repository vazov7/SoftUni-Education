using System;
using System.Threading;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();
            bool validPasswordLenght = CheckValidPasswordLenght(password);
            if (validPasswordLenght == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");

            }
            bool isDigitOrLetter = CheckPasswordForDigistsAndLetters(password);

            if (isDigitOrLetter == false)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            bool isHaveTwoNums = IsHaveTwoNumsInPassword(password);
            if (isHaveTwoNums == false)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }
            if (validPasswordLenght && isDigitOrLetter && isHaveTwoNums)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        private static bool CheckValidPasswordLenght(string password)
        {
            int passwordLenght = password.Length;
            if (passwordLenght >= 6 && passwordLenght <= 10)
            {
                return true;
            }
            else
            {
             return false;
            }
        }

        private static bool IsHaveTwoNumsInPassword(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckPasswordForDigistsAndLetters(string password)
        {

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;

                }
            }
            return true;
        }

    }
}
