using PowerliftingSchool.AppData;
using PowerliftingSchool.Model;
using PowerliftingSchool.Views.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PowerliftingSchool.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private static PowerliftingSchoolDbEntities _context = App.GetContext();
        public ProfilePage()
        {
            InitializeComponent();
            UserGrid.DataContext = AuthoriseHelper.selectedUser;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthoriseHelper.selectedUser = null;
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            FrameHelper.selectedWindow.Close();
        }
    }
}
