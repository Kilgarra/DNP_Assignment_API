using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNP_Assignment_API.Models
{
    public interface AdultManager
    {
        void readAdults();
        Task addAdult(Adult adult);
        Task<List<Adult>> getAllAdults();
        Adult getAdult(Adult adult);
        List<Adult> getAdultsByFirstName(string FirstName);
        List<Adult> getAdultsByLastName(string LastName);
        Adult getAdultsByID(int ID);
        List<Adult> getAdultsByHaircolor(string Haircolor);
        List<Adult> getAdultsByEyecolor(string Eyecolor);
        List<Adult> getAdultsByAge(int Age);
        List<Adult> getAdultsByHeight(int Height);
        List<Adult> getAdultsByWeight(double Weight);
        List<Adult> getAdultsByJob(string job);
        List<Adult> getAdultsBySex(string Sex);
    }
}
