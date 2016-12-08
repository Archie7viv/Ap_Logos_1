using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Nasliduvannia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product(152343, 15);
            //p1.PrintGeneralInfo();
            //Carrot c1 = new Carrot(19999, 12, 11);
            //c1.PrintGeneralInfo();

            Computer c1 = new Computer("ASUS", "i7-k5600", true, 999);
            Console.WriteLine(c1);
            c1.display.width = 1920;
            c1.display.height = 1080;
            Console.WriteLine(c1.display.Resolution);

            //c1.Price = 15;
           // Console.WriteLine(c1);

        }
    }
}
