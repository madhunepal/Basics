using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter 2 integers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
