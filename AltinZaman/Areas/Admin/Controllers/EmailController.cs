 
using TamTechSDK.Common.Services.Email;
using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;

namespace TamTech.Web.Areas.Admin.Controllers
{
    public class EmailController : EmailBaseController
    {
        public EmailController(
                                IUsersManagerService IdentityService,
                                IEmailSenderService emailService,
                                ITelemetryClientService telemetryClientService )
            : base(IdentityService, emailService, telemetryClientService)
        {

        }

    }
}