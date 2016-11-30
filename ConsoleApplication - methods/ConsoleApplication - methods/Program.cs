using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication___methods
{
    class Program
    {

        static void Main(string[] args)
        {
            // до 3-ї задачі
            int[] arr = { 1, 2, 3 };
            int sum1 = sumOfElem(arr);  //arr - те що передаємо в метод
            Console.WriteLine("Sum of elements is " + sum1);

            //до 4-ї задачі
            int[] Arr = CreateArray(10);
            foreach (int i in Arr)
            {
                Console.WriteLine(i);
            }

            //до 5-ї задачі
            
           Figure(3, 5, 7); //це масив, ми це знаємо з методу


            // до 6-їзадачі

            int[] arr3 = { 1, 2, 3 };
            int max;
            MaxMinArray(arr3, out max);
            Console.WriteLine(max);
        }
        // 1. Створити метод, який повертає абсолютне значення числа

        /*
        static void CustomAbs(int num)
        {
            if (num < 0)
                Console.WriteLine(-num);
            else
                Console.WriteLine(num);
        }
        */

        // 2. ------------

        //3. Метод, в який ми передаємо масив і він повертає нам суму елементів

        static int sumOfElem (int[] arr)
        {

            int sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum1 += arr[i]; 
            }
            return sum1;
        }


        // 4. метод, який приймає число та повертає масив з к-стю елементів = цьому числу та значення = номеру елемента
        static int [] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = i;
            return arr;
        }

        // 5. метод, який приймає n чисел і виводить щось відповідно до тієї к-сті чисел

        static void Figure(params int[] arr2)
        {
            switch (arr2.Length)
            {
                case 1:
                    Console.WriteLine("line with length {0} ", arr2[0]);
                    break;
                case 2:
                    Console.WriteLine("line with length {0} ", arr2[1]);
                    break;
                case 3:
                    Console.WriteLine("Triangle, S1 = {0}, S2 = {1}, S3 = {2} ", arr2[0], arr2[1], arr2[2]);
                    break;
            }
        }

        // 6. - метод, який приймає масив і виводить 2 параметри - найбільше і найменше значення масиву


        static void MaxMinArray (int[] arr3, out int max)
        {
            max = int.MinValue;
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] > max)
                    max = arr3[i];
            }
            Console.WriteLine("Max value is " + max);
        }
        


    }
}
