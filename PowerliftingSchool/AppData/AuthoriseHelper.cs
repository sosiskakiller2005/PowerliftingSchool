using PowerliftingSchool.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerliftingSchool.AppData
{
    internal class AuthoriseHelper
    {
        private static PowerliftingSchoolDbEntities _context = App.GetContext();
        public static User selectedUser;
        public static bool Authorise(string id, string password)
        {
            List<User> users = _context.User.ToList();

            if (id == string.Empty || password == string.Empty)
            {
                MessageBoxHelper.Error("Не все поля для ввода были заполнены.");
                return false;
            }
            else
            {
                foreach (User user in users)
                {
                    if (user.Id.ToString() == id && user.Password == password)
                    {
                        selectedUser = user;
                        return true;
                    }
                }
                if (selectedUser != null)
                {
                    return true;
                }
                else
                {
                    MessageBoxHelper.Error("Неправильно введен Id или пароль.");
                    return false;
                }
            }
        }
    }
}
