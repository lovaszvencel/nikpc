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
    /// Interaction logic for ModifyingUserDataWindow.xaml
    /// </summary>
    public partial class ModifyingUserDataWindow : Window
    {
        Controllers.UserController uc;
        User user;
        public ModifyingUserDataWindow(User user)
        {
            InitializeComponent();
            this.DataContext = user;
            this.user = user;
            uc = new Controllers.UserController();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (userNameTxt.Text != "" && newPasswordTxt.Password != "" && newPasswordAgainTxt.Password != "" && nameTxt.Text != "" && emailTxt.Text != "")
            {
                if (newPasswordTxt.Password == newPasswordAgainTxt.Password)
                {
                    uc.ModifyUser(user as User,
                    new User
                    {
                        Type = "admin",
                        Name = nameTxt.Text,
                        Address = addressTxt.Text,
                        Email = emailTxt.Text,
                        Password = newPasswordTxt.Password,
                        PhoneNumber = phoneTxt.Text,
                        Username = userNameTxt.Text
                    });
                    MessageBox.Show("Sikeres változtatás!");
                    this.Close();
                }
                else
                    MessageBox.Show("A jelszavak nem egyeznek");
            }
            else
                MessageBox.Show("A csillaggal jelölt mezők kitöltése kötelező!");
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
