using System;

namespace MetricConventor
{
    class Program
    {
        static void Main(string[] args)
        {
            //read read umber from console
            double num = double.Parse(Console.ReadLine());
            //read 2 metric from console from<m> to <cm>
            string firstMertic = Console.ReadLine();
            string secoundMetric = Console.ReadLine();
            //make varuable to exit
            double exit = 0.000;
            //make 2 verification <m>==<mm>
            if (firstMertic == "m" && secoundMetric == "mm")
            {
                exit = num / 0.0010000;
            }
            else if (firstMertic == "mm" && secoundMetric == "m")
            {
                exit = num * 0.0010000;
            }
            //make 2 verification <mm>==<cm>
            else if (firstMertic == "mm" && secoundMetric == "cm")
            {
                exit = num / 10.000;
            }
            else if (firstMertic == "cm" && secoundMetric == "mm")
            {
                exit = num * 10.000;
            }
            //make 2 verification <m>==<cm>
            else if (firstMertic == "m" && secoundMetric == "cm")
            {
                exit = num * 0.010000;
            }
            else if (firstMertic == "cm" && secoundMetric == "m")
            {
                exit = num / 0.010000;
            }
            Console.WriteLine($"{exit:F3}");
        }
    }
}
