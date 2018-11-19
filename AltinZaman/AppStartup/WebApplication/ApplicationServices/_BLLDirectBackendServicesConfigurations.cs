using Microsoft.Extensions.DependencyInjection;
using TamTech.Web.DirectBackendServices.ContentServices.Categories;
using TamTechBackendSDK.ContentService.Services.Sections;
using TamTechSDK.Common.Services.ContentService;
using TamTechSDK.Common.Services.ContentService.Brands;
using TamTechSDK.Common.Services.ContentService.Categories;
using TamTechSDK.Common.Services.ContentService.Galleries;
using TamTechSDK.Common.Services.ContentService.Menus;
using TamTechSDK.Common.Services.ContentService.Pages;
using TamTechSDK.Common.Services.ContentService.Posts;
using TamTechSDK.Common.Services.ContentService.Products;
using TamTechSDK.Common.Services.ContentService.Reviews;
using TamTechSDK.Common.Services.ContentService.Sections;
using TamTechSDK.Common.Services.ContentService.Services;
using TamTechSDK.Common.Services.ContentService.Sliders;
using TamTechSDK.Common.Services.Email;
using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Common.Services.Upload;

namespace AltinZaman.AppStartup.WebApplication.ApplicationServices
{
    public static class BLLDirectBackendServicesConfigurations
    {
        public static void _AddBusinessLogicDirectBackendServicesConfigurations(this IServiceCollection services)
        {
            #region Contents Service 

            services.AddScoped<IMenusServices, TamTech.Web.DirectBackendServices.ContentServices.Menus.DirectMenusServices>();
            services.AddTransient<ICategoriesServices, DirectCategoriesServices>();
            services.AddTransient<IProductsManagerService, TamTech.Web.DirectBackendServices.ContentServices.Products.DirectProductsManagerService>();
            // services.AddTransient<IProductsService, Web.DirectBackendServices.ContentServices.Products.DirectProductsService> ();
            services.AddTransient<IBrandsServices, TamTech.Web.DirectBackendServices.ContentServices.Brands.DirectBrandsServices>();
            services.AddTransient<IPageService, TamTech.Web.DirectBackendServices.ContentServices.Pages.DirectPagesService>();
            services.AddTransient<IReviewsServices, TamTech.Web.DirectBackendServices.ContentServices.Reviews.DirectReviewsServices>();
            services.AddTransient<IServicesService, TamTech.Web.DirectBackendServices.ContentServices.Services.DirectServicesService>();
            services.AddTransient<IContentServices, TamTech.Web.DirectBackendServices.ContentServices.Content.DirectContentService>();
            services.AddTransient<ISlidersServices, TamTech.Web.DirectBackendServices.ContentServices.Sliders.DirectSlidersService>();
            services.AddTransient<IGalleriesService, TamTech.Web.DirectBackendServices.ContentServices.Galleries.DirectGalleriesService>();
            services.AddTransient<IPostsService, TamTech.Web.DirectBackendServices.ContentServices.Posts.DirectPostsService>();
            services.AddTransient<ISectionsService, TamTech.Web.DirectBackendServices.ContentServices.Sections.DirectSectionsService>();
            #endregion

            #region Upload Service 

            services.AddTransient<IUploadService, TamTech.Web.DirectBackendServices.UploadService.DirectFileStorageService>();

            #endregion

            #region Email Service 

            services.AddTransient<IEmailSenderService, TamTech.Web.DirectBackendServices.EmailServices.DirectEmailServices>();

            #endregion


            #region Identity Service 

            services.AddTransient<IAuthService, TamTech.Web.DirectBackendServices.IdentityService.DirectAuthService>();
            services.AddTransient<IUsersManagerService, TamTech.Web.DirectBackendServices.IdentityService.UsersMenager.DirectUserMenagerServices>();
            services.AddTransient<IRolesService, TamTech.Web.DirectBackendServices.IdentityService.RolesService.DirectRolesService>();


            #endregion

        }
    }
}
