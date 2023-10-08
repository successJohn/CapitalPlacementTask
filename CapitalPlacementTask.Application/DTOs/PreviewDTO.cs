using CapitalPlacementTask.Domain.Entities;
using CapitalPlacementTask.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Application.DTOs
{
    public class PreviewDTO
    {
        public Guid Id { get; set; }
        public string ProgramTitle { get; set; }

        public string Summary { get; set; }

        public string ProgramDescription { get; set; }
        public string Skills { get; set; }
        public string Benefits { get; set; }
        public string Criteria { get; set; }

       
        public ProgramType ProgramType { get; set; }

        public DateTime ProgramStart { get; set; }


        public DateTime ApplicationOpen { get; set; }

        public DateTime ApplicationClose { get; set; }

        public string Duration { get; set; }

        public string ProgramLocation { get; set; }

        public Qualification MinQualification { get; set; }

        public DateTime CreatedOn { get; set; }


        public static implicit operator PreviewDTO(ProgramDetail model)
        {
            return model is null ? null : new PreviewDTO
            {
                Id = model.Id,
                ProgramTitle = model.ProgramTitle,
                Summary = model.Summary,
                ProgramDescription = model.ProgramDescription,
                Skills = model.RequiredSkills,
                Benefits = model.Benefits,
                Criteria = model.Criteria,
                ProgramType = model.ProgramType,
                ProgramStart = model.ProgramStart,
                ApplicationOpen = model.ApplicationOpen,
                Duration = model.Duration,
                ProgramLocation = model.ProgramLocation,
                MinQualification = model.MinQualification,
                CreatedOn = model.CreatedOn,
            };
        }
    }
}
