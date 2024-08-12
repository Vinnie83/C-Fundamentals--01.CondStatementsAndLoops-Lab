namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main()
        {
            
            decimal balance = 0;

            string input = Console.ReadLine();

            while (input != "Start")
            {
                decimal coin = decimal.Parse(input);

                if (coin == 0.1m )
                {
                    balance += coin;
                }
                else if (coin == 0.2m)
                {
                    balance += coin;
                }
                else if (coin == 0.5m)
                {
                    balance += coin;
                }
                else if (coin == 1m)
                {
                    balance += coin;
                }
                else if (coin == 2m)
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }


            string product = Console.ReadLine();    

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (balance >= 2)
                        {
                            balance -= 2m;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (balance >= 0.7m)
                        {
                            balance -= 0.7m;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (balance >= 1.5m)
                        {
                            balance -= 1.5m;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (balance >= 0.8m)
                        {
                            balance -= 0.8m;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (balance >= 1)
                        {
                            balance -= 1m;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();


            }

            Console.WriteLine($"Change: {balance:f2}");

        }              
        
    }
}