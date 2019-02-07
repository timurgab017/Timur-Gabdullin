using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = Console.ReadLine();
            int star1 = int.Parse(star);//converting string to int 

            for (int i = 0; i <= star1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.Write("\n");
            }
            Console.ReadKey();//pausing the execution
        }
    }
}
