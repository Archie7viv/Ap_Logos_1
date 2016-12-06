using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication___Classes
{
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





    }
}
