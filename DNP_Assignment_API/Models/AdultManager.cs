using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNP_Assignment_API.Models
{
    public interface AdultManager
    {
        Task addAdult(Adult adult);
        Task<List<Adult>> getAllAdults();
        
    }
}
