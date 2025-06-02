using PowerliftingSchool.AppData;
using PowerliftingSchool.Views.Pages;
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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            ProfilePage profilePage = new ProfilePage();
            MainFrm.Navigate(profilePage);
            FrameHelper.selectedFrame = MainFrm;UserGrid.DataContext = AuthoriseHelper.selectedUser;
            ProfileImage.Visibility = Visibility.Collapsed;
            ProfileBtn.Opacity = 0.5;
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            MainFrm.Navigate(profilePage);
            ProfileImage.Visibility = Visibility.Collapsed;
            ProfileBtn.Opacity = 0.5;
            ReportBTn.Opacity = 1;
            TimetableBtn.Opacity = 1;
            ListsBTn.Opacity = 1;
            ReportBTn.Opacity = 1;
            RateBtn.Opacity = 1;
        }

        private void ReportBTn_Click(object sender, RoutedEventArgs e)
        {
            ReportsPage reportsPage = new ReportsPage();
            MainFrm.Navigate(reportsPage);
            ProfileImage.Visibility = Visibility.Visible;
            ProfileBtn.Opacity = 1;
            ReportBTn.Opacity = 0.5;
            TimetableBtn.Opacity = 1;
            ListsBTn.Opacity = 1;
            RateBtn.Opacity = 1;
        }

        private void TimetableBtn_Click(object sender, RoutedEventArgs e)
        {
            TimetablePage timetablePage = new TimetablePage();
            MainFrm.Navigate(timetablePage);
            ProfileImage.Visibility = Visibility.Visible;
            ProfileBtn.Opacity = 1;
            ReportBTn.Opacity = 1;
            TimetableBtn.Opacity = 0.5;
            ListsBTn.Opacity = 1;
            ReportBTn.Opacity = 1;
            RateBtn.Opacity = 1;
        }

        private void ListsBTn_Click(object sender, RoutedEventArgs e)
        {
            ListsPage listsPage = new ListsPage();
            MainFrm.Navigate(listsPage);
            ProfileImage.Visibility = Visibility.Visible;
            ProfileBtn.Opacity = 1;
            ReportBTn.Opacity = 1;
            TimetableBtn.Opacity = 1;
            ListsBTn.Opacity = 0.5;
            ReportBTn.Opacity = 1;
            RateBtn.Opacity = 1;
        }

        private void RateBtn_Click(object sender, RoutedEventArgs e)
        {
            RatePage ratePage = new RatePage();
            MainFrm.Navigate(ratePage);
            ProfileImage.Visibility = Visibility.Visible;
            ProfileBtn.Opacity = 1;
            ReportBTn.Opacity = 1;
            TimetableBtn.Opacity = 1;
            ListsBTn.Opacity = 1;
            ReportBTn.Opacity = 1;
            RateBtn.Opacity = 0.5;
        }
    }
}
