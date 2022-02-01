using Newtonsoft.Json;

namespace IIGApi.Models.Dto
{
    public class CustomerDto
    {
        [JsonProperty("firstname")]
        public string? Firstname { get; set; }
        
        [JsonProperty("lastname")]
        public string? Lastname { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("mobilePhone")]
        public string? MobilePhone { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }
    }
}