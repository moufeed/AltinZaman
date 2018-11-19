using Microsoft.Extensions.Configuration;
using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Common.Services.SMS;
using TamTechSDK.Common.Services.Upload;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.AppSetting;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;

namespace TamTech.Web.Areas.Admin.Controllers
{
    public class HomeController : HomeBaseController
    {
        public HomeController(ITelemetryClientService telemetryClientService,  IWebApplicationSettingsService webApplicationSettingsService , IUploadManagerService uploadManager) 
            : base(telemetryClientService,  webApplicationSettingsService, uploadManager)
        {
        }
    }
}
