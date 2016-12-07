using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication___Classes
{
    class CustomFloat
    {
        private int firstPart;
        private float secondPart;

        //const float PI = 3.14f;

        //readonly float numOfNumbers;

        public CustomFloat(float number)
        {
            firstPart = (int)number;
            secondPart = number - firstPart;
        }
        public int FirstPart
        {
            set
            {
                firstPart = value;
            }
        }

        public float SecondPart
        {
            set
            {
                if (Math.Abs(value) < 1f)
                    secondPart = value;
                else
                    secondPart = 0f;
            }
        }
        /*public void Print()
        {
            Console.WriteLine(firstPart + secondPart);
        }*/


        public int ReturnInt()
        {
            return firstPart;
        }
        public float ReturnFloat()
        {
            return secondPart;
        }
    }
}



    /*
    class Employee
    {
        private string name;
        private int id;
        private int salary;

        
        public string Speciality { get; set; } //коротка властивість - змінна створюється автоматично при компіляції

        public string Name //property (властивість, надбудова)
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
            public Employee(string newName, int newId, int newSalary)
        {
            name = newName;
            id = newId;
            salary = newSalary;
        }


        public int ID
        {
            get
            {
                return id;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value - this.salary >= 500)
                    this.salary += 500;
                else if (this.salary - value >= 500)
                    this.salary -= 500;
                else
                    this.salary = value;
            }
        }
        */

    /*
    public int GetSalary() //оскільки поле приватне - ми його не бачимо і цей метод допомагає вивести його в Main
    {
        return salary;
    }

    public void SetSalary(int Salary)  //хочемо збільшити на 2000, але збільшуємо усього на 500
    {
        if (salary - this.salary >= 500)
            this.salary += 500;
        else if (this.salary - salary >= 500)
            this.salary -= 500;
        else
            this.salary = salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Employee Info: {0}, {1}, {2}",name, id, salary);
    }
 */
 
    /*
    class Mouse
    {
        public int numOfKeys;
        public int dpi;
        public string model;

        public Mouse(string mModel = "", int mNumOfKeys = 2, int mDPI = 800)
        {
                model = mModel;
                numOfKeys = mNumOfKeys;
                SetDpi(mDPI);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Mouse Info: {0}, {1}, {2}", model, numOfKeys, dpi);
        }

        public int GetDpi()
        {
            return dpi;
        }

        public void SetDpi(int dpi)
        {
            this.dpi = dpi - (dpi % 400);
        }
    }
    */

    /*
    class Computer
    {
        public string Model;
        public int Price;
        public int Ram;
        public bool IsOn;

        public Computer() : this("") { }

        public Computer(string model) : this(model, 1) { }

        public Computer(string model, int price) : this(model, price, 32) { }

        public Computer(string model, int price, int ram) : this(model, price, ram, false) { }

        public Computer(string model, int price, int ram, bool isOn)
        {
            Model = model;
            Price = price;
            Ram = ram;
            IsOn = isOn;
        }

        public void CompInfo()
        {
            Console.WriteLine("Brand name: {0}, price is {1}$, it has {2} RAM", Model, Price, Ram);
        }

        public void IsOnMethod()
        {
            if (IsOn)
                Console.WriteLine("Your Computer is On");
            else
                Console.WriteLine("Your Computer is Off");
        }
    }*/

