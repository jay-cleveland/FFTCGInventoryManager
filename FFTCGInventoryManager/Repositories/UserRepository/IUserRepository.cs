using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTCGInventoryManager.Repositories.UserRepository
{
    interface IUserRepository
    {
        void CreateUser(string email);
        void GetUser(int user_id);
    }
}
