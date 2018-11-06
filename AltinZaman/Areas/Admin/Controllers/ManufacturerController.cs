using TamTechSDK.Common.Services.ContentService.Brands;
using TamTechSDK.Common.Services.Upload;
using TamTechSDK.Web.Controllers.Admin;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Telemetry;

namespace AltinZaman.Areas.Admin.Controllers
{
    public class ManufacturerController : ManufacturerBaseController
    {
        #region Ctors
        public ManufacturerController(ITelemetryClientService telemetryClientService,
                                        IBrandsServices brandService,
                                        IUploadService uploadService,
            ICulturesManager languageService)
            : base(telemetryClientService, brandService, uploadService, languageService)
        {
        }
        #endregion 
    }
}