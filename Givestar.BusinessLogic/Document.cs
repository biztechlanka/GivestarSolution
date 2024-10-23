namespace Givestar.BusinessLogic
{

    public class Document : ApiResponseHandler, IDocument
    {
        private readonly DataAccess.DbPramHandler.IDocument _document;

        public Document(DataAccess.DbPramHandler.IDocument document)
        {
            _document = document;
        }

        public async Task<GiveStarModels.ApiResponse> GetDocumentTypes()
        {
            try
            {
                var rtn = await _document.GetDocumentTypes();

                if (rtn != null)
                {
                    return Success(rtn);
                }

                return Error(null);

            }
            catch (Exception ex)
            {
                return Exception(null, ex.Message);
            }
        }
    }
}
