using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите n= ");
                int a = Convert.ToInt32(Console.ReadLine());
              
                Console.WriteLine(fakt(a));
                Console.ReadKey();
            }
        }
        
        
        static Int64 fakt(int n)
        {
            Int64 f;
            if (n < 1)
                f = 1;
            else
                f = fakt(n - 1) * n;
            return f;
        }
    }
}
