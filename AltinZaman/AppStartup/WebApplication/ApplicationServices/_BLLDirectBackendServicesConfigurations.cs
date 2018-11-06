using Microsoft.Extensions.DependencyInjection;
using TamTechSDK.Common.Services.ContentService;
using TamTechSDK.Common.Services.ContentService.Brands;
using TamTechSDK.Common.Services.ContentService.Categories;
using TamTechSDK.Common.Services.ContentService.Galleries;
using TamTechSDK.Common.Services.ContentService.Menus;
using TamTechSDK.Common.Services.ContentService.Pages;
using TamTechSDK.Common.Services.ContentService.Products;
using TamTechSDK.Common.Services.ContentService.Reviews;
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

            services.AddScoped<IMenusServices, Web.DirectBackendServices.ContentServices.Menus.DirectMenusServices>();
            services.AddTransient<ICategoriesServices, Web.DirectBackendServices.ContentServices.Categories.DirectCategoriesServices>();
            services.AddTransient<IProductsManagerService, Web.DirectBackendServices.ContentServices.Products.DirectProductsManagerService>();
            // services.AddTransient<IProductsService, Web.DirectBackendServices.ContentServices.Products.DirectProductsService> ();
            services.AddTransient<IBrandsServices, Web.DirectBackendServices.ContentServices.Brands.DirectBrandsServices>();
            services.AddTransient<IPageService, Web.DirectBackendServices.ContentServices.Pages.DirectPagesService>();
            services.AddTransient<IReviewsServices, Web.DirectBackendServices.ContentServices.Reviews.DirectReviewsServices>();
            services.AddTransient<IServicesService, Web.DirectBackendServices.ContentServices.Services.DirectServicesService>();
            services.AddTransient<IContentServices, Web.DirectBackendServices.ContentServices.Content.DirectContentService>();
            services.AddTransient<ISlidersServices, Web.DirectBackendServices.ContentServices.Sliders.DirectSlidersService>();
            services.AddTransient<IGalleriesService, Web.DirectBackendServices.ContentServices.Galleries.DirectGalleriesService>();

            #endregion

            #region Upload Service 

            services.AddTransient<IUploadService, Web.DirectBackendServices.UploadService.DirectFileStorageService>();

            #endregion

            #region Email Service 

            services.AddTransient<IEmailSenderService, AltinZaman.DirectBackendServices.EmailServices.DirectEmailServices>();

            #endregion


            #region Identity Service 

            services.AddTransient<IAuthService, AltinZaman.DirectBackendServices.IdentityService.DirectAuthService>();
            services.AddTransient<IUsersManagerService, Web.DirectBackendServices.IdentityService.UsersMenager.DirectUserMenagerServices>();
            services.AddTransient<IRolesService, AltinZaman.DirectBackendServices.IdentityService.RolesService.DirectRolesService>();


            #endregion

        }
    }
}
