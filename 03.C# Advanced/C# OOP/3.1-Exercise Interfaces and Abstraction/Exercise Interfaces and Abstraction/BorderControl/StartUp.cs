using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> inputList = input.Split().ToList();

                if (inputList.Count == 2)
                {
                    persons.Add(new Robot(inputList[0], inputList[1]));
                }
                else if (inputList.Count == 3)
                {
                    persons.Add(new Citizen(inputList[0], int.Parse(inputList[1]), inputList[2]));
                }
            }

            int fakeId = int.Parse(Console.ReadLine());

            foreach (var item in persons)
            {
                int idNum = int.Parse(item.Id.Substring(item.Id.Length - 3, 3));
                if (idNum == fakeId)
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
