using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Application.DTOs.WorkflowDTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowController : BaseController
    {
        private readonly IWorkflowService _workflowService;
        public WorkflowController(IWorkflowService workflowService)
        {
            _workflowService = workflowService;
        }
       

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(BaseResponse<WorkflowDTO>), 200)]
        public async Task<IActionResult> GetForm(Guid Id)
        {
            return ReturnResponse(await _workflowService.GetWorkflowByIdAsync(Id));

        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(BaseResponse<bool>), 200)]
        public async Task<IActionResult> UpdateApplicationForm(Guid id, WorkflowDTO model)
        {

            return ReturnResponse(await _workflowService.UpdateWorkflowAsync(id, model));

        }
    }
}
