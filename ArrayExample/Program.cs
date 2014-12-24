using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = {2,4,3,5,6};
        
            

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //    //Console.WriteLine(numbers[i]);   
            //}
            //Console.WriteLine(sum);


            string[] countries = {"Bangladesh","Australia"};
            int[] numbers = {1,2,3,4,5};
            //for (int i = 0; i < countries.Length; i++)
            //{
            //    Console.WriteLine(countries[i]);
            //}


            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            foreach (int number in numbers)
            {
                if(number%2==0)
                Console.WriteLine(number);
            }

            Console.ReadKey();

        }
    }
}
