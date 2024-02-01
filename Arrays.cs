using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewArrays
{
    public class CheckArray
    {
        public void CheckTheArray()
        {
            int[] favoriteNumber = {1994, 14, 4 };
            for (int i = 0; i < favoriteNumber.Length; i++)
            {
                Console.WriteLine(favoriteNumber[i]);
               
            }
            Console.WriteLine("-------------");

            favoriteNumber[1] = 12;
            foreach (int number in favoriteNumber)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-------------");

            Array.Sort(favoriteNumber);
            for (int i = 0; i < favoriteNumber.Length; i++)
            {
                Console.WriteLine(favoriteNumber[i]);
                
            }

            Console.WriteLine("-------------");
            for (int i = 0; i < favoriteNumber.Length; i++)
            {
                favoriteNumber[i] += 1;
                Console.WriteLine(favoriteNumber[i]);

            }
            Console.WriteLine("-------------");

            Array.Resize(ref favoriteNumber, favoriteNumber.Length +1);
            favoriteNumber[3] = 28;
            foreach (int number in favoriteNumber)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------");

            /*
            int[] newNumber = new int[favoriteNumber.Length + 1];
            for (int i = 0; i < favoriteNumber.Length; i++)
            {
                newNumber[i] = favoriteNumber[i];
            }
            
            newNumber[3] = 28;
            favoriteNumber = newNumber;
           foreach (int number in favoriteNumber)
            {
                Console.WriteLine(number);
            }
            */
            Console.WriteLine("-------------");

            Array.Reverse(favoriteNumber);
            for (int i = 0; i < favoriteNumber.Length; i++)
            {
                Console.WriteLine(favoriteNumber[i]);

            }

            
        }
       
    }
}
