using CapitalPlacementTask.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Domain.Entities
{
    public class Workflow: BaseEntity<Guid>
    {
        
        public Guid ProgramId { get; set; }

        public string StageName { get; set; }
        public Stages StageType { get; set; }
    }
}
