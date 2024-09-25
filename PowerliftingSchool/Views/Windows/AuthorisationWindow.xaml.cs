using PowerliftingSchool.AppData;
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

namespace PowerliftingSchool.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void EnterBTn_Click(object sender, RoutedEventArgs e)
        {
            string id = IdTb.Text;
            string password = PassTb.Password;
            if (AuthoriseHelper.Authorise(id, password))
            {
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                Close();
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }
    }
}
