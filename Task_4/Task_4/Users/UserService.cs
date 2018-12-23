namespace Task_4.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Task_4.Interface;

    public class UserService : IBaseRepository<User>
    {
        /// <summary>
        ////приватный список пользователей
        /// </summary>
        private List<User> use = new List<User>(3);

        /// Удаление
        public bool Delete(int id)
        {
            bool del = false;
            foreach (User i in this.use)
            {
                if (i.ID == id)
                {
                    this.use.RemoveAt(id);
                    del = true;
                    break;
                }
            }

            return del;
        }

        /// получение пользователя по ID
        public User Get(int id)
        {
            User ret = null;
            foreach (User i in this.use)
            {
                if (i.ID == id)
                {
                    ret = i;
                }
            }

            return ret;
        }

        ///получение всего списка
        public List<User> GetAll()
        {
            return this.use;
        }

        ///добавление нового пользователя
        public bool Save(User entity)
        {
            bool sav = false;
            foreach (User i in this.use)
            {
                if (i.ID == entity.ID)
                {
                    sav = true;
                }
            }

            if (sav)
            {
                this.use.Add(entity);
            }
            return sav;
        }

        ///первичная загрузка спискапользователей
        public bool LoadUsers()
        {
            User user1 = new User(1, "Login1", "User1", "SurUser1", "user1@mail.ru", "pass1", "01.01.2001", "guest");
            User user2 = new User(2, "Login2", "User2", "SurUser2", "user2@mail.ru", "pass2", "02.02.2002", "admin");
            this.use.Add(user1);
            this.use.Add(user2);
            return true;
        }

    }
}