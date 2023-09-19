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

namespace WpfApp_LR5_Kuz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        int pr = 0;
        HotDrinkcs es;

        public MainWindow()
        {
            InitializeComponent();
            ImageAmericano.Visibility = Visibility.Visible;
            forv();

        }

        private void cocoa_Checked(object sender, RoutedEventArgs e)
        {
            HotDrinkcs es = new Cocoa();
            LabelPrice.Content = "Цена напитка: " + es.Price;
            pr = es.Price;
        }

        private void espresso_Checked_1(object sender, RoutedEventArgs e)
        {
            HotDrinkcs es = new Espresso();
            LabelPrice.Content = "Цена напитка: " + es.Price;
            pr = es.Price;
        }

        private void cappuccino_Checked(object sender, RoutedEventArgs e)
        {
            HotDrinkcs es = new Cuppuccino();
            LabelPrice.Content = "Цена напитка: " + es.Price;
            pr = es.Price;
        }

        private void Americano_Checked(object sender, RoutedEventArgs e)
        {
            es = new Americano();
            LabelPrice.Content = "Цена напитка: " + es.Price;
            pr = es.Price;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int sum = int.Parse(TextBox.Text);
            LabelSum.Content = "Внесённая сумма: " + sum;

            if (sum < pr)
            {
                MessageBox.Show("У вас недостаточно средств");
            }
            else
            {
                LabelChange.Content = "Сдача:  " + (sum - pr);
                MessageBox.Show("Ваш напиток готов!");

            }


        }

        private void Milk_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Milk_Click(object sender, RoutedEventArgs e) // по клику
        {
            if (Milk.IsChecked == false)
            {
                ImageMilk.Visibility = Visibility.Collapsed;
            }
            else
            {
                ImageMilk.Visibility = Visibility.Visible;
            }
        }

        private void Sugar_Click(object sender, RoutedEventArgs e)
        {
            if (Sugar.IsChecked == false)
            {
                ImageSugar.Visibility = Visibility.Collapsed;
            }
            else
            {
                ImageSugar.Visibility = Visibility.Visible;
            }
        }

        private void Americano_Click(object sender, RoutedEventArgs e)
        {
            if (Americano.IsChecked == true)
            {

                ImageAmericano.Visibility = Visibility.Visible;
                ImageCocoa.Visibility = Visibility.Collapsed;
                ImageEspresso.Visibility = Visibility.Collapsed;
                ImageCappuccino.Visibility = Visibility.Collapsed;
            }
        }

        private void cocoa_Click(object sender, RoutedEventArgs e)
        {
            if (cocoa.IsChecked == true)
            {
                ImageCocoa.Visibility = Visibility.Visible;
                ImageAmericano.Visibility = Visibility.Collapsed;
                ImageEspresso.Visibility = Visibility.Collapsed;
                ImageCappuccino.Visibility = Visibility.Collapsed;
            }
        }


        private void espresso_Click(object sender, RoutedEventArgs e)
        {
            if (espresso.IsChecked == true)
            {
                ImageEspresso.Visibility = Visibility.Visible;
                ImageCocoa.Visibility = Visibility.Collapsed;
                ImageAmericano.Visibility = Visibility.Collapsed;
                ImageCappuccino.Visibility = Visibility.Collapsed;
            }
        }

        private void cappuccino_Click(object sender, RoutedEventArgs e)
        {
            if (cappuccino.IsChecked == true)
            {
                ImageCappuccino.Visibility = Visibility.Visible;
                ImageCocoa.Visibility = Visibility.Collapsed;
                ImageEspresso.Visibility = Visibility.Collapsed;
                ImageAmericano.Visibility = Visibility.Collapsed;
            }
        }

        public void forv()
        {
            if (Button1.IsPressed == true)
            {
                TextBox.Text = " ";
                LabelChange.Content = "Сдача: ";
                LabelSum.Content = "Внесённая сумма: ";
                LabelPrice.Content = "Цена напитка: ";
            }
        }
    }
}
