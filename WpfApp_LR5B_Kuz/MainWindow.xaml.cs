using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace WpfApp_LR5B_Kuz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Elevator elevator;
        int level = 1; //текущий этаж

        public MainWindow()
        {
            InitializeComponent();
            elevator = new Elevator();
        }

        // Едем вверх
        private void Button_Lets_Click(object sender, RoutedEventArgs e)
        {
            int fl = int.Parse(TextBox_quantity.Text);
            LabelFloorDin.Content = elevator.moveUp(fl, Elevator.Elev.Closed, level); //движение вверх 
            level = fl;
            TextBox_quantity.Text = "1";
        }

        private void Button_Lets_Down_Click(object sender, RoutedEventArgs e)
        {
            int fl = int.Parse(TextBox_quantity.Text);
            LabelFloorDin.Content = elevator.moveDown(fl, Elevator.Elev.Closed, level); //движение вниз
            level = fl;
            TextBox_quantity.Text = "1";
        }
    }
}
