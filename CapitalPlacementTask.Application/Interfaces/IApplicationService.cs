using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.Interfaces
{
    public interface IApplicationService
    {
        
        Task<BaseResponse<ApplicationFormDTO>> GetApplicationForm(Guid id);
        Task<BaseResponse<bool>> UpdateApplicationForm(ApplicationFormDTO model, Guid id);
    }
}
