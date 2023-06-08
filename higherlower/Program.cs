

using System.Security.Cryptography;

namespace higherlower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,101);
            int max = 5;
            int nooftries = 0;
            

            while (nooftries < 5)
            {
                Console.Write("input a number: ");
                int user_input = Convert.ToInt16(Console.ReadLine());
                if (user_input == num)
                {
                    Console.WriteLine("you win");
                    break;
                }
                else if (user_input > num)
                {
                    Console.WriteLine("lower");
                }
                else if (user_input < num)
                {
                    Console.WriteLine("higher");
                }
                nooftries++;
                Console.WriteLine("you have {0} tries left", (max - nooftries));
                    if ((max - nooftries) == 0) {
                    Console.WriteLine("you lose");
                    break;
                }

            }
        }
    }
}