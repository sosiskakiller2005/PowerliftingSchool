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

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditGroupWindow addEditGroupWindow = new AddEditGroupWindow();
            if (addEditGroupWindow.ShowDialog() == true)
            {
                GroupsLb.ItemsSource = App.GetContext().Group.ToList();
            }
        }

        private void GroupsLb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedGroup = GroupsLb.SelectedItem as Group;
            if (selectedGroup == null)
                MessageBoxHelper.Error("Выберите группу для редактирования");

            AddEditGroupWindow addEditGroupWindow = new AddEditGroupWindow(selectedGroup);
            if (addEditGroupWindow.ShowDialog() == true)
            {
                GroupsLb.ItemsSource = App.GetContext().Group.ToList();
            }
        }
    }
}
