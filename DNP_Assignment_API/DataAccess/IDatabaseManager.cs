using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_Assignment_API.Models;

namespace DNP_Assignment_API.DataAccess
{
    public interface IDatabaseManager
    {
        Task AddAdult(Adult adult);
        Task<List<Adult>> GetAllAdults();
        Task<User> GetUser(String username);
        Task AddUsers(List<User> users);
        Task<List<User>> GetAllUsers();

    }
}