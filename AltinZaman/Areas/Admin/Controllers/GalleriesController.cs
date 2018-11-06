using TamTechSDK.Common.Services.ContentService;
using TamTechSDK.Common.Services.ContentService.Galleries;
using TamTechSDK.Common.Services.ContentService.Reviews;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Telemetry;
using TamTechSDK.Common.Services.Upload;
using TamTechSDK.Common.Services.Upload.Settings;
using TamTechSDK.Web.Services.Configurations.Cultures;
using Microsoft.Extensions.Localization;

namespace AltinZaman.Areas.Admin.Controllers
{
    public class GalleriesController : GalleryBaseController
    {
        public GalleriesController(ITelemetryClientService telemetryClientService,
            IGalleriesService galeriesService,
             IUploadManagerService uploadManager, ICulturesManager languageService, IStringLocalizer<GalleryBaseController> localizer)
            : base(telemetryClientService, galeriesService, uploadManager, languageService, localizer)
        {
        }
    }
}