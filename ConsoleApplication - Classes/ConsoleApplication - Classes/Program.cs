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
            Computer computer = new Computer("Dell", 320, 2048, true);
            computer.CompInfo();
            Console.ReadLine();
            computer.IsOnMethod();
                        
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
