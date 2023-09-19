using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_LR5_Kuz
{
    internal class Americano : HotDrinkcs
    {
        //public override int Price => 15;
        protected new int price = 25;
        public override int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
