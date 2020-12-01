using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP_Assignment_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DNP_Assignment_API.DataAccess
{
    public class DatabaseManager:IDatabaseManager
    {
        public async Task AddAdult(Adult adult)
        {
            using (DBContext dbContext = new DBContext())
            {
                await dbContext.Adults.AddAsync(adult);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Adult>> GetAllAdults()
        {
            using (DBContext dbContext = new DBContext())
            {
                List<Adult> adults= await dbContext.Adults.ToListAsync();
                return adults;
            }
        }

        public async Task<User> GetUser(String username)
        {
            using (DBContext dbContext = new DBContext())
            {
                List<User> users=await dbContext.Users.ToListAsync();
                foreach (User u in users)
                {
                    if (u.UserName.Equals(username))
                    {
                        return u;
                    }
                }

                return null;
            }
        }

        public async Task AddUsers(List<User> users)
        {
            using (DBContext dbContext = new DBContext())
            {
                foreach (User u in users)
                {
                    await dbContext.Users.AddAsync(u);
                    await dbContext.SaveChangesAsync();
                }
            }

        }

        public async Task<List<User>> GetAllUsers()
        {
            using (DBContext dbContext = new DBContext())
            {
                List<User> users = await dbContext.Users.ToListAsync();
                    return users;
            }
        }
    }
}