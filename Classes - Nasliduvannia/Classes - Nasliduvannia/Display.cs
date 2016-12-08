using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Nasliduvannia
{
    class Display : Product
    {
        public string model;
        public int width;
        public int height;

        public string Resolution
        {
            get
            {
                return width + "x" + height;
            }
        }

        public Display(string mModel, int mWidth, int mHeight, float mPrice): base(9999, mPrice) 
        {
            model = mModel;
            width = mWidth;
            height = mHeight;
        }
    }
}
