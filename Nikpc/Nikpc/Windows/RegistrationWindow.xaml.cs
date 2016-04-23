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
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (userNameTxt.Text != "" && passwordTxt.Password != "" && passwordAgainTxt.Password != "" && nameTxt.Text != "" && emailTxt.Text != "")
            {
                if (passwordTxt.Password == passwordAgainTxt.Password)
                {

                }
                else
                    MessageBox.Show("A jelszavak nem egyeznek");
            }
            else
                MessageBox.Show("A csillaggal jelölt mezők kitöltése kötelező!");
        }
    }
}
