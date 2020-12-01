using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP_Assignment_API.DataAccess;
using DNP_Assignment_API.Models;

namespace DNP_Assignment_API.Data
{
    public class InMemoryUserService : IUserService
    {
        private IDatabaseManager DatabaseManager;
        private List<User> users;

        public InMemoryUserService() {
            DatabaseManager=new DatabaseManager();
            if (DatabaseManager.GetAllUsers().Result.Count==0)
            {
                AddUsers();
            }
            
        }


        public async Task<User> ValidateUser(string userName, string password)
        {

            User first = await DatabaseManager.GetUser(userName);
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public async void AddUsers()
        {
            users = new[] {
                new User {
                    Password = "123456",
                    Role = "Admin",
                    SecurityLevel = 2,
                    UserName = "Marton"
                },
                new User {
                    Password = "123456",
                    Role = "User",
                    SecurityLevel = 1,
                    UserName = "Anett"
                }
            }.ToList();
            await DatabaseManager.AddUsers(users);
        }
    }
}