using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_Assignment_API.DataAccess;

namespace DNP_Assignment_API.Models
{
    public class AdultManagerDBImpl : AdultManager
    {
        private IDatabaseManager DatabaseManager=new DatabaseManager();
       

        public async Task addAdult(Adult adult)
        {
           await DatabaseManager.AddAdult(adult);
        }

        public async Task<List<Adult>> getAllAdults()
        {
            List<Adult> adults=await DatabaseManager.GetAllAdults();
            return adults;
        }
    }
}