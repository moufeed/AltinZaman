using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamTechSDK.Common.Models.ContentItem;
using TamTechSDK.Common.Providers.Requests.Models;
using TamTechSDK.Common.Services.ContentService.Posts.Models;

namespace AltinZaman.DirectBackendServices.ContentServices.Posts
{
    public class DirectPostsService : BaseDirectService, TamTechSDK.Common.Services.ContentService.Posts.IPostsService
    {
        public Task<IRequestProviderResult<Guid>> CreateAsync(CreatePostDto model)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<bool>> EditAsync(UpdatePostDto model)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<List<PostDto>>> GetAllAsync(string lang)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<PostDto>> GetByIdAsync(Guid id, string lang)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<PostDto>> GetPublicBySlugAsync(string slug)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<List<PostDto>>> GetPublicListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<List<PostDto>>> GetPublicListAsync(int takeitems)
        {
            throw new NotImplementedException();
        }

        public Task<IRequestProviderResult<bool>> PublishAsync(PublishDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
