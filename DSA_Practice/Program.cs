using DSA_Practice.Basics;

namespace DSA_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("How many test case you have? ");
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Console.Write("Give a number input: ");
                int n = Convert.ToInt32(Console.ReadLine());

                BasicMaths.IsPrime(n);
            }
        }
    }
}
