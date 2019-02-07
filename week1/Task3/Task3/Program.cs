using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nn = Console.ReadLine();
            int n = int.Parse(nn);

            String s = Console.ReadLine();
            String[] nums = s.Split(' ');


            Triangle t = new Triangle();
            t.Draw(nums);

           
        }
    }

    public class Triangle
    {

        public void Draw(String[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                Console.Write(array[i] + " ");
            }
        }


    }
}
