using Microsoft.AspNetCore.Mvc;
using Givestar.BusinessLogic;

namespace Givestar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocument _document;

        public DocumentController(IDocument document)
        {
              _document= document;
        }

        [HttpPost]
        public async Task<IActionResult> GetDocumentTypes()
        {
            return Ok(await _document.GetDocumentTypes());
        }
    }
}
