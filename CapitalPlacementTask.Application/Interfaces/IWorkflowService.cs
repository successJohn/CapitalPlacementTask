using CapitalPlacementTask.Application.DTOs.WorkflowDTOs;
using CapitalPlacementTask.Application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.Interfaces
{
    public interface IWorkflowService
    {
        Task<BaseResponse<WorkflowDTO>> GetWorkflowByIdAsync(Guid id);
        Task<BaseResponse<WorkflowDTO>> UpdateWorkflowAsync(Guid id, WorkflowDTO model);
    }
}
