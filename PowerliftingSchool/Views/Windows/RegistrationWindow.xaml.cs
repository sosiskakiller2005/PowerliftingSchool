using PowerliftingSchool.AppData;
using PowerliftingSchool.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private static PowerliftingSchoolDbEntities _context = App.GetContext();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void EnterBTn_Click(object sender, RoutedEventArgs e)
        {
            if (FullnameTb.Text != string.Empty && EmailTb.Text != string.Empty && NumberTB.Text != string.Empty && PassTb.Password != string.Empty)
            {
                string[] Fullname = FullnameTb.Text.Split(' ');
                User newUser = new User() 
                {
                    Lastname = Fullname[0],
                    Name = Fullname[1],
                    Surname = Fullname[2],
                    Email = EmailTb.Text,
                    Phonenumber = NumberTB.Text,
                    Password = PassTb.Password
                };
                _context.User.Add(newUser);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            MessageBoxHelper.Error("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
                int lastId = _context.User.ToList().Last().Id;
                IdTbl.Text = lastId.ToString();
                MessageGrid.Visibility = Visibility.Visible;
                RegistrationGrid.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBoxHelper.Error("Заполните все поля для ввода.");
            }
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            Close();
        }
    }
}
