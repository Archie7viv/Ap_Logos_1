using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Car myCar = new Car("Suzuki", "red", 500400, 200, 100, true);  //new Car() - виклик конструктора
            myCar.PrintInfo();  */
            /*
            Room room = new Room("Alex", 2, "Lux");
            room.ShowOrder();
            Console.ReadLine();
            */

            //HomeTask1 - Constructors

            /*Computer computer = new Computer("Dell", 320, 2048, true);
            computer.CompInfo();
            Console.ReadLine();
            computer.IsOnMethod();
            */



            //Encapsulation
            /*
            Mouse m1 = new Mouse("Logitech", 5, 1999);

            m1.model = "ASUS";
            Console.WriteLine("New mouse: {0} {1} {2}", m1.model, m1.numOfKeys, m1.dpi);

            m1.PrintInfo();
            m1.SetDpi(1999); // виводиться найближче значення яке ділиться на 400
            Console.WriteLine(m1.GetDpi());
            */

            //Task - Employee
            /*
            Employee Emp = new Employee("John", 321, 2000);
            //Console.WriteLine("Початкова зарплата = {0}", Emp.GetSalary()); // вертаємо початкову зарплату
            //Emp.SetSalary(10); //хочемо збільшити на 2000, але збільшуємо усього на 500
            Emp.Salary = 3000;
            Console.WriteLine(Emp.Salary);
            Emp.Salary = 4000;
            Console.WriteLine(Emp.Salary);
            Emp.Salary = 5000;
            Console.WriteLine(Emp.Salary);
            Emp.PrintInfo();
            Console.WriteLine(Emp.Name);
            Emp.Name = "Gregor";
            Console.WriteLine(Emp.ID);

            //Console.WriteLine(Emp.GetSalary());  //оскільки поле Salary приватне - ми його не бачимо і цей метод допомагає вивести його в Main
            */

            string value = Console.ReadLine();
            float x = (float)Convert.ToDouble(value);
            CustomFloat Num = new CustomFloat(x);

            Console.WriteLine(Num.ReturnInt());
            Console.WriteLine(Num.ReturnFloat());
            Console.ReadLine();

            /*
            Num.FirstPart = 5;
            Num.SecondPart = 9.4f;
            Num.Print();
            */

        }
    }
        
    

    class Room
    {
        string Name;
        int Appartment;
        string Luxury;

        public Room() : this("") { }

        public Room(string name) : this(name, 1) { }

        public Room(string name, int appartment) : this(name, appartment, "standard") { }
        
        public Room(string name, int appartment, string luxury)  //передаємо параметри в конструктор
        {
            Name = name;
            Appartment = appartment;
            Luxury = luxury;
        }

        public void ShowOrder()
        {
            Console.WriteLine("{0} booked {2}-bed room with class {1}",Name, Luxury, Appartment );
        }
    }
}
