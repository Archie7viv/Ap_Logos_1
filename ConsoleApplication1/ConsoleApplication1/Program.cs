﻿using System;
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

            /*
            int i2 = 2;
            int i1 = 1;

            Console.WriteLine("Sum of " + i1 + " and " + i2 + " = " + (i1 + i2));
             
            
             string result;  //оголошення
             int sum = i1 + i2; //ініціалізація
             Console.WriteLine("Sum of {1} and {0} = {2}", i2, i1, sum);
             */

            /* знаходження максимального значення діапазону типу змінної
            int max = int.MaxValue;
            max = max + 100; // = max += 100  += -= /= *=
            max++; // = max = max + 1
            Console.WriteLine(max);
            */

            /* перевод числа в 0101
             Console.WriteLine("Enter number from 0 to 7");
             int num = int.Parse(Console.ReadLine());
             int temp = num;
             int b3 = temp % 2;
             temp = temp / 2;
             int b2 = temp % 2;
             temp /= 2;
             int b1 = temp % 2;
             Console.WriteLine("{0} = {1}{2}{3}", num, b1, b2, b3); 
            */

            //  HomeWork 1 - середній бал за 3 предмети, з клавіатури

            Console.WriteLine("Vvedit bal za 1 predmet");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedit bal za 2 predmet");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedit bal za 3 predmet");
            int x3 = int.Parse(Console.ReadLine());
            /*int sum = (x1 + x2 + x3);
            float avg = ((float)sum / 3);
            Console.WriteLine("Your average is " + avg);*/


            int[] points = new int[3] {x1, x2, x3};  // оголошуємо та ініціалізуємо масив
            double avgScore = GetAverageScoreOfThreePoints(points);  // виклик методу з масивом на вході, середній бал на виході

            Console.WriteLine("Your average is {0}", avgScore);


            // HomeWork 2 - довжина кола, радіус з клавіатури
             
            Console.WriteLine("Vvedit radius kola");
            int r = int.Parse(Console.ReadLine());

            double Dovjuna = GetCircleLenght(r);

            Console.WriteLine("Dovjuna kola: {0}", Dovjuna);


            //Homework 3 - Taxi
/*
            Console.WriteLine("Vvedit vidstan'");
            int vidstan = int.Parse(Console.ReadLine());
            int vukluk = 30;
            int[] taruf = new int[3] { 5, 4, 3 };
            Console.WriteLine("press 1 if day and 0.5 if night");
            double x = int.Parse(Console.ReadLine());
            double cina;

            if (vidstan <= 10)
                {
                    cina = ((vidstan * taruf[0]) + vukluk);
                    Console.WriteLine("Cina poizdku = " + cina);    
                }
            else if (vidstan > 10 & vidstan <=20)
                {
                    cina = ((vidstan * taruf[1]) + vukluk);
                    Console.WriteLine("Cina poizdku = " + cina);
                }
            else 
                {
                    cina = ((vidstan * taruf[2]) + vukluk);
                    Console.WriteLine("Cina poizdku = " + cina);
                }

    */




        }

        static double GetAverageScoreOfThreePoints(int[] scores)
        {
            int sum = scores[0] + scores[1] + scores[2];
            double avg = (sum / 3);

            return avg;
        }

        static double GetCircleLenght(double r)
        {
            double p = 3.14F;
            double d = (2 * p * (r * r));

            return d;
        }
    }
}
