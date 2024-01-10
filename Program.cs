using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Console.WriteLine("This is a while loop");

            while (index < 5)
            {
                Console.WriteLine(index);
                index++;
            }

            int index1 = 0;
            Console.WriteLine("This is a do-while loop");
            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index1 < 50);


            Console.Read();
        }
    }
}
