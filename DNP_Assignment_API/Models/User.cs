using System.Text.Json.Serialization;

namespace DNP_Assignment_API.Models
{
    public class User {
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [JsonPropertyName("role")]

        public string Role { get; set; }
        [JsonPropertyName("securityLevel")]

        public int SecurityLevel { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}