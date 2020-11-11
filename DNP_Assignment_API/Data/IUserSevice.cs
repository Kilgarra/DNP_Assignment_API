using System.Threading.Tasks;
using DNP_Assignment_API.Models;

namespace DNP_Assignment_API.Data
{
    public interface IUserService {
        Task<User> ValidateUser(string userName, string password);
    }
}