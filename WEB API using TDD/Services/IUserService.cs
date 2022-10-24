using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_using_TDD.Models;

namespace WEB_API_using_TDD.Services
{
    public interface IUserService
    {
       public Task<IEnumerable<User>> GetAllUsers();
    }
}
