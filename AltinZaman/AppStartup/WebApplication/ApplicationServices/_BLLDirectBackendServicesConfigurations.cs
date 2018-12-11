using Microsoft.Extensions.DependencyInjection;
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

            services.AddScoped<IMenusServices, AltinZaman.DirectBackendServices.ContentServices.Menus.DirectMenusServices>();
           // services.AddTransient<ICategoriesServices, AltinZaman.DirectBackendServices.ContentServices.Categories.DirectCategoriesServices> ();
         //   services.AddTransient<IProductsManagerService, AltinZaman.DirectBackendServices.ContentServices.Products.DirectProductsManagerService>();
            // services.AddTransient<IProductsService, Web.DirectBackendServices.ContentServices.Products.DirectProductsService> ();
         //  services.AddTransient<IBrandsServices, AltinZaman.DirectBackendServices.ContentServices.Brands.DirectBrandsServices>();
            services.AddTransient<IPageService, AltinZaman.DirectBackendServices.ContentServices.Pages.DirectPagesService>();
         //   services.AddTransient<IReviewsServices, AltinZaman.DirectBackendServices.ContentServices.Reviews.DirectReviewsServices>();
            services.AddTransient<IServicesService, AltinZaman.DirectBackendServices.ContentServices.Services.DirectServicesService>();
            services.AddTransient<IContentServices, AltinZaman.DirectBackendServices.ContentServices.Content.DirectContentService>();
             services.AddTransient<ISlidersServices, AltinZaman.DirectBackendServices.ContentServices.Sliders.DirectSlidersService>();
            services.AddTransient<IGalleriesService, AltinZaman.DirectBackendServices.ContentServices.Galleries.DirectGalleriesService>();
         //   services.AddTransient<IPostsService, AltinZaman.DirectBackendServices.ContentServices.Posts.DirectPostsService>();
        //    services.AddTransient<ISectionsService, AltinZaman.DirectBackendServices.ContentServices.Sections.DirectSectionsService> ();
        services.AddTransient<TamTechSDK.Common.Services.ContentService.Request.IRequestService, AltinZaman.DirectBackendServices.ContentServices.Request.DirectRequestService>();
            services.AddTransient<TamTechSDK.Common.Services.ContentService.Status.IStatusService , AltinZaman.DirectBackendServices.ContentServices.Status.DirectSatusService>();
            services.AddTransient<TamTechSDK.Common.Services.ContentService.City.ICityService, AltinZaman.DirectBackendServices.ContentServices.City.DirectCityService>();
            #endregion

            #region Upload Service 

            services.AddTransient<IUploadService, AltinZaman.DirectBackendServices.UploadService.DirectFileStorageService>();

            #endregion

            #region Email Service 

            services.AddTransient<IEmailSenderService, AltinZaman.DirectBackendServices.EmailServices.DirectEmailServices>();

            #endregion
             
            #region Identity Service 

            services.AddTransient<IAuthService, AltinZaman.DirectBackendServices.IdentityService.DirectAuthService>();
            services.AddTransient<IUsersManagerService, AltinZaman.DirectBackendServices.IdentityService.UsersMenager.DirectUserMenagerServices>();
            services.AddTransient<IRolesService, AltinZaman.DirectBackendServices.IdentityService.RolesService.DirectRolesService>();


            #endregion

             
        }
    }
}
