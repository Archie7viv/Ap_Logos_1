using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2 числа з клавіатури і вибираємо для них дію за числом з клавіатури
            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Vvedit chuslo vid 1 do 4: \n 1:+ \n 2:- \n 3:* \n 4:/");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine(n1 + n2);
                    break;
                case 2:
                    Console.WriteLine(n1 - n2);
                    break;
                case 3:
                    Console.WriteLine(n1 * n2);
                    break;
                case 4:
                    Console.WriteLine(n1 / n2);
                    break;
            }
            */

            // ввести рік з клавіатури і визначити чи він високосний
            /*
            Console.WriteLine("Vvedit rik");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 400 !=0)
            {
                Console.WriteLine("Rik visokosniy");
            }
            else {
                Console.WriteLine("Rik ne visokosniy");
            }
            */

            // ввести з клавіатури 3 сторони трикутника і порахувати чи такий трикутник може існувати

            /*
            Console.WriteLine("Vvedit 3 storonu trukytnuka");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            if (x1 + x2 > x3 && x2 + x3 > x1 && x1 + x3 > x2)
            {
                Console.WriteLine("existed");
            }
            else {
                Console.WriteLine("Not existed");
            }
            */
            /*
            int num;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }

            Console.WriteLine(sum);
            */
            /*
            int num = 1;
            int sum = 0;
            while (num != 0) {
                num = int.Parse(Console.ReadLine());
                sum += num;
                Console.WriteLine("sum = " + sum);
            }
            */

            // вводимо 5 чисел і рахуємо їх середнє арифметичне
            /*
            Console.WriteLine("Vvedit 5 chusel");
            int c;
            int sum = 0;
            double a;
            for (int i = 0; i < 5; i++) {
                c = int.Parse(Console.ReadLine());
                sum = sum + c;
            }
            Console.WriteLine(a = sum / 5);
            */

            // середнє арифметичне для багатьох чисел поки не введеться 0, виводимо середнє і кількість циклів
            /*
            Console.WriteLine("Enter any numbers");
            int c;
            int sum = 0;
            double a;
            int i=0;
            do{
                c = int.Parse(Console.ReadLine());
                sum = sum + c;
                i++;
            } while (c != 0);
            a = sum / i;
            Console.WriteLine("Average is " + a);
            Console.WriteLine("Number of loops is " + i);
            */


            // ??????????????????????
            /*
            int num, i, j, k;
            Console.Write("enter the level:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
             }
             */


            // кількість парних чисел у натуральному числі
            /*
            int n = 123456648;
            int count = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0) count++;
                n /= 10;
            }
            Console.WriteLine(count);
            */


            //Найти среднее арифметическое всех целых чисел от а до b (значения а и b вводятся с клавиатуры; ) 
            /*
            double a, b;
            double sum = 0;
            double result = 0;
            Console.Write("Введите a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = double.Parse(Console.ReadLine());

            for (double i = a; i <= b; i++)

            {
                sum += i;
                result += i / ((b - a) + 1);
            }
            
            Console.WriteLine("Cумма чисел от {0} до {1} ровна {2}, среднее арифметическое равно {3}: ", a, b, sum, result);
            */

            //3.) Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробeг на 10% от пробега предыдущего дня. Определить в какой день суммарный пробег за все дни превысит 100 км. 
            
            /*
            double sum = 10;
            int day = 1;
            double distPerDay = 10;

            while (sum < 100)
            {
                double inc = distPerDay / 10.0;
                distPerDay = distPerDay + inc;
                sum += distPerDay;
                day++;
            }
            Console.WriteLine(day);
            */

            /* 3b)
            int day = 1;
            double dayDist = 10;

            for (double sum = 10; sum < 100; day++)
            {
                double inc = dayDist / 10.0;
                dayDist += inc;
                sum += dayDist;
            }
            //Console.WriteLine("На " + day + "відстань перевищить 100км");
            Console.WriteLine(day);
            */
























        }
    }
}
