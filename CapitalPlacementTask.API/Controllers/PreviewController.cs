using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : BaseController
    {
        private readonly IPreviewService _previewService;

        public PreviewController(IPreviewService previewService)
        {
            _previewService = previewService;
        }
        [HttpGet("{Id}")]

        [ProducesResponseType(typeof(BaseResponse<PreviewDTO>), 200)]
        public async Task<IActionResult> GetPreview(Guid programId)
        {
            return ReturnResponse(await _previewService.GetPreview(programId));

        }
    }
}
