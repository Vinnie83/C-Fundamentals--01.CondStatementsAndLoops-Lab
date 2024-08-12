using System.Security.Cryptography;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double singlePriceLs = double.Parse(Console.ReadLine());
            double singlePriceRobes = double.Parse(Console.ReadLine());
            double singlePriceBelts = double.Parse(Console.ReadLine());

            double ls = Math.Ceiling(students + (students * 0.10));

            double belts = 0;
            if (students > 6)
            {
                belts = students - (students / 6);

            }
            else
            {
                belts += students;
            }

            double totalPriceLs = singlePriceLs * ls;
            double totalPriceRobes = singlePriceRobes * students;
            double totalPriceBelts = singlePriceBelts * belts;

            double totalCost = totalPriceLs + totalPriceRobes + totalPriceBelts;

            if (totalCost <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                double diff = totalCost - budget;
                Console.WriteLine($"John will need {diff:f2}lv more."); 
            }

        }
    }
}