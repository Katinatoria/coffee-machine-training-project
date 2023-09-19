using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;


namespace WpfApp_LR5B_Kuz
{
    internal class Elevator 
    {
        MainWindow wind;
        public Elev elev = Elev.Up;
        public Elev cond = Elev.Open;

        public Elevator()
        {

        }

        public enum Elev
        {
            Up,
            Down,
            Open,
            Closed
        }

        public string moveUp(int fl, Elev cond, int level) //едем вверх
        {
            this.cond = cond;
            door(cond);

            if (level == fl)
            {
                MessageBox.Show("Движение невозможно, вы на последнем этаже");
                return "Этаж: " + Convert.ToString(fl);
                cond = Elev.Open;
                door(cond);
            }
            else if (cond == Elev.Closed)
            {
                MessageBox.Show("Вы движетесь вверх");
                return "Этаж: " + Convert.ToString(fl);
            }

            return "";
        }

        public string moveDown(int fl, Elev cond, int level) //едем вверх
        {
            this.cond = cond;
            door(cond);

            if (level == 1)
            {
                MessageBox.Show("Движение невозможно, вы на первом этаже");
                return "Этаж: " + Convert.ToString(level);
                cond = Elev.Open;
                door(cond);
            }
            else if (cond == Elev.Closed || level != 1)
            {
                MessageBox.Show("Вы движетесь вниз");
                return "Этаж: " + Convert.ToString(1);
            }

            return "";
        }

        public void door(Elev condin)
        {
            wind = new MainWindow();

            if (condin == Elev.Closed)
            {
                wind.Label_CondElev.Content = "Двери закрыты";
            }
            else if (condin == Elev.Open)
            {
                wind.Label_CondElev.Content = "Двери открыты";
            }

        }
    }
}
