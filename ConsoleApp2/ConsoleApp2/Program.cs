using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
       // delegate int Calculate(int a, int b);
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
           // Calculate calc = (a, b) => a + b;
           // Console.WriteLine($"{3}+{4} : {calc(3, 4)}");

            Concatenate concat = 
                (arr) =>
                {
                string result = "";
                foreach (string s in arr)
                    result += s;

                return result;
            };
            
            Console.WriteLine(concat(args));
        }
    }
}
