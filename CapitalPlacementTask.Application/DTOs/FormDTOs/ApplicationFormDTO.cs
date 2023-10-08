using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapitalPlacementTask.Domain.Entities;

namespace CapitalPlacementTask.Application.DTOs.FormDTOs
{
    public class ApplicationFormDTO
    {
        public Guid ProgramDetailsId { get; set; }

        public PersonalInformationDTO PersonalInformation { get; set; }
        public ProfileDTO Profile { get; set; }
        

        
    }
}
