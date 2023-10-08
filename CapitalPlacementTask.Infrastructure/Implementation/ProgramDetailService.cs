using AutoMapper.Configuration;
using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using CapitalPlacementTask.Domain.Entities;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container = Microsoft.Azure.Cosmos.Container;

namespace CapitalPlacementTask.Infrastructure.Implementation
{
    public class ProgramDetailService: IProgramDetailService
    {
        private readonly Container _programDetailContainer;

        public ProgramDetailService(CosmosClient cosmosClient, IConfiguration configuration)
        {
            var databaseName = configuration["CosmosDbSettings:DatabaseName"];
            _programDetailContainer = cosmosClient.GetContainer(databaseName, "ProgramDetails");
        }


        public async Task<BaseResponse<bool>> CreateProgramDetail(CreateProgramDetailDTO model)
        {
            var program = new ProgramDetail
            {
                Id = Guid.NewGuid(),
                ProgramTitle = model.ProgramTitle,
                Summary = model.Summary,
                ProgramDescription = model.ProgramDescription,
                RequiredSkills = model.Skills,
                Benefits = model.Benefits,
                Criteria = model.Criteria,
                ProgramType = model.ProgramType,
                ProgramStart = model.ProgramStart,
                ApplicationOpen = model.ApplicationOpen,
                Duration = model.Duration,
                ProgramLocation = model.ProgramLocation,
                MinQualification = model.MinQualification,

            };

            await _programDetailContainer.CreateItemAsync(program);
            return new BaseResponse<bool>(true, "Successfully Created a program details");
        }


        public async Task<BaseResponse<ProgramDetailDTO>> GetProgramDetail(Guid id)
        {
            

            var programDetail = await _programDetailContainer.ReadItemAsync<ProgramDetail>(id.ToString(), new PartitionKey(id.ToString()));

            if (programDetail.Resource is null)
            {
                return new BaseResponse<ProgramDetailDTO>("Program Id is invalid");
            }

            ProgramDetailDTO programDetailDTO = programDetail.Resource;
            return new BaseResponse<ProgramDetailDTO>(programDetailDTO);

        }

        public async Task<BaseResponse<ProgramDetailDTO>> UpdateProgram(Guid id, ProgramDetailDTO model)
        {         

            var programDetail = await _programDetailContainer.ReadItemAsync<ProgramDetail>(id.ToString(), new PartitionKey(id.ToString()));

            if (programDetail.Resource is null)
            {
                if (programDetail.Resource is null)
                {
                    return new BaseResponse<ProgramDetailDTO>("Program Id is invalid");
                }
            }

            var updateForm = new ProgramDetail
            {
                ProgramTitle = model.ProgramTitle,
                Summary = model.Summary,
                ProgramDescription = model.ProgramDescription,
                RequiredSkills = model.Skills,
                Benefits = model.Benefits,
                Criteria = model.Criteria,
                ProgramType = model.ProgramType,
                ProgramStart = model.ProgramStart,
                ApplicationOpen = model.ApplicationOpen,
                Duration = model.Duration,
                ProgramLocation = model.ProgramLocation,
                MinQualification = model.MinQualification,
            };

            updateForm.Id = programDetail.Resource.Id;

            await _programDetailContainer.ReplaceItemAsync(updateForm, id.ToString());

            return new BaseResponse<ProgramDetailDTO>(updateForm, "Form update successful");
        }
    }
}
