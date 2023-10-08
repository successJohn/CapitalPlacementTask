using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs.FormDTOs
{
    public class CreateApplicationFormDTO
    {
        public Guid ProgramDetailId { get; set; }
        //public IFormFile CoverImage { get; set; }
        public PersonalInformationDTO CreatePersonalInformationDTO { get; set; } = new();
        public ProfileDTO CreateProfileDTO { get; set; } = new();
    }
}
