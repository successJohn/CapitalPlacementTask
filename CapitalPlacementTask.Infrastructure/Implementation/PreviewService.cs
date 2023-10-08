using CapitalPlacementTask.Application.DTOs;
using CapitalPlacementTask.Application.Interfaces;
using CapitalPlacementTask.Application.Utilities;
using CapitalPlacementTask.Domain.Entities;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Infrastructure.Implementation
{
    public class PreviewService: IPreviewService
    {

        private readonly IConfiguration _configuration;
        private readonly Container _programContainer;
       

        public PreviewService(CosmosClient cosmosClient, IConfiguration configuration)
        {
            var databaseName = configuration["CosmosDbSettings:DatabaseName"];
            _configuration = configuration;
            _programContainer = cosmosClient.GetContainer(databaseName, "ProgramDetail");
        }
        public async Task<BaseResponse<PreviewDTO>> GetPreview(Guid programId)
        {
            var programDetail = await _programContainer.ReadItemAsync<PreviewDTO>(programId.ToString(), new PartitionKey(programId.ToString()));

            if (programDetail.Resource is null)
            {
                return new BaseResponse<PreviewDTO>("Program Id is invalid");
            }

            PreviewDTO previewDetailDTO = programDetail.Resource;
            return new BaseResponse<PreviewDTO>(previewDetailDTO);
        }

    }
}
