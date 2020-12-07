using System;

namespace _5_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            char[] cArray = username.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            password = reverse;

                int count = 1;
            while (true)
            {
                 string enterPassword = Console.ReadLine();
                
                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (enterPassword != password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                count++;
            }
            
        }
    }
}// 100% JUDGE


