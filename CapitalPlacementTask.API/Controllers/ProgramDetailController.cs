using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.Interfaces;
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
        public async Task<IActionResult> CreateForm(CreateProgramDetailDTO model)
        {

            return ReturnResponse(await _programDetailService.CreateProgramDetail(model));

        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetForm(Guid Id)
        {
            return ReturnResponse(await _programDetailService.GetProgramDetail(Id));

        }

        [HttpPut("{programId}")]
        public async Task<IActionResult> UpdateApplicationForm(Guid programId, ProgramDetailDTO model)
        {

            return ReturnResponse(await _programDetailService.UpdateProgram(programId, model));

        }
    }
}
