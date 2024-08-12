namespace _05.Login
{
    internal class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string password = new string(stringArray);

            int attempts = 4;

            while (attempts > 0)
            {
                attempts--;
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in." );
                    break;
                }
                else 
                {
                    if (attempts == 0)
                    {
                        Console.WriteLine($"User {username} blocked!"); 
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }

        }
    }
}