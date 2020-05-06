using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscomment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("x를 입력하세용: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("y를 입력하세용: ");
            y = int.Parse(Console.ReadLine());

            if (x > 4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x * y);
                }
            }

            else
            {
                Console.WriteLine();
            }





        }
    }
}
