using AutoMapper;
using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using CapitalPlacementTask.Domain.Entities;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Profile = CapitalPlacementTask.Domain.Entities.Profile;

namespace CapitalPlacementTask.Infrastructure.Implementation
{
    internal class ApplicationFormService: IApplicationService
    {
        private readonly IConfiguration _configuration;
        private readonly Container _applicationFormContainer;
        private readonly Container _programDetailContainer;
        private readonly IMapper _mapper;


        public ApplicationFormService(CosmosClient cosmosClient, IConfiguration configuration, IMapper mapper)
        {
            var databaseName = configuration["CosmosDbSettings:DatabaseName"];
            _configuration = configuration;
            _applicationFormContainer = cosmosClient.GetContainer(databaseName, "ApplicationForms");
            _programDetailContainer = cosmosClient.GetContainer(databaseName, "ProgramDetails");
            _mapper = mapper;
        }

 

        public async Task<BaseResponse<ApplicationFormDTO>> GetApplicationForm(Guid id)
        {
            var resultModel = new BaseResponse<ApplicationFormDTO>();

            var applicationForm = await _applicationFormContainer.ReadItemAsync<ApplicationForm>(id.ToString(), new PartitionKey(id.ToString()));

            if (applicationForm.Resource is null)
            {
                return new BaseResponse<ApplicationFormDTO>("application form doesn't exists");
                return resultModel;
            }
            var form = applicationForm.Resource;

            var ApplicationForm = _mapper.Map<ApplicationFormDTO>(applicationForm.Resource);

            return new BaseResponse<ApplicationFormDTO>(ApplicationForm, "success");
        }

        
        public async Task<BaseResponse<bool>> UpdateApplicationForm(ApplicationFormDTO model, Guid id)
        {
            var resultModel = new BaseResponse<bool>();

            var applicationForm = await _applicationFormContainer.ReadItemAsync<ApplicationForm>(id.ToString(), new PartitionKey(id.ToString()));

            if (applicationForm.Resource is null)
            {
                return new BaseResponse<bool>("application form doesn't exists");
               
            }
            var updatedForm = _mapper.Map<ApplicationForm>(model);
            
            updatedForm.Id = applicationForm.Resource.Id;
            try
            {
                await _programDetailContainer.ReplaceItemAsync(updatedForm,  id.ToString());
            }catch(
            Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }
            return new BaseResponse<bool>( "Form update successful");

        }
        
    }
}
