using CapitalPlacementTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs.FormDTOs
{
    public class WorkExperienceDTO
    {
        [Required]
        public string Company { get; set; }
        [Required]
        public string Title { get; set; }
        public string LocationOfWork { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CurrentlyWorkThere { get; set; }


      
    }
}
