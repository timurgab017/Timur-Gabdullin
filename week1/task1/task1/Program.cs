using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes //
{
    class Program //name of the class
    {

        public static bool Isprime(int n) //the function checks whether the given number is prime or not by counting how many times the number is divided for how many numbers 
        {
            int cnt = 0;
             for ( int i=1; i<=n; i++)
            {
                if (n % i==0)
                    cnt++;
            }
            if (cnt == 2)
                return true;
            else
                return false;
        }
               
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            int aa = int.Parse(a);// converting string to int

            var primes = new List<int>();// adding primes to the list 

            String b = Console.ReadLine();
            String[] nums = b.Split(' ');// splits after " "  

            for (int i = 0; i< aa; i++)
            {
                
                int numm = int.Parse(nums[i]);
                if (Isprime(numm))
                {
                     primes.Add(numm);
                }
            }

           
            Console.WriteLine(primes.Count);
            for (int i=0; i<primes.Count; i++)
            {
                Console.Write(primes[i] + " ");
            }
            Console.ReadKey();//pausing after execution of the program
        }
    }
}
