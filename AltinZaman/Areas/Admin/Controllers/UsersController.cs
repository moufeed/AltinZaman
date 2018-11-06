using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Common.Services.Identity.Settings;
using TamTechSDK.Web.Services.Telemetry;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.Cultures;
using Microsoft.Extensions.Localization;
namespace AltinZaman.Areas.Admin.Controllers
{
    public class UsersController : UsersBaseController
    {
        #region Ctors
        public UsersController(ITelemetryClientService telemetryClientService,
                               IUsersManagerService identityService,
                               IRolesService rolesService,
                                  ICulturesManager languageService,
                                  IStringLocalizer<UsersBaseController> localizer
                              )
               : base(telemetryClientService, identityService, rolesService, languageService, localizer)
        {
        }
        #endregion  

    }
}