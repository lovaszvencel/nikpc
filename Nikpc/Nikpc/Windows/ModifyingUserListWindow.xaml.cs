﻿using Nikpc.Controllers;
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
    /// Interaction logic for ModifyingUsersWindow.xaml
    /// </summary>
    public partial class ModifyingUserListWindow : Window
    {
        UserController uc;
        public ModifyingUserListWindow()
        {
            InitializeComponent();
            uc = new UserController();
        }

        private void AddUserClick(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.Title = "Felhasználó hozzáadása";
            rw.udvLbl.Content = "Új felhasználó";
            rw.RegisterButton.Content = "Hozzáad";
            rw.typeLabel.Visibility = Visibility.Visible;
            rw.typeButtons.Visibility = Visibility.Visible;
            rw.Show();
        }

        private void DeleteUserClick(object sender, RoutedEventArgs e)
        {
            if (usersList.SelectedItem != null)
            {
                uc.DeleteUser(usersList.SelectedItem as User);
                MessageBox.Show("A felhasználót sikeresen töröltük!", "Felhasználó törlése", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Válassz ki egy felhasználót!", "Nincs felhasználó kiválasztva", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void ModifyUserClick(object sender, RoutedEventArgs e)
        {
            if (usersList.SelectedItem != null)
            {
                ModifyingUserDataWindow mudw = new ModifyingUserDataWindow(usersList.SelectedItem as User);
                if (mudw.ShowDialog() != true)
                {
                    usersList.ItemsSource = null;
                    usersList.ItemsSource = UserController.AllUsers;
                }
            }
            else
                MessageBox.Show("Válassz ki egy felhasználót!", "Nincs felhasználó kiválasztva", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
