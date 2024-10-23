





namespace Givestar.DataAccess.DbPramHandler
{
    public interface IDocument
    {
        Task<IEnumerable<GiveStarModels.Document>> GetDocumentTypes();
    }
}