using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TamTechSDK.Common.Services.Identity;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;
using TamTechSDK.Web.Services.Validations;

namespace AltinZaman.Areas.Identity.Controllers.CustomAccount
{
    public class AuthController : TamTechSDK.Web.Controllers.Identity.AuthBaseController
    {
        public AuthController(ITelemetryClientService telemetryClientService,
            IAuthService accountsService,
            IExpressionValidation expressionValidation,
            ICulturesManager languageService)
            : base(telemetryClientService, accountsService, expressionValidation, languageService)
        {
        }
    }
}