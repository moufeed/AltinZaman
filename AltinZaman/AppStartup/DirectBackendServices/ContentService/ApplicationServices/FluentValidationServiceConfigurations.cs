using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using TamTechBackendSDK.ContentService.Dtos.Product;
using TamTechBackendSDK.ContentService.Validators;
using TamTechBackendSDK.ContentService.Services.Menus.Dtos;
using TamTechBackendSDK.ContentService.Services.Pages.Dtos;
using TamTechBackendSDK.ContentService.Services.Dtos;
using TamTechBackendSDK.ContentService.Services.Galleries.Dtos;

namespace AltinZaman.AppStartup.DirectBackendServices.ContentService.ApplicationServices
{
    public static class FluentValidationServiceConfigurations
    {
        public static void DirectBackendServices_ContentService_AddFluentValidationConfigurations(this IServiceCollection services)
        {

            #region Product Module

            services.AddTransient<IValidator<CreateProductDto>, CreateProductDtoValidator>();

            services.AddTransient<IValidator<UpdateProductDto>, UpdateProductDtoValidator>();

            services.AddTransient<IValidator<ProductDto>, ProductDtoValidator>();

            #endregion



            #region Page Module

            services.AddTransient<IValidator<CreateHtmlPageDto>, CreateHtmlPageDtoValidator>();

            services.AddTransient<IValidator<CreateSectionsPageDto>, CreateSectionsPageDtoValidator>();

            services.AddTransient<IValidator<UpdateHtmlPageDto>, UpdateHtmlPageDtoValidator>();

            services.AddTransient<IValidator<UpdateSectionsPageDto>, UpdateSectionsPageDtoValidator>();

            #endregion


            #region Menu Module

            services.AddTransient<IValidator<CreateMenuItemDto>, CreateMenuItemDtoValidator>();

            services.AddTransient<IValidator<UpdateMenuItemDto>, UpdateMenuItemDtoValidator>();

            services.AddTransient<IValidator<MenuItemKeysDto>, MenuItemKeysDtoValidator>();

            services.AddTransient<IValidator<CreateMenuDto>, CreateMenuDtoValidator>();

            #endregion


            #region Service Module

            services.AddTransient<IValidator<CreateServiceDto>, CreateServiceDtoValidator>();

            services.AddTransient<IValidator<UpdateServiceDto>, UpdateServiceDtoValidator>();

            #endregion


            #region Gallery Module

            services.AddTransient<IValidator<CreateGalleryDto>, CreateGalleryDtoValidator>();

            services.AddTransient<IValidator<UpdateGalleryDto>, UpdateGalleryDtoValidator>();

            #endregion

        }

    }
}
