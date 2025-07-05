using DSA_Practice.Basics;

namespace DSA_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Give a number input: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Patterns.Pattern22(n);
        }
    }
}
