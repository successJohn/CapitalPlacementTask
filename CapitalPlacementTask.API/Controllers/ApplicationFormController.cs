
using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using CapitalPlacementTask.Infrastructure.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFormController : BaseController
    {
        private readonly IApplicationService _applicationFormService;

        public ApplicationFormController(IApplicationService applicationFormService)
        {
            _applicationFormService = applicationFormService;
        }
     

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResponse<ApplicationFormDTO>), 200)]
        public async Task<IActionResult> GetApplicationForm(Guid id)
        {
            return ReturnResponse(await _applicationFormService.GetApplicationForm(id));

        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(BaseResponse<ApplicationFormDTO>), 200)]
        public async Task<IActionResult> UpdateApplicationForm(Guid id, ApplicationFormDTO model)
        {
            return ReturnResponse(await _applicationFormService.UpdateApplicationForm(model, id));

        }
    }
}
