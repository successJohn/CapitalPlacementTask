using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.Interfaces
{
    public interface IProgramDetailService
    {
        Task<BaseResponse<bool>> CreateProgramDetail(CreateProgramDetailDTO model);
        Task<BaseResponse<ProgramDetailDTO>> GetProgramDetail(Guid id);
        Task<BaseResponse<ProgramDetailDTO>> UpdateProgram(Guid id, ProgramDetailDTO model);
    }
}
