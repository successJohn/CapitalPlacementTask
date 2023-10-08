using CapitalPlacementTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs.FormDTOs
{
    public class ProfileDTO
    {
        public List<EducationDTO> Education { get; set; } = new List<EducationDTO>();
        public List<WorkExperienceDTO> WorkExperiences{ get; set; } = new List<WorkExperienceDTO>();

       
    }
}
