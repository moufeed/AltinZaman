using System.Collections.Generic;
using System.Linq;
using TamTechSDK.Common.Services.ContentService.Sliders.Models;

namespace AltinZaman.DirectBackendServices.ContentServices.Sliders.Mapper
{
    public static class SliderMapper
    {
        public static SliderDto MapToFrontendSliderDto(this TamTechBackendSDK.ContentService.Services.Sliders.Dtos.SliderDto backend)
        {
            return new SliderDto
            {
                Id = backend.Id,
                Lang = backend.Lang,
                Title = backend.Title,
                Key = backend.Key,
                //  Slug = backend.Slug,
                Summary = backend.Summary,
                //  Position = backend.Position,
                //  DisplayOrder = backend.DisplayOrder,
                CreatedDate = backend.CreatedDate,
                ModifiedDate = backend.ModifiedDate,
                Published = backend.Published,
                // PublishedDate =backend.PublishedDate,
                // Locked = backend.Locked,
                Items = backend.Items != null ? backend.Items.Where(item => !item.Deleted)
                                                                     .Select(p => p.MapToFrontendDto())
                                                                     .OrderBy(m => m.DisplayOrder)
                                                                     .ToList() : new List<SliderItemDto>()
            };
        }

        public static TamTechBackendSDK.ContentService.Services.Sliders.Dtos.CreateSliderDto MapToBackendDto(this CreateSliderDto frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Sliders.Dtos.CreateSliderDto
            {
                Lang = frontend.Lang,
                Title = frontend.Title,
                Key = frontend.Key,
                // Slug = frontend.Slug,
                Summary = frontend.Summary,
                // Position = frontend.Position,
            };
        }

        public static TamTechBackendSDK.ContentService.Services.Sliders.Dtos.UpdateSliderDto MapToBackendUpdateSliderDto(this UpdateSliderDto frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Sliders.Dtos.UpdateSliderDto
            {
                Id = frontend.Id,
                Lang = frontend.Lang,
                Title = frontend.Title,
                Key = frontend.Key,
                //  Slug = frontend.Slug,
                Summary = frontend.Summary,
                //  Position = frontend.Position

            };
        }

        public static TamTechBackendSDK.ContentService.Services.Sliders.Dtos.SliderItemKeysDto MapToBackendDto(this SliderItemKeysDto frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Sliders.Dtos.SliderItemKeysDto
            {
                SliderId = frontend.SliderId,
                Id = frontend.Id,
            };
        }

        public static TamTechBackendSDK.ContentService.Services.Sliders.Dtos.PublishSliderItemDto MapToBackendPublishDto(this SliderItemKeysDto frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Sliders.Dtos.PublishSliderItemDto
            {
                SliderId = frontend.SliderId,
                Id = frontend.Id,
                Lang = frontend.Lang,
            };
        }

        public static SliderItemDto MapToFrontendDto(this TamTechBackendSDK.ContentService.Services.Sliders.Dtos.SliderItemDto backend)
        {
            return new SliderItemDto
            {

                Id = backend.Id,
                //    SliderId = backend.SliderId,
                Lang = backend.Lang,
                Title = backend.Title,
                MainImage = backend.Image,
                Url = backend.Url,
                UrlTarget = backend.UrlTarget,
                Published = backend.Published,
                DisplayOrder = backend.DisplayOrder,
                Summary = backend.Summary,
                CreatedDate = backend.CreatedDate,
                //Locked =backend.Locked

            };
        }

        public static TamTechBackendSDK.ContentService.Services.Sliders.Dtos.CreateSliderItemDto MapToBackendDto(this CreateSliderItemDto frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Sliders.Dtos.CreateSliderItemDto
            {

                Lang = frontend.Lang,
                SliderId = frontend.SliderId,
                Title = frontend.Title,
                Image = frontend.MainImage,
                Url = frontend.Url,
                UrlTarget = frontend.UrlTarget,
                DisplayOrder = frontend.DisplayOrder,
                Summary = frontend.Summary

            };
        }
        //------------------------------------------------------------
        public static TamTechBackendSDK.ContentService.Services.Sliders.Dtos.UpdateSliderItemDto MapToBackendDto(this UpdateSliderItemDto frontend)
        {
            return new TamTechBackendSDK.ContentService.Services.Sliders.Dtos.UpdateSliderItemDto
            {
                Id = frontend.Id,
                Title = frontend.Title,
                Lang = frontend.Lang,
                SliderId = frontend.SliderId,
                Image = frontend.MainImage,
                Url = frontend.Url,
                UrlTarget = frontend.UrlTarget,
                DisplayOrder = frontend.DisplayOrder,
                Summary = frontend.Summary

            };
        }
    }
}
