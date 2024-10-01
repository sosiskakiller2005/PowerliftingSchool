using PowerliftingSchool.AppData;
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
        private static Students _selectedStudent;
        public AddEditStudentWindow()
        {
            InitializeComponent();
            EditBtn.Visibility = Visibility.Collapsed;
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
        }
        public AddEditStudentWindow(Students selectedStudent)
        {
            InitializeComponent();
            _selectedStudent = selectedStudent;
            AddBtn.Visibility = Visibility.Collapsed;
            UserGrid.DataContext = selectedStudent;
            BirthdayDp.SelectedDate = selectedStudent.Birthday;
            GroupCmb.ItemsSource = _context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.SelectedItem = selectedStudent.Group;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LastnameTb.Text) || string.IsNullOrEmpty(NameTB.Text) || string.IsNullOrEmpty(SurnameTb.Text) 
                || BirthdayDp.SelectedDate == null || GroupCmb.SelectedIndex == -1)
            {
                MessageBoxHelper.Error("Заполните все поля для ввода");
            }
            else
            {
                Students newStudent = new Students()
                {
                    Lastname = LastnameTb.Text,
                    Name = NameTB.Text,
                    Surname = SurnameTb.Text,
                    Birthday = (DateTime)BirthdayDp.SelectedDate,
                    Group = GroupCmb.SelectedItem as Group
                };
                _context.Students.Add(newStudent);
                _context.SaveChanges();
                MessageBoxHelper.Information("Ученик добавлен.");
                DialogResult = true;
                Close();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LastnameTb.Text) || string.IsNullOrEmpty(NameTB.Text) || string.IsNullOrEmpty(SurnameTb.Text)
                || BirthdayDp.SelectedDate == null || GroupCmb.SelectedIndex == -1)
            {
                MessageBoxHelper.Error("Заполните все поля для ввода");
            }
            else
            {
                _selectedStudent.Lastname = LastnameTb.Text;
                    _selectedStudent.Name = NameTB.Text;
                    _selectedStudent.Surname = SurnameTb.Text;
                    _selectedStudent.Birthday = (DateTime)BirthdayDp.SelectedDate;
                    _selectedStudent.Group = GroupCmb.SelectedItem as Group;
                    _context.SaveChanges();
                    MessageBoxHelper.Information("Информация о ученике изменена.");
                    DialogResult = true;
                    Close();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
