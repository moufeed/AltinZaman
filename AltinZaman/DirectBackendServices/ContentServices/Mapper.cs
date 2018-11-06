using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltinZaman.DirectBackendServices.ContentServices
{
    public static class Mapper
    {

        public static TamTechBackendSDK.ContentService.Services.Common.Dtos.PublishDto MapToBackend(this TamTechSDK.Common.Models.ContentItem.PublishDTO frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Common.Dtos.PublishDto
            {
                Id = frontend.Id,
                Lang = frontend.Lang,

            };
        }
    }
}
