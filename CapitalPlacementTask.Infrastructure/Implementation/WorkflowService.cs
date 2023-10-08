using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.DTOs.FormDTOs;
using CapitalPlacementTask.Application.DTOs.WorkflowDTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using CapitalPlacementTask.Domain.Entities;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Infrastructure.Implementation
{
    public class WorkflowService: IWorkflowService
    {
        
        private readonly Container _workflowContainer;

        public WorkflowService(CosmosClient cosmosClient, IConfiguration configuration)
        {
            var databaseName = configuration["CosmosDbSettings:DatabaseName"];
            _workflowContainer = cosmosClient.GetContainer(databaseName, "Workflow");
        }

        public async Task<BaseResponse<WorkflowDTO>> GetWorkflowByIdAsync(Guid id)
        {

            var resultModel = new BaseResponse<ApplicationFormDTO>();

            var Workflow = await _workflowContainer.ReadItemAsync<Workflow>(id.ToString(), new PartitionKey(id.ToString()));

            if (Workflow.Resource is null)
            {
                return new BaseResponse<WorkflowDTO>("workflow doesn't exists");
               
            }

            WorkflowDTO workflow = Workflow.Resource;
            return new BaseResponse<WorkflowDTO>(workflow);
        }

        public async Task<BaseResponse<WorkflowDTO>> UpdateWorkflowAsync(Guid id , WorkflowDTO model)
        {
             var Workflow = await _workflowContainer.ReadItemAsync<Workflow>(id.ToString(), new PartitionKey(id.ToString()));

            if (Workflow.Resource is null)
            {
                return new BaseResponse<WorkflowDTO>("workflow doesn't exists");
               
            }
            var updateWorkflow = new Workflow()
            {
                StageName = model.StageName,
                ProgramId = model.ProgramId,
                StageType = model.StageType
            };


            await _workflowContainer.ReplaceItemAsync(updateWorkflow, Workflow.Resource.Id.ToString());

            return new BaseResponse<WorkflowDTO>(model, "workflow update successful");
        }
        
    }
}
