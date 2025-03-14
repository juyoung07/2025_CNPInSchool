using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            int a, b;   // 나중에 입력받을 예정

            int result;

            a = 100;
            b = 500;

            result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);

            result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);

            result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);

            result = a / b;
            Console.WriteLine(a + " / " + b + " = " + result);
        }
    }
}
