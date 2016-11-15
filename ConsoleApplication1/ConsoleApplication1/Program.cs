using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Sum of 4+6=" + (4+6));
            // Console.WriteLine(345 * 45);

            /*
            Console.WriteLine("Enter first number");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int i2 = int.Parse(Console.ReadLine());

            int sum = i1 + i2;
            Console.WriteLine("Sum is " + sum);
            int rizn = i1 - i2;
            Console.WriteLine("Riznytsia = " + rizn);
            int Dob = i1 * i2;
            Console.WriteLine("Dobutok = " + Dob);
            float chastka = i1 / (float)i2;             // (float) (i1 / i2);
            Console.WriteLine("Chastka = " + chastka);
            */


            /* //Console.WriteLine("Sum of " + i1 + " and " + i2 + " = " + (i1 + i2));

             string result;  //оголошення
             int sum = i1 + i2; //ініціалізація
             Console.WriteLine("Sum of {0} and {1} = {2}", i1, i2, sum);*/

            /*
            int max = int.MaxValue;
            max = max + 100; // = max += 100  += -= /= *=
            max++; // = max = max + 1
            Console.WriteLine(max);
            */

            Console.WriteLine("Enter number from 0 to 7");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int b3 = temp % 2;
            temp = temp / 2;
            int b2 = temp % 2;
            temp /= 2;
            int b1 = temp % 2;
            Console.WriteLine("{0} = {1}{2}{3}", num, b1, b2, b3); 
                
        }
    }
}
