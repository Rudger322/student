using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp3
{
    public class Repository
    {
        //  список для хранения пользователей
        private List<User> users;

        // инициализация списка пользователей
        public Repository()
        {
            users = new List<User>();
        }

        //  добавление нового пользователя в список
        public void AddUser(User user)
        {
            users.Add(user);
        }

        //  обновление данных пользователя
        public void UpdateUser(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Citizenship == user.Citizenship);
            if (existingUser != null)
            {
                existingUser.Purpose = user.Purpose;
                existingUser.DateOfEntry = user.DateOfEntry;
                existingUser.Policy = user.Policy;
            }
        }

        //  генерация дорожной карты 
        public string GenerateRoadMap(User user)
        {
            return $"{user.Citizenship} - {user.Purpose} - {user.DateOfEntry.ToShortDateString()}";
        }
    }
}
