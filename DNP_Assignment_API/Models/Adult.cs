using System;
using System.Text.Json.Serialization;

namespace DNP_Assignment_API.Models
{
    public class Adult:Person
    {
        public Adult(string FirstName, string LastName, int Id, string HairColor, string EyeColor, int Age, double Weight, int Height, string JobTitle, string Sex) : base(FirstName, LastName, Id, HairColor, EyeColor, Age, Weight, Height, Sex)
        {
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(LastName) || Age == 0 || Weight == 0 || Height == 0 || String.IsNullOrEmpty(JobTitle) || String.IsNullOrEmpty(Sex))
            {
                throw new Exception("All fields must have a value");
            }
            else
            {
                this.JobTitle = JobTitle;
            }

        }
        public Adult()
        {

        }
        [JsonPropertyName("JobTitle")]
        public String JobTitle { get; set; }


    }
}