using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using CapitalPlacementTask.Infrastructure.Implementation;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramDetailController : BaseController
    {
        private readonly IProgramDetailService _programDetailService;
        public ProgramDetailController(IProgramDetailService programDetailService)
        {
            _programDetailService = programDetailService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(BaseResponse<bool>), 200)]
        public async Task<IActionResult> CreateForm(CreateProgramDetailDTO model)
        {

            return ReturnResponse(await _programDetailService.CreateProgramDetail(model));

        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(BaseResponse<ProgramDetailDTO>), 200)]
        public async Task<IActionResult> GetProgramDetail(Guid Id)
        {
            return ReturnResponse(await _programDetailService.GetProgramDetail(Id));

        }

        [HttpPut("{programId}")]
        [ProducesResponseType(typeof(BaseResponse<bool>), 200)]
        public async Task<IActionResult> UpdateApplicationForm(Guid programId, ProgramDetailDTO model)
        {

            return ReturnResponse(await _programDetailService.UpdateProgram(programId, model));

        }
    }
}
