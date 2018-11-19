using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TamTechSDK.Common.Providers.Requests.Models;
using TamTechSDK.Common.Services.ContentService.Galleries;
using TamTechSDK.Common.Services.ContentService.Galleries.Models;
using System.Linq;
using TamTech.Web.DirectBackendServices.ContentServices.Galleries.Mapper;
using TamTechSDK.Common.Models.ContentItem;

namespace TamTech.Web.DirectBackendServices.ContentServices.Galleries
{
    public class DirectGalleriesService : BaseDirectService, IGalleriesService
    {

        #region prop
        TamTechBackendSDK.ContentService.Services.Galleries.IGalleryService _galleriesService;

       
        #endregion


        public DirectGalleriesService(TamTechBackendSDK.ContentService.Services.Galleries.IGalleryService galleriesService)
        {
            _galleriesService = galleriesService;
        }

        #region puplic

        public async Task<IRequestProviderResult<List<GalleryLiteDto>>> GetPublicListAsync(string lang)
        {

            dynamic result = await _galleriesService.GetPublicDynamicListAsync();
            List<GalleryLiteDto> galleries = new List<GalleryLiteDto>();
            if (result != null)
            {
                galleries = DeserializeFromObject<List<GalleryLiteDto>>(result);
            }
            return ReturnResult(galleries);
        }

        public async Task<IRequestProviderResult<GalleryDto>> GetPublicBySlugAsync(string slug, string lang)
        {
            dynamic result = await _galleriesService.GetPublicDynamicBySlugAsync(slug);

            GalleryDto gallery = new GalleryDto();

            if (result != null)
            {
                gallery = DeserializeFromObject<GalleryDto>(result);
            }
            return ReturnResult(gallery);

        }

        #endregion

        public async Task<IRequestProviderResult<List<GalleryLiteDto>>> GetAllAsync(string lang)
        {

            var result = (await _galleriesService.GetAllExceptSoftDeletedAsync(lang));

            List<GalleryLiteDto> Galleries = result != null ? result.Select(m => m.ToFrontend_GalleryLiteDto()).ToList() : new List<GalleryLiteDto>();

            return ReturnResult(Galleries);

        }

        #region Gallery

        //-------- Create Gallery -------
        public async Task<IRequestProviderResult<Guid>> CreateAsync(CreateGalleryDto Gallery)
        {
            var result = await _galleriesService.CreateAsync(Gallery.ToBackend_CreateGalleryDto());
            return MapRequestProviderResult(result);
        }


        

        public async Task<IRequestProviderResult<GalleryDto>> GetByIdAsync(Guid id, string lang)
        {

            var result = await _galleriesService.GetByIdExceptSoftDeletedAsync(id, lang);
            GalleryDto frontendDto = result.MapToFrontEndGalleryDto();
            return ReturnResult(frontendDto);

        }

        public async Task<IRequestProviderResult<bool>> EditAsync(UpdateGalleryDto Gallery)
        {
            var result =await  _galleriesService.EditAsync(Gallery.MapTobackendUpdateGalleryDto());

            return MapRequestProviderResult(result);
        }

       

        public async Task<IRequestProviderResult<bool>> PublishAsync(PublishDTO data)
        {
            var result = await _galleriesService.PublishAsync(data.MapToBackend());
            return MapRequestProviderResult(result);

        }

        public async Task<IRequestProviderResult<bool>> DeleteAsync(Guid id)
        {
            var result = await _galleriesService.SoftDeleteAsync(id);
            return MapRequestProviderResult(result);
        }

        #endregion


        #region Gallery item
        public async Task<IRequestProviderResult<Guid>> CreateGalleryItemAsync(CreateGalleryItemDto Item)
        {
            var result = await _galleriesService.CreateGalleryItemAsync(Item.MapToBackendCreateGalleryItemDto());

            return MapRequestProviderResult(result);

        }


        public async Task<IRequestProviderResult<GalleryItemDto>> GetGalleryItemByIdAsync(GalleryItemKeysDto model, string lang)
        {
            var result = await _galleriesService.GetGalleryItemByIdAsync(model.MapToBackendGalleryItemKeysDto() ,lang);
            return ReturnResult(result.MapToFrontEndGalleryItemDto());
        
        }


        public async Task<IRequestProviderResult<bool>> EditGalleryItemAsync(UpdateGalleryItemDto items)
        {
            var result = await _galleriesService.EditGalleryItemAsync(items.MapToBackendUpdateGalleryItemDto());
            return MapRequestProviderResult(result);


        }

        

        public async Task<IRequestProviderResult<bool>> PublishGalleryItemByIdAsync(GalleryItemKeysDto dto)
        {
            var result = await _galleriesService.PublishGalleryItemAsync(dto.MapToBackendDto());

            return MapRequestProviderResult(result);
        }

        public async Task<IRequestProviderResult<bool>> DeleteGalleryItemByIdAsync(GalleryItemKeysDto dto)
        {
            var result = await _galleriesService.HardDeleteGalleryItemAsync(dto.MapToBackendGalleryItemKeysDto());

            return MapRequestProviderResult(result);

        }

        public async  Task<IRequestProviderResult<bool>> PublishGalleryItemsAsync(PublishDTO dto)
        {
            var result = await _galleriesService.PublishAllGalleryItemsAsync(dto.MapToBackend());
             
            return MapRequestProviderResult(result);
        }

        public async Task<IRequestProviderResult<Dictionary<Guid,string>>> CreateListGalleryItemsAsync(CreateListGalleryItemsDto data)
        {

            var result = await _galleriesService.CreateListGalleryItemsAsync(data.MapToBackendListOitems());

            return MapRequestProviderResult(result);

        }

        #endregion

    }
}
