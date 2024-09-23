using PowerliftingSchool.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows;

namespace PowerliftingSchool
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PowerliftingSchoolDbEntities context = new PowerliftingSchoolDbEntities();
        public static PowerliftingSchoolDbEntities GetContext()
        {
            if (context == null)
            {
                context = new PowerliftingSchoolDbEntities();
                return context;
            }
            else
            {
                return context;
            }
        }
    }
}
