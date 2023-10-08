using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Domain.Entities
{
    public class Preview
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }

        public Guid ProgramId { get; set; }
    }
}
