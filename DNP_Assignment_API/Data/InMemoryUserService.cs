using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP_Assignment_API.Models;

namespace DNP_Assignment_API.Data
{
    public class InMemoryUserService : IUserService {
        private List<User> users;

        public InMemoryUserService() {
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
        }


        public async Task<User> ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}