namespace _03.Vacation
{
    internal class Program
    {
        static void Main()
        {

            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();

            decimal price = 0;
            decimal totalPrice = 0;

            switch (groupType)
            {
                case "Students":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = 8.45m;
                            break;
                        case "Saturday":
                            price = 9.80m;
                            break;
                        case "Sunday":
                            price = 10.46m;
                            break;
                    }
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85m;
                    }
                    break;
                case "Business":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = 10.90m;
                            break;

                        case "Saturday":
                            price = 15.60m;
                            break;
                        case "Sunday":
                            price = 16m;
                            break;
                    }
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }
                    totalPrice = price * peopleCount;

                    break;

                case "Regular":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = 15m;
                            break;

                        case "Saturday":
                            price = 20m;
                            break;
                        case "Sunday":
                            price = 22.50m;
                            break;
                    }
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 10 && peopleCount <= 20)

                        totalPrice *= 0.90m;
                    break;
            }
           

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
        
    }
}