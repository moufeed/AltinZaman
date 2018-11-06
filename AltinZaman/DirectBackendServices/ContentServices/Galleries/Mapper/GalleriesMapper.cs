using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltinZaman.DirectBackendServices.ContentServices.Galleries.Mapper
{
    public static class GalleriesMapper
    {

        #region gallery
        public static TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryLiteDto ToFrontend_GalleryLiteDto(this TamTechBackendSDK.ContentService.Services.Galleries.Dtos.GalleryLiteDto backend)
        {
            return new TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryLiteDto
            {

                Lang = backend.Lang,
                Id = backend.Id,
                Title = backend.Title,
                Slug = backend.Slug,
                MainImage = backend.MainImage,
                Summary = backend.Summary,
                Published = backend.Published,
                DisplayOrder = backend.DisplayOrder,
                ModifiedDate = backend.ModifiedDate,
                CreatedDate = backend.CreatedDate,
                Tags = backend.Tags,
                MetaDescription = backend.MetaDescription,
                SEOMarkup = backend.SEOMarkup,
                Locked = backend.Locked,
                ItemsCount = backend.ItemsCount,
                PublishedDate = backend.PublishedDate,
                AuthorName = backend.AuthorName
            };
        }


        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.CreateGalleryDto ToBackend_CreateGalleryDto(this TamTechSDK.Common.Services.ContentService.Galleries.Models.CreateGalleryDto item)
        {
            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.CreateGalleryDto
            {
                Lang = item.Lang,
                Title = item.Title,
                Slug = item.Slug,
                MainImage = item.MainImage,
                Summary = item.Summary,
                DisplayOrder = item.DisplayOrder,
                Tags = item.Tags,
                Section = item.Section,
                MetaDescription = item.MetaDescription,
                AuthorName = item.AuthorName
            };
        }

        public static TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryDto MapToFrontEndGalleryDto(this TamTechBackendSDK.ContentService.Services.Galleries.Dtos.GalleryDto item)
        {
            return new TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryDto
            {
                Id = item.Id,
                Lang = item.Lang,
                Title = item.Title,
                Slug = item.Slug,
                MainImage = item.MainImage,
                Summary = item.Summary,
                DisplayOrder = item.DisplayOrder,
                Tags = item.Tags,
                Section = item.Section,
                Published = item.Published,
                CreatedDate = item.CreatedDate,
                MetaDescription = item.MetaDescription,
                Items = item.Items != null ? item.Items.Select(m => m.MapToFrontEndGalleryItemDto()).ToList() : new List<TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryItemDto>(),
                SEOMarkup = item.SEOMarkup,
                ModifiedDate = item.ModifiedDate,
                Locked = item.Locked,
                PublishedDate = item.PublishedDate,
                AuthorName = item.AuthorName
            };
        }


        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.UpdateGalleryDto MapTobackendUpdateGalleryDto(this TamTechSDK.Common.Services.ContentService.Galleries.Models.UpdateGalleryDto item)
        {
            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.UpdateGalleryDto
            {
                Id = item.Id,
                Lang = item.Lang,
                Title = item.Title,
                Slug = item.Slug,
                MainImage = item.MainImage,
                Summary = item.Summary,
                DisplayOrder = item.DisplayOrder,
                Tags = item.Tags,
                Section = item.Section,
                MetaDescription = item.MetaDescription,
                SEOMarkup = item.SEOMarkup,
                AuthorName = item.AuthorName
            };
        }
        #endregion


        #region gallery item 

        //  
        public static TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryItemDto MapToFrontEndGalleryItemDto(this TamTechBackendSDK.ContentService.Services.Galleries.Dtos.GalleryItemDto item)
        {
            return new TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryItemDto
            {
                Lang = item.Lang,
                Title = item.Title,
                Slug = item.Slug,
                MainImage = item.MainImage,
                Summary = item.Summary,
                DisplayOrder = item.DisplayOrder,
                Id = item.Id,
                Published = item.Published,
                CreatedDate = item.CreatedDate,
                MetaDescription = item.MetaDescription,
                Locked = item.Locked

            };
        }

        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.CreateGalleryItemDto MapToBackendCreateGalleryItemDto(this TamTechSDK.Common.Services.ContentService.Galleries.Models.CreateGalleryItemDto item)
        {

            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.CreateGalleryItemDto
            {
                Lang = item.Lang,
                Title = item.Title,
                Slug = item.Slug,
                MainImage = item.MainImage,
                Summary = item.Summary,
                DisplayOrder = item.DisplayOrder,
                GalleryId = item.GalleryId,
                Tags = item.Tags,
                MetaDescription = item.MetaDescription,
            };
        }


        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.UpdateGalleryItemDto MapToBackendUpdateGalleryItemDto(this TamTechSDK.Common.Services.ContentService.Galleries.Models.UpdateGalleryItemDto item)
        {

            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.UpdateGalleryItemDto
            {
                Lang = item.Lang,
                Title = item.Title,
                Slug = item.Slug,
                MainImage = item.MainImage,
                Summary = item.Summary,
                DisplayOrder = item.DisplayOrder,
                GalleryId = item.GalleryId,
                Id = item.Id,
                Tags = item.Tags,
                MetaDescription = item.MetaDescription,
            };
        }


        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.GalleryItemKeysDto MapToBackendGalleryItemKeysDto(this TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryItemKeysDto item)
        {
            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.GalleryItemKeysDto
            {

                Id = item.Id,
                GalleryId = item.GalleryId,
            };
        }

        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.PublishGalleryItemsDto MapToBackendDto(this TamTechSDK.Common.Services.ContentService.Galleries.Models.GalleryItemKeysDto item)
        {
            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.PublishGalleryItemsDto
            {

                Id = item.Id,
                GalleryId = item.GalleryId,
                Lang = item.Lang,
            };
        }

        public static TamTechBackendSDK.ContentService.Services.Galleries.Dtos.CreateListGalleryItemsDto MapToBackendListOitems(this TamTechSDK.Common.Services.ContentService.Galleries.Models.CreateListGalleryItemsDto item)
        {
            return new TamTechBackendSDK.ContentService.Services.Galleries.Dtos.CreateListGalleryItemsDto
            {
                GalleryId = item.GalleryId,
                Lang = item.Lang,
                MainImages = item.MainImages
            };
        }

        #endregion



    }
}




/* 
   

         

     

     

        public bool Published { get; set; }

        public DateTime CreatedDate { get; set; }
     */
