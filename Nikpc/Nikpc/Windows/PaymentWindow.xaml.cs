using Nikpc.Controllers;
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
using System.Xml.Linq;

namespace Nikpc.Windows
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        ProductController pc;
        CartController cc;
        nikpcEntities1 db = new nikpcEntities1();
        CurrencyExchange.MNBArfolyamServiceSoapClient client = new CurrencyExchange.MNBArfolyamServiceSoapClient();
        double localPrice;

        public PaymentWindow(Object price)
        {
            localPrice = double.Parse(price.ToString());
            pc = new ProductController();
            cc = new CartController();
            InitializeComponent();
            this.DataContext = price.ToString();
            chosenProductList.DataContext = cc;
            string current = client.GetCurrencies();
            XDocument doc = XDocument.Parse(current);
            var curr = doc.Descendants("Curr");
            foreach (var akt in doc.Descendants("Curr"))
            {
                currencies.Items.Add(akt.Value);
            }
        }

        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in UserController.currentUser.Cart)
            {
                pc.ReserveProduct(item);
            }
            
            UserController.currentUser.Cart = new List<ProductInCart>();

            MessageBox.Show("Sikeres rendelés!");
            Close();
        }

        private void currencies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (currencies.SelectedIndex > -1)
            {
                DateTime date = DateTime.Now;
                do
                {
                    date = date.AddDays(-1);
                }
                while (IsWeekend(date));

                string rates = client.GetExchangeRates(date.ToString(), date.ToString(), currencies.SelectedValue.ToString());
                XDocument doc = XDocument.Parse(rates);
                int unit = int.Parse(doc.Element("MNBExchangeRates").Element("Day").Element("Rate").Attribute("unit").Value);
                double rate = double.Parse(doc.Element("MNBExchangeRates").Element("Day").Element("Rate").Value);
                priceLabel.Content = (localPrice * unit) / rate;
            }
        }

        private bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday ||
                   date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
