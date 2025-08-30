using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = new int[5];
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The numbers you entered are:");

            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");

        }
    }
}

