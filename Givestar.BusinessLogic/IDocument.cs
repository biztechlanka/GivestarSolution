using GiveStarModels;

namespace Givestar.BusinessLogic
{
    public interface IDocument
    {
        Task<ApiResponse> GetDocumentTypes();
    }
}