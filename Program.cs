using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 費式數列
{
    class Program
    {
        static void Main(string[] args)
        {

            int previous = 1;
            int thelatter = 1;
            int answer = 1;
            Console.Write("1 + ");
            while (true)
            {
                if(answer >= 1836311903)
                {
                    break;
                }
                else
                {
                    answer = thelatter + previous;
                    Console.Write($"{thelatter}");
                    if(answer < 1836311903)
                    {
                        Console.Write(" + ");
                    }
                    previous = thelatter;
                    thelatter = answer;
                }
            }
            Console.Write($" = {answer}");
            Console.ReadLine();
        }
    }
}
