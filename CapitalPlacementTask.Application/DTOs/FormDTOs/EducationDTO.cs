using CapitalPlacementTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs.FormDTOs
{
    public class EducationDTO
    {
        [Required]
        public string School { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string SchoolLocation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CurrentlyStudyingThere { get; set; }


     
    }
}
