using System.Text.Json.Serialization;

namespace DNP_Assignment_API.Models
{
    public class Person
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("HairColor")]
        public string HairColor { get; set; }
        [JsonPropertyName("EyeColor")]
        public string EyeColor { get; set; }
        [JsonPropertyName("Age")]
        public int Age { get; set; }
        [JsonPropertyName("Weight")]
        public double Weight { get; set; }
        [JsonPropertyName("Height")]
        public int Height { get; set; }
        [JsonPropertyName("Sex")]
        public string Sex { get; set; }


        public Person(string FirstName, string LastName, int Id, string HairColor, string EyeColor, int Age, double Weight, int Height, string Sex)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
            this.HairColor = HairColor;
            this.EyeColor = EyeColor;
            this.Age = Age;
            this.Weight = Weight;
            this.Height = Height;
            this.Sex = Sex;
        }
        public Person()
        {

        }



    }
}