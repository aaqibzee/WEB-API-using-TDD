using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_using_TDD.Models;

namespace WEB_API_using_TDD.Services
{
    public class UserService: IUserService
    {

        async Task<IEnumerable<User>> IUserService.GetAllUsers()
        {
            return new List<User>();
        }
    }
}
