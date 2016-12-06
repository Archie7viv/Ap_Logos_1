using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication___Classes
{
    class Car
    {
        public string color;
        public string model;
        public int price;
        public int maxSpeed;
        public int currentSpeed;
        public bool isOn;
        
        public Car()
        {
            model = "Unknown";
            color = "Standart";
            //...
        }
        
        public Car(string model, int price, int maxSpeed)
        {

            this.model = model;
            this.color = "Standard color";
            this.price = price;
            this.maxSpeed = maxSpeed;

        }

        public Car (string model, bool carIsOn)
        {
            
        }

        public Car(string carModel, string carColor, int carPrice, int carMaxSpeed, int carCurrentSpeed, bool carIsOn)
        {
            model = carModel;
            color = carColor;
            price = carPrice;
            maxSpeed = carMaxSpeed;
            currentSpeed = carCurrentSpeed > carMaxSpeed ? carMaxSpeed : carCurrentSpeed; // ???
            isOn = carIsOn;
        }
               


        public void PrintInfo()  // метод з х-ками
        {
            Console.WriteLine("Model: {0}\nColor: {1}\nPrice: {2}\nCurrent speed: {3}\nIs On:{4}", color, model, price, currentSpeed, isOn);
        }
    }
}
