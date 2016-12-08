using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Nasliduvannia
{
     class Computer : Product
    {
        public string name;
        public string proc;
        public bool touchScreen;

        public Display display;
        
        public Computer(string mName, string mProc, bool mTouchScreen, int mPrice) : base(234234, mPrice)
        {
            name = mName;
            proc = mProc;
            touchScreen = mTouchScreen;
            display = new Display(mName, 0, 0, mPrice * 0.25F);
        }

        public override string ToString()
        {
            return "Name:" + name + "\nProc:" + proc + "\nTouch screen:" + touchScreen + "\nPrice:" + Price;
        }
    }
}
