using System;
using System.Text;

namespace lab2_lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Moi ban nhap ma sin");
            int n = int.Parse(Console.ReadLine());
            int sun = 0;
            while (n != 0)
            {
                sun = sun + n % 10;
                n = n / 10;
            }

            int total = sun % 10;
            if (total == 0)
            {
                Console.WriteLine("This is a valid SIN.");
            }
            else
            {
                Console.WriteLine("This is not a valid SIN.");
            }
        }
    }
}