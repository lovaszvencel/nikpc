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

namespace Nikpc.Windows
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        UserController uc;
        public RegistrationWindow()
        {
            InitializeComponent();
            uc = new UserController();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            /**
            * TODO esetleg plusz ellenőrzés, hogy helyesek-e a bevitt adatok
            * TODO ne legyen usernév ütközés
            */
            if (userNameTxt.Text != "" && passwordTxt.Password != "" && passwordAgainTxt.Password != "" && nameTxt.Text != "" && emailTxt.Text != "")
            {
                if (passwordTxt.Password == passwordAgainTxt.Password)
                {
                    string type = "vasarlo";
                    if (alkalmazottadiobtn.IsChecked.Value) type = "alkalmazott";
                    if (adminradiobtn.IsChecked.Value) type = "admin";

                    uc.AddUser(new User
                    {
                        Type = type,
                        Name = nameTxt.Text,
                        Address = addressTxt.Text,
                        Email = emailTxt.Text,
                        Password = passwordTxt.Password,
                        PhoneNumber = phoneTxt.Text,
                        Username = userNameTxt.Text
                    });
                    MessageBox.Show("Sikeres regisztráció!");
                    this.Close();
                }
                else
                    MessageBox.Show("A jelszavak nem egyeznek");
            }
            else
                MessageBox.Show("A csillaggal jelölt mezők kitöltése kötelező!");
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Biztosan kilép mentés nélkül?", "Megerősítés", MessageBoxButton.YesNo))
                this.Close();
        }
    }
}
