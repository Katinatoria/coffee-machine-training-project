using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_LR5_Kuz
{
    internal class Cocoa : HotDrinkcs
    {
        public new int price = 30;
        public override int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
