using Dapper;
using Givestar.DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Givestar.DataAccess.DbPramHandler
{
    public class Document : IDocument
    {
        private readonly ISqlDataAccess _dataAccess;

        public Document(ISqlDataAccess sqlDataAccess)
        {

            _dataAccess = sqlDataAccess;
        }

        public async Task<IEnumerable<GiveStarModels.Document>> GetDocumentTypes()
        {
            var spName = "func_get_document_types";
            var queryParameters = new DynamicParameters();

            return await _dataAccess.GetData<GiveStarModels.Document>(queryParameters, spName);
        }
    }
}
