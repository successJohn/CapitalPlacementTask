using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.Interfaces
{
    public interface IPreviewService
    {
        Task<BaseResponse<PreviewDTO>> GetPreview(Guid programId);
    }
}
