using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Control_Flow
{
    internal class Loops01
    {
        public static void run()
        {
            while (true)
            {
                Console.Write("Type your name : ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("Name : "+ input);
            }
        }
    }
}
