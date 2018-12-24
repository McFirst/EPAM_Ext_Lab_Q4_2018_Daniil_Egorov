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

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            User y = null;
            y = this.use.FirstOrDefault(x => x.ID == id);
            if (y != null)
            {
                this.use.Remove(y);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// получение пользователя по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// получение всего списка
        /// </summary>
        /// <returns></returns>
        public List<User> GetAll()
        {
            return this.use;
        }

        /// <summary>
        /// добавление нового пользователя
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Save(User entity)
        {
            if (this.use.Exists(x => x.ID == entity.ID))
            {
                return false;
            }
            else
            {
                this.use.Add(entity);
                return true;
            }
        }

        /// <summary>
        /// первичная загрузка спискапользователей
        /// </summary>
        /// <returns></returns>
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