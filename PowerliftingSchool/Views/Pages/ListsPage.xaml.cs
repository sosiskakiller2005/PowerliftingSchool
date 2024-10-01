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
    /// Логика взаимодействия для ListsPage.xaml
    /// </summary>
    public partial class ListsPage : Page
    {
        public static PowerliftingSchoolDbEntities _context = App.GetContext();
        public ListsPage()
        {
            InitializeComponent();
            StudentsLv.ItemsSource = _context.Students.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditStudentWindow addStudentWindow = new AddEditStudentWindow();
            addStudentWindow.ShowDialog();
            if (addStudentWindow.DialogResult == true)
            {
                StudentsLv.ItemsSource = App.GetContext().Students.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (StudentsLv.SelectedItem != null)
            {
                AddEditStudentWindow editStudentWindow = new AddEditStudentWindow(StudentsLv.SelectedItem as Students);
                editStudentWindow.ShowDialog();
                if (editStudentWindow.DialogResult == true)
                {
                    StudentsLv.ItemsSource = App.GetContext().Students.ToList();
                }
            }
        }
    }
}
