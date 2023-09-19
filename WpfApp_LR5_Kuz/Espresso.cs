using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_LR5_Kuz
{
    internal class Espresso : HotDrinkcs
    {
        public new int price = 15;
        public override int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
