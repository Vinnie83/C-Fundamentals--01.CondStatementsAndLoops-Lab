namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int copiedNumber = number;

            int factorialSum = 0;

            while (copiedNumber > 0)
            {
                int digit = copiedNumber % 10;
                copiedNumber /= 10;

                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;

            }

            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}