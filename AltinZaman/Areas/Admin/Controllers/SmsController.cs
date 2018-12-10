using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Common.Services.ServiceBus;
using TamTechSDK.Common.Services.SMS;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;

namespace TamTech.Web.Areas.Admin.Controllers
{
    public class SmsController : SmsBaseController
    {
        public SmsController(ITelemetryClientService telemetryClientService,  ISMSService sMSService, IUsersManagerService IdentityService, ServiceBusSettings serviceBusSettings) : base(telemetryClientService,  sMSService, IdentityService, serviceBusSettings)
        {
        }
    }
}