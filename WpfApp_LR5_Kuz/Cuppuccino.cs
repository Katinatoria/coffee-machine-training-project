using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_LR5_Kuz
{
    internal class Cuppuccino : HotDrinkcs
    {
        public new int price = 50;

        public override int Price { 
            set 
            {
                price = value; 
            }
            get
            {
                return price;
            }
        }
    }
}
