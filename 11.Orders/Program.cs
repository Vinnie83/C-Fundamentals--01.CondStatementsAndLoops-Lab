namespace _11.Orders
{
    internal class Program
    {
        static void Main()
        {
            int countOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            while (countOrders != 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                double daysInMonth = double.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());

                double price = daysInMonth * capsulesCount * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalPrice += price;

                countOrders--;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}