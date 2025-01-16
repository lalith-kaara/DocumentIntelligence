using System.Text.Json.Serialization;

namespace DocumentIntelligence.Business.Models.Request
{
    public record DocumentRequest(
        [property: JsonPropertyName("base64Content")] string? Base64Content
    );
}
