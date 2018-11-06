using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TamTechSDK.Common.Services.ContentService.Posts;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;

namespace AltinZaman.Areas.Admin.Controllers
{
    public class PostsController : PostsBaseController
    {
        public PostsController(
            ITelemetryClientService telemetryClientService,
            ICulturesManager languageService,
            IPostsService postservice,
            IStringLocalizer<PostsBaseController> localizer) : base(telemetryClientService, languageService, postservice, localizer)
        {
        }
    }
}