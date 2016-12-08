using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Nasliduvannia
{
    class Carrot: Product
    {
        public float length;

        public Carrot(int mId, float mPrice, float mLength) : base(mId, mPrice)
        {
            Console.WriteLine("From carrot");
            length = mLength;
        }
        public new void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine("ID: #{0}\nPrice: ${1}\n{2}", id, Price, this.GetType());
        }
    }
}
