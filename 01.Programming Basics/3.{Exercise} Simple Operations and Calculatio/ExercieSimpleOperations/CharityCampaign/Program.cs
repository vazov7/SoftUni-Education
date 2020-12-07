using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectionersNumber = int.Parse(Console.ReadLine());
            int cakesNum = int.Parse(Console.ReadLine());
            int wafflesNum = int.Parse(Console.ReadLine());
            int pancakesNum = int.Parse(Console.ReadLine());
            double cakes = cakesNum * 45;            
            double waffles = wafflesNum * 5.80;            
            double pancakes = pancakesNum * 3.20;            
            double totalPerDay = (cakes + waffles + pancakes) * confectionersNumber;            
            double entireAmount = totalPerDay * days;            
            double totalAmountAfterCoverage = entireAmount - (entireAmount / 8);            
            Console.WriteLine($"{totalAmountAfterCoverage:F2}");
        }
    }
}
