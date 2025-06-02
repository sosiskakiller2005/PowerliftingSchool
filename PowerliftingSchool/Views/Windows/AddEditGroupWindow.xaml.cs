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
    /// Логика взаимодействия для AddEditGroupWindow.xaml
    /// </summary>
    public partial class AddEditGroupWindow : Window
    {
        private static PowerliftingSchoolDbEntities _context = App.GetContext();
        private Group _selectedGroup;
        public AddEditGroupWindow()
        {
            InitializeComponent();
            TitleTbl.Text = "Добавление группы";
            EditBtn.Visibility = Visibility.Collapsed;
            UserCmb.ItemsSource = _context.User.ToList();
            UserCmb.DisplayMemberPath = "Fullname";
        }
        public AddEditGroupWindow(Group selectedGroup)
        {
            InitializeComponent();
            TitleTbl.Text = "Редактирование группы";
            _selectedGroup = selectedGroup;
            DataContext = selectedGroup;
            UserGrid.DataContext = selectedGroup;
            NameTb.Text = selectedGroup.User.Fullname;
            AddBtn.Visibility = Visibility.Collapsed;
            UserCmb.ItemsSource = _context.User.ToList();
            UserCmb.DisplayMemberPath = "Fullname";
            UserCmb.SelectedItem = selectedGroup.User;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTb.Text) && UserCmb.SelectedItem != null)
            {
                Group newGroup = new Group()
                {
                    Name = NameTb.Text,
                    UserId = (UserCmb.SelectedItem as User).Id
                };
                _context.Group.Add(newGroup);
                _context.SaveChanges();
                MessageBoxHelper.Information("Группа успешно добавлена");
                DialogResult = true;
            }
            else
            {
                MessageBoxHelper.Error("Пожалуйста, заполните все поля");
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTb.Text) && UserCmb.SelectedItem != null)
            {
                _selectedGroup.Name = NameTb.Text;
                _selectedGroup.UserId = (UserCmb.SelectedItem as User).Id;
                _context.SaveChanges();
                MessageBoxHelper.Information("Группа успешно изменена");
                DialogResult = true;
            }
            else
            {
                MessageBoxHelper.Error("Пожалуйста, заполните все поля");
            }
        }
    }
}
