using CapitalPlacementTask.Domain.Entities;
using CapitalPlacementTask.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs.WorkflowDTOs
{
    public class WorkflowDTO
    {
       
        public Guid ProgramId { get; set; }

        public string StageName { get; set; }
        public Stages StageType { get; set; }


        public static implicit operator WorkflowDTO(Workflow model)
        {
            return model is null ? null : new WorkflowDTO
            {
               
                ProgramId = model.ProgramId,
                StageName = model.StageName,
                StageType = model.StageType,

               
            };


        }
    }
}
