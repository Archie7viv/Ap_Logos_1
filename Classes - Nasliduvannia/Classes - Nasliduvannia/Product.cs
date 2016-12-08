using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Nasliduvannia
{
    class Product
    {
        public readonly int id;
        private float price;
        public float Price //property
        {
            get
            {
                return price;
            }
            set
            {
                price = (int)value + 1f - 0.01f;
            }
        }
        
        public Product(int mId, float mPrice = 10.99f)
        {
            Console.WriteLine("From product");
            id = mId;
            Price = mPrice;
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("from Product");
            Console.WriteLine("ID: #{0}\nPrice: ${1}\n{2}", id, Price, this.GetType());
        }
    }

}
