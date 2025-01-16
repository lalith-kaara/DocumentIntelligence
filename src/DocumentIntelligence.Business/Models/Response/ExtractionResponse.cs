using System.Text.Json.Serialization;

namespace DocumentIntelligence.Business.Models.Response
{
    public class ExtractionResponse
    {
        [JsonPropertyName("documentType")]
        public string? DocumentType { get; set; }

        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public string? DateOfBirth { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("documentNumber")]
        public string? DocumentNumber { get; set; }

        [JsonPropertyName("fatherName")]
        public string? FatherName { get; set; }

        [JsonPropertyName("motherName")]
        public string? MotherName { get; set; }

        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        [JsonPropertyName("nationality")]
        public string? Nationality { get; set; }

        [JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        [JsonPropertyName("issueDate")]
        public string? IssueDate { get; set; }
    }
}
