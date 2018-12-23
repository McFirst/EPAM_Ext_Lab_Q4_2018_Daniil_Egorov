namespace Task_4.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task_4.Users;

    public interface IUserService : IBaseRepository<User>
    {
        bool LoadUsers();
    }
}
