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
    /// Interaction logic for ModifyingMyDataWindow.xaml
    /// </summary>
    public partial class ModifyingMyDataWindow : Window
    {
        Controllers.UserController uc;
        public ModifyingMyDataWindow()
        {
            InitializeComponent();
            this.DataContext = Controllers.UserController.currentUser;
            uc = new Controllers.UserController();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (userNameTxt.Text != "" && oldPasswordTxt.Password != "" && newPasswordTxt.Password != "" && newPasswordAgainTxt.Password != "" && nameTxt.Text != "" && emailTxt.Text != "")
            {
                if (oldPasswordTxt.Password == Controllers.UserController.currentUser.Password)
                {
                    if (newPasswordTxt.Password == newPasswordAgainTxt.Password)
                    {
                        uc.ModifyUser(Controllers.UserController.currentUser,
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
                        MessageBox.Show("Az új jelszavak nem egyeznek!");
                }
                else
                    MessageBox.Show("A régi jelszó nem megfelelő!");
            }
            else
                MessageBox.Show("A csillaggal jelölt mezők kitöltése kötelező!");
        }
    }
}
