using CapitalPlacementTask.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Domain.Entities
{
    public class ProgramDetail
    {
        public string Id { get; set; }
        [Required]
        public string ProgramTitle { get; set; }

        public string Summary { get; set; }

        [Required]
        public string ProgramDescription { get; set; }
        public string skills { get; set; }
        public string benefit { get; set; }
        public string criteria { get; set; }

        [Required]
        public ProgramType programType { get; set; }

        public DateTime ProgramStart { get; set; }

        [Required]
        public DateTime ApplicationOpen { get; set; }

        [Required]
        public DateTime ApplicationClose { get; set; }

        public string Duration { get; set; }

        public string ProgramLocation { get; set; }

        public Qualification MinQualification { get; set; }
    }
}
