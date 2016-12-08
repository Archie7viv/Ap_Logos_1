using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___HomeWork
{
    class House // #1
    {
        public int numOfRooms;
        public int price;
        public float area;

        public House(int newNumOfRooms, int newPrice)
        {
            area = 1;
            numOfRooms = newNumOfRooms;
            price = newPrice;
        }

        public House(int newNumOfRooms, int newPrice, float newArea)
        {
            area = newArea;
            numOfRooms = newNumOfRooms;
            price = newPrice;
        }

        public void GetInfo()
        {
            Console.WriteLine("Your info: number of rooms is {0}, price = {1}$ and area is {2}m2", numOfRooms, price, area);
        }

        public void Price()
        {
            float pr = (area / price);
            Console.WriteLine("Price for 1 meter is {0} $", pr);
        }
    }


    class Product // #2
    {
        public int price;
        public string category;
        public string name;


        public Product(int newPrice, string newCategory = "common", string newName = "-enter name-")
        {
            price = newPrice;
            category = newCategory;
            name = newName;
        }
        public void GetInfo()
        {
            Console.WriteLine("\nYou've bought the following product: {0} from {1} category for {2}$", name, category, price);
        }

        public static void SearchChild(Product[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].category == "child")
                    array[i].GetInfo();
            }
        }

    }

    class Person // #3
    {
        public string name;
        public string surname;
        public float height;
        public int age;
        public string male;
        public bool isAlive;

        public Person (): this("") { }

        public Person (string newName): this(newName, "") { }

        public Person (string newName, string newSurname): this(newName, newSurname, 0) { }

        public Person (string newName, string newSurname, float newHeight): this(newName, newSurname, newHeight, 0) { }

        public Person (string newName, string newSurname, float newHeight, int newAge): this (newName, newSurname, newHeight, newAge, "") { }

        public Person (string newName, string newSurname, float newHeight, int newAge, string newMale): this (newName, newSurname, newHeight, newAge, newMale, false) { }

        public Person (string newName, string newSurname, float newHeight, int newAge, string newMale, bool newIsAlive)
        {
            name = newName;
            surname = newSurname;
            height = newHeight;
            age = newAge;
            male = newMale;
            isAlive = newIsAlive;
        }
        public void IsAlive()
        {
            if (isAlive)
                Console.WriteLine("\nYour person is Alive");
            else
            Console.WriteLine("\nYour person is not alive :(");
        }
        public void GetInfo()
        {
            Console.WriteLine("Here is the inormation about your person:his full name is {0} {1}, he is {2} years old and {3}m tall, his male is {4}", name, surname, age, height, male);
        }


    }

    // #4
    
    class Student
    {
        public string pib;
        public float avgScore;
        public string address;
        private int [] array2;

        public Student(string newPib, string newAddress, int [] newArray2)
        {
            pib = newPib;
            address = newAddress;
        }
        public static float AvgScore(int []array2)
        {
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum += array2[i];
            }
            return sum;
        }
    }
    
}
