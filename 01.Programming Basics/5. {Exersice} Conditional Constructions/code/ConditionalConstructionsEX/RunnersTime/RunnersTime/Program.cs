using System;

namespace RunnersTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console three time on runners in Sec
            double fristTime = double.Parse(Console.ReadLine());
            double secoundTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());
            //sum time in seconds
            double sum = fristTime + secoundTime + thirdTime;
            //transform sec to min:sec
            double min = Math.Round(sum / 60, 1);
            double secondMin = Math.Floor(min);
            double sec = sum % 60;
            //write to console mins:sec and go to {0.2} - {0.02}
            if (sec >= 10)
            {
                Console.WriteLine($"{secondMin}:{sec}");

            }
            else
            {
                Console.WriteLine($"{secondMin}:0{sec}");
            }
            //if sec >= 10 print {min}:{sec}
            //else sec < 10 print {min}:0{sec}
        }
    }
}

//using System;

//namespace RunnersTime
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int fristTime = int.Parse(Console.ReadLine());
//            int secoundTime = int.Parse(Console.ReadLine());
//            int thirdTime = int.Parse(Console.ReadLine());
//            int sum = fristTime + secoundTime + thirdTime;

//            int min = sum / 60;
//            double sec = sum % 60;
//            if (sec < 10)
//            {
//                Console.WriteLine($"{min}:0{sec}");
//            }
//            else
//            {
//                Console.WriteLine($"{min}:{sec}");
//            }
//        }
//    }
//}
