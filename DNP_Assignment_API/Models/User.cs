using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace DNP_Assignment_API.Models
{
    public class User {
        [Key, NotNull]
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [NotNull]
        [JsonPropertyName("role")]

        public string Role { get; set; }
        [NotNull]
        [JsonPropertyName("securityLevel")]

        public int SecurityLevel { get; set; }
        [NotNull]
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}