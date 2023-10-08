using AutoMapper;
using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Domain.Entities;
using CapitalPlacementTask.Infrastructure.Implementation;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profile = AutoMapper.Profile;

namespace CapitalPlacementTask.Infrastructure.MappingProfile
{
    public class ApplicationFormProfile : Profile
    {
        public ApplicationFormProfile()
        {
            //source => Target

            CreateMap<ApplicationFormDTO, ApplicationForm>();
            CreateMap<PersonalInformationDTO, PersonalInformation>();
            CreateMap<EducationDTO, Education>();
            CreateMap<ProfileDTO, CapitalPlacementTask.Domain.Entities.Profile>();
            CreateMap<ApplicationForm, ApplicationFormDTO>();
            CreateMap<CreateApplicationFormDTO, ApplicationFormDTO>();
            CreateMap<QuestionDTO, Question>();
            CreateMap<MultipleChoiceDTO, MultipleChoice>();
            CreateMap<ParagraphDTO, Paragraph>();
            CreateMap<DropdownDTO, Dropdown>();
            CreateMap<YesOrNoDTO, YesOrNo>();
            CreateMap<WorkExperienceDTO,WorkExperience>();

           // CreateMap<ItemResponse<ApplicationForm>, ApplicationFormDTO>();
        }
    }
}
