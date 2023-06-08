

using System.Security.Cryptography;

namespace higherlower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,101);
            

            while (true)
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

            }
        }
    }
}