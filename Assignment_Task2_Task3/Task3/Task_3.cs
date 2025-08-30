using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task1_Task_2
{
    public class Task_3
    {

        static void Main(String[] args)
        {
            int[] arr = new int[3];
            Console.WriteLine("Enter 3 numbers:");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The numbers you entered are:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");


            int largst = arr[0];
            if (arr[1] > largst)
            {
                largst = arr[1];
            }
            if (arr[2] > largst)
            {
                largst = arr[2];
            }
            Console.WriteLine("The largest number is: " + largst);


            int smallestindex = 0;
            if (arr[1] < arr[smallestindex])
            {
                smallestindex = 1;
            }
            if (arr[2] < arr[smallestindex])
            {
                smallestindex = 2;

            }

            switch(smallestindex)
            {
                case 0:
                    Console.WriteLine("The smallest number is: " + arr[0]);
                    break;
                case 1:
                    Console.WriteLine("The smallest number is: " + arr[1]);
                    break;
                case 2:
                    Console.WriteLine("The smallest number is: " + arr[2]);
                    break;
            }
        }
    }
}