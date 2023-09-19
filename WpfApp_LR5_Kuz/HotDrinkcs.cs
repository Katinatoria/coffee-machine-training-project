using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfApp_LR5_Kuz
{
    abstract class HotDrinkcs
    {
        private string sugar;
        private string milk;
        protected int price;

        public abstract int Price { get; set; }
        bool Milk { get; set; } = false;
        bool Sugar { get; set; } = false;

        public virtual void priceDrink(int pri) //цена напитка
        {

        }        

        public void AddMilk()
        {
        }

        public void AddSugar()
        {
        }

    }
}
