using DocumentIntelligence.Business.Models.Request;
using DocumentIntelligence.Business.Models.Response;

namespace DocumentIntelligence.Business.Interfaces
{
    public interface IOpenAIService
    {
        Task<ClassificationResponse> ClassifyAsync(DocumentRequest? request);

        Task<ExtractionResponse> ExtractAsync(DocumentRequest? request);
    }
}
