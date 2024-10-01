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
using System.Windows.Shapes;

namespace PowerliftingSchool.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditStudentWindow.xaml
    /// </summary>
    public partial class AddEditStudentWindow : Window
    {
        private static PowerliftingSchoolDbEntities _context = App.GetContext();
        public AddEditStudentWindow()
        {
            InitializeComponent();
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
        }
        public AddEditStudentWindow(Students selectedStudent)
        {
            InitializeComponent();
            UserGrid.DataContext = selectedStudent;
            BirthdayDp.SelectedDate = selectedStudent.Birthday;
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.SelectedItem = selectedStudent.Group;
        }
    }
}
