using System.Text.Json.Serialization;

namespace DocumentIntelligence.Business.Models.Response
{
    public class ApiResponse
    {
        [JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonPropertyName("result")]
        public object? Result { get; set; } = null;

        [JsonPropertyName("error")]
        public object? Error { get; set; } = null;
    }
}
