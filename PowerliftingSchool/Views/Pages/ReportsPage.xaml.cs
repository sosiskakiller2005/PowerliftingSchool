using PowerliftingSchool.Model;
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
    /// Логика взаимодействия для ReportsPage.xaml
    /// </summary>
    public partial class ReportsPage : Page
    {
        public static PowerliftingSchoolDbEntities _context = App.GetContext();
        public ReportsPage()
        {
            InitializeComponent();
            GroupsLb.ItemsSource = _context.Group.ToList();
        }

        private void GroupsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
