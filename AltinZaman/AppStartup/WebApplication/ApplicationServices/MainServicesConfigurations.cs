using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AltinZaman.AppStartup.DirectBackendServices.ContentService.ApplicationServices;
using AltinZaman.AppStartup.DirectBackendServices.EmailService;
using AltinZaman.AppStartup.DirectBackEndServices.FilesServices;
using AltinZaman.AppStartup.MicroServices.ApplicationServices;
using AltinZaman.Services.Configurations.AppSetting.Constants;

namespace AltinZaman.AppStartup.WebApplication.ApplicationServices
{
    public static class MainServicesConfigurations
    {
        public static void AddMainServicesConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            bool useMicroServices = configuration.GetSection(AppSettings.WebApplicationSettings)
                                                 .GetSection(AppSettings.WebApplication_UseMicroServices).Get<bool>();
            if (useMicroServices)
            {
                services.MicroServices_AddUrlBackendSettingsServicesConfigurations(configuration);

                services.MicroServices_AddProvidersServicesConfigurations();
            }
            else
            {
                services.DirectBackendServices_ContentService_AddCommonHelpersServicesConfigurations(configuration);

                services.DirectBackendServices_ContentService_AddContentBLLServicesConfigurations();

                services.DirectBackendServices_ContentService_AddRepositoriesConfigurations(configuration);

                services.DirectBackendServices_ContentService_AddFluentValidationConfigurations();

                services.DirectBackendServices_AddFilesServicesConfigurationsConfigurations(configuration);

                services.DirectBackendServices_AddEmailServicesConfigurations(configuration);
            }
        }
    }
}
