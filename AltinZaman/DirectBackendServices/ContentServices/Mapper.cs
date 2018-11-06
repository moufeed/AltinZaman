using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltinZaman.DirectBackendServices.ContentServices
{
    public static class Mapper
    {

        public static TamTechBackendSDK.ContentService.Dtos.ContentItem.PublishDto MapToBackend(this TamTechSDK.Common.Models.ContentItem.PublishDTO frontend)
        {
            return new TamTechBackendSDK.ContentService.Dtos.ContentItem.PublishDto
            {
                Id = frontend.Id,
                Lang = frontend.Lang,

            };
        }
    }
}
