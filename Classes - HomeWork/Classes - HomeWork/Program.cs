using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #1: Створити клас House з полями numOfRooms, price, area (float).
                    Додати метод для виводу інформації та метод, який виводить
                    яка ціна за один квадратний метр (на основі вартості і площі)
                    Використовувати перевантаження конструкторів.*/
            House room = new House(2, 55, 32.1f);
            room.GetInfo();
            room.Price();


            /* #2  "Створити клас Product з полями price, category (string),
                    name (string). Використовувати конструктор
                    з необов'язковими параметрами. Додати метод виводу
                    інформації.
                    В методі Main створити масив з 6 екземплярів цього класу.
                    Вивести на екран усі дані об'єктів цього масиву, які мають
                    категорію ""Для дітей""."*/
            Product pr1 = new Product(10, "child");
            Product pr2 = new Product(25, "child", "Barbi");
            Product pr3 = new Product(5, "literature", "Shekspire");
            Product pr4 = new Product(3, "child", "Alphabet-book");
            Product pr5 = new Product(100, "pet", "dog");
            Product pr6 = new Product(15, "child", "Lego");

            Product[] array = new Product[6];
            array[0] = pr1;
            array[1] = pr2;
            array[2] = pr3;
            array[3] = pr4;
            array[4] = pr5;
            array[5] = pr6;

            pr1.GetInfo();
            Console.Read();

            Product.SearchChild(array);



            /* #3 "Створити клас Person з полями name, surname, 
                    height, age, male, isAlive. Конструктори робити, 
                    використовуючи ланцюжок конструкторів та повний
                    конструктор."*/
            Person pers = new Person("Jack", "White", 1.80f, 42, "male", false);
            pers.IsAlive();
            pers.GetInfo();

            /* #4 "Створити клас Student, який може зберігати оцінки школяра
                (у масиві), ПІБ, середній бал і домашню адресу. Заборонити зміну 
                оцінок крім встановлення в конструкторі. Середній бал не можна
                вручну ніде встановити крім метода CalcAvg
                ВИвести на екран інформацію про студента (всі поля мають бути
                приватними; можна використовувати властивості)"*/

            Student stud1 = new Student("Nane 1", "Address1");
            int[] array2 = new int[3];
            Console.WriteLine("Enter 3 scores for {0}:", stud1);
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
