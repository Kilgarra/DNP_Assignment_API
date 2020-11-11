using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNP_Assignment_API.Models
{
    public class AdultManagerImpl:AdultManager
    {
        private List<Adult> adults;
        private string adultFile = "Adults.json";

        public AdultManagerImpl()
        {
            if (!File.Exists(adultFile))
            {
                File.Create(adultFile);
            }
            else
            {
                readAdults();
            }

        }
        public async Task addAdult(Adult adult)
        {
            foreach (Adult a in adults)
            {
                if (a == adult)
                {
                    throw new ArgumentException("Adult already exists");
                }
            }
            adults.Add(adult);
            string fileContent = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, fileContent);

        }
        public async Task<List<Adult>> getAllAdults()
        {
            return adults;
        }
        public Adult getAdult(Adult adult)
        {
            foreach (Adult a in adults)
            {
                if (a == adult)
                {
                    return a;
                }
            }
            throw new Exception("Adult does not exist");
        }

        public List<Adult> getAdultsByAge(int age)
        {
            List<Adult> ageList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.Age.Equals(age))
                {
                    ageList.Add(a);
                }
            }
            return ageList;
        }

        public List<Adult> getAdultsByEyecolor(string eyecolor)
        {
            List<Adult> eyeColorList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.EyeColor.Equals(eyecolor))
                {
                    eyeColorList.Add(a);
                }
            }
            return eyeColorList;
        }

        public List<Adult> getAdultsByFirstName(string firstName)
        {
            List<Adult> firstNameList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.FirstName.Equals(firstName))
                {
                    firstNameList.Add(a);
                }
            }
            return firstNameList;
        }

        public List<Adult> getAdultsByHaircolor(string haircolor)
        {
            List<Adult> hairColorList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.HairColor.Equals(haircolor))
                {
                    hairColorList.Add(a);
                }
            }
            return hairColorList;
        }

        public List<Adult> getAdultsByHeight(int height)
        {
            List<Adult> heightList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.Height.Equals(height))
                {
                    heightList.Add(a);
                }
            }
            return heightList;
        }

        public Adult getAdultsByID(int ID)
        {
            List<Adult> idList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.Id.Equals(ID))
                {
                    return a;
                }
            }
            throw new Exception("There is no adult with this ID");
        }

        public List<Adult> getAdultsByJob(string job)
        {
            List<Adult> jobList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.JobTitle.Equals(job))
                {
                    jobList.Add(a);
                }
            }
            return jobList;
        }

        public List<Adult> getAdultsByLastName(string lastName)
        {
            List<Adult> lastNameList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.LastName.Equals(lastName))
                {
                    lastNameList.Add(a);
                }
            }
            return lastNameList;
        }

        public List<Adult> getAdultsBySex(string sex)
        {
            List<Adult> sexList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.Sex.Equals(sex))
                {
                    sexList.Add(a);
                }
            }
            return sexList;
        }

        public List<Adult> getAdultsByWeight(double weight)
        {
            List<Adult> weightList = new List<Adult>();
            foreach (Adult a in adults)
            {
                if (a.Weight.Equals(weight))
                {
                    weightList.Add(a);
                }
            }
            return weightList;
        }

        public void readAdults()
        {
            string file = File.ReadAllText(adultFile);
            adults = JsonSerializer.Deserialize<List<Adult>>(file);
        }
    }
}
