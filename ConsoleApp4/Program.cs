using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int s = 0;
            for (int i = 1; i <= n; i++) 
            {
                s =s+k;
                k = k + 2;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
