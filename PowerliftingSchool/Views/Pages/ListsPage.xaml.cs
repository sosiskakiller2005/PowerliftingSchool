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
    }
}
