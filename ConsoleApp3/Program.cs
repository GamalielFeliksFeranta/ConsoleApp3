using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        private const int a = 1;
        static void Main(string[] args)
        {
            Console.Write("Masukan Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int temp = 0;
            for (int i = 1; i < input + a;i++ )
            {
                temp = input % i;
                if (temp == 0)
                {
                   count++;
                }
            }
            if (count > 2)
            {
                Console.Write("Bukan prima");

            }
            else
            {
                Console.Write("Bilangan prima");
            }
            
        }
    }
}
