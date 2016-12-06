using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int k = int.Parse(Console.ReadLine());
            string result = k > 10 ? "k is greater than 10" : "k is " + k;  // тернарний оператор: якщо true - то 1й варіантЮ якщо false - другий
            Console.WriteLine(result);
            */

            // ТРИКУТНИК
            /*
           int numberoflines = 4;
           for (int i = 0; i < numberoflines; i++)
           {
               for (int spaces = 0; spaces < numberoflines -i - 1; spaces ++)
               {
               Console.Write(" ");
               }

               for (int arrows = 0; arrows < i * 2 + 1; arrows++) 
               {
                   Console.Write("^");
               }
               Console.WriteLine();
           }
           */


            //МАСИВ 1
            /*
            int [] students = new int [6];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student #{0} has {1} points", i, students[i]);
            }
           */

            // вивести всі додатні числа з масиву та їх кількість
            /*
            int[] newArr = { 3, -3, -5, 5, 6, 7 };
            int amount = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] > 0)
                {
                    amount += 1;
                    Console.WriteLine(newArr[i]);
                    
                }
            }
            Console.WriteLine("Amount of positive values is " + amount);
            */

            // ввести 10 чисел в масив та вивести найбільше значення з них

            /*
            int[] myArr = new int[10];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            int max = int.MinValue;  // або int max = myArr[0] - починаємо з нульового елементу
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] > max)
                    max = myArr[i];
            }
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write(" " + myArr[i]);
            }
            Console.WriteLine("\n Max value is " + max);
            */

            //є масив {3, 5, 6, 0, 1, 2, 1, 0, 6, 4} - вивести всі числа між нулями - ППЦ!

            /*
            int [] nums = { 5, 7, 3, 9, 0, 5, 1, 2, 0, 6 };
            int firstZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    firstZeroIndex = i;
                    break;
                }
            }
            for (int i = firstZeroIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    Console.WriteLine(nums[i]);
                else
                    break;                
            }
            */


            //вводимо числа поки не введеться 0
            /*
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("Vvedit chuslo");
                num = int.Parse(Console.ReadLine());
            }
            */
            /*
            int num = 1;
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
            }
            */
            /*
            int[] nums = { -3, 2, 4, 3, 2, 1 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) //виводимо перший елемент, який більше 0
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
            }
            int sum = 0; ;
            foreach (int elem in nums)
            {
                sum += elem; //рахуємо суму чисел в масиві
                Console.Write(elem + " ");
            }
            Console.WriteLine("sum = " + sum);
            */



            //!!!багатовимірний масив




            // сума елементів двовимірного масиву

            /*
            int[,] ar1 = new int[3, 4];
            int sum = 0;
            for (int i = 0; i < 3; i++)     // заповнимо масив
            {
                for (int j = 0; j < 4; j++)
                {
                    ar1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(ar1[i, j] + "\t");  //виводимо масив
                    sum += ar1[i, j];
                }
                Console.WriteLine(); // виводимо масив
            }
            Console.WriteLine("Sum is {0}", sum); //виводимо суму
             */

            // східчатий масив
            /*
            int[][] ar2 = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                ar2[i] = new int[i+1];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < ar2[i].Length; j++)
                {
                    ar2[i][j] = int.Parse(Console.ReadLine());
                }
            }
            int max = int.MinValue; // визначаємо найбільше значення в масиві
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < ar2[i].Length; j++)
                {
                    Console.Write(ar2[i][j] + "\t"); //виводимо весь масив на екран
                    if (ar2[i][j] > max)
                        max = ar2[i][j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Max is {0}", max);
            */


            // порахувати суму всіх елементів, які знаходяться в непарних рядках
            /*
            int[,] ar4 = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ar4[i,j] = int.Parse(Console.ReadLine());
                }
  
            }
            for (int i = 0; i < 4; i++) // виводимо масив
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ar4[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0; // рахуємо суму в непарних рядках

            for (int row = 0; row < 4; row++)
            {
                if (row % 2 != 0)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        sum += ar4[row, column];
                    }
                }
               
            }
            Console.WriteLine(sum);
            */


            // Arrays - HomeTask #1 (масив по діагоналі, друга діагональ, сума чисел під головною діагоналлю)
            /*
            Console.WriteLine("Enter matrix size");
            int size = int.Parse(Console.ReadLine());
            int[,] arr = new int[size, size];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            for (int i = 0; i < size; i++)  //виводимо масив
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < size; i++)  // основна діагональ
            {
                sum1 += arr[i, i];
            }

            int newSize = 1;
            for (int i = 0; i < size - 1; i++, newSize++) // друга діагональ 
            {
                for (int j = newSize; j <= newSize; j++)
                {
                    sum2 += arr[i, j];
                }
            }
            Console.WriteLine("Sum of main diagonal is {0} \n Sum of 2nd diagonal is {1}", sum1, sum2);

            int sum3 = 0;
            for (int i = 0; i < size; i++) //сума елементів під діагоналлю
            {
                for (int j = 0; j < size; j++)
                {
                    for (int u = 0; u < i; u++)
                    {
                        sum3 += arr[i,u]; //??????????????????????????
                    }
                }
            }
            Console.WriteLine("Sum3 is " + sum3);
            Console.ReadLine();
            */

            //Arrays - Hometask 2 - слово з клавіантури та перевірити чи воно є паліндромом - ввести булівську змінну!!
            
            Console.WriteLine("Enter any word");
            string word = Console.ReadLine();
            bool isPalindrome = true;
            char[] charArray = word.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
            int reverse = charArray.Length - 1;
            for (int i = 0; i < reverse; i++, reverse--)
            {
                if (charArray[i] != charArray[reverse])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine(word + " is a palindrom");
            }
            else
            {
                Console.WriteLine(word + " is not a palindrom!!!");
            }

            // контрольна 12/01/16
            /*
            int[] arr = new int [10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] == 0)
                {
                    break;
                }
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            for (int j = 0; j < sum; j += 10)
                {
                    Console.Write(" " + j);
                }
            Console.WriteLine("\n The sum is {0}", sum);
            }
            */
        }
    }
}
