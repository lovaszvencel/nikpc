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
using System.Windows.Shapes;

namespace Nikpc.Windows
{
    /// <summary>
    /// Interaction logic for StatsWindow.xaml
    /// </summary>
    public partial class StatsWindow : Window
    {
        public StatsWindow()
        {
            InitializeComponent();
            nikpcEntities1 db = new nikpcEntities1();
            var sum1 = from akt in db.Order
                       group akt by akt.Id into g
                       select g;
            sumShop.Content = sum1.Count();

            var sum2 = from akt in db.Order
                       select akt;
            double sum = 0;
            foreach(var a in sum2)
            {
                sum += (double)a.Total;
            }

            sumPrice.Content = sum;
        }
    }
}
