using Microsoft.Extensions.Configuration;
using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Common.Services.SMS;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.AppSetting;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;

namespace AltinZaman.Areas.Admin.Controllers
{
    public class HomeController : HomeBaseController
    {
        public HomeController(ITelemetryClientService telemetryClientService, IWebApplicationSettingsService webApplicationSettingsService)
            : base(telemetryClientService, webApplicationSettingsService)
        {
        }
    }
}
