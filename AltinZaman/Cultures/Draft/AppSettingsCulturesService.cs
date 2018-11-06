using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using AltinZaman.Services.Configurations.AppSetting.Constants;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Configurations.Cultures.Models;

namespace AltinZaman.Services.Configurations.Cultures
{
    public class _AppSettingsCulturesService : ICulturesManager
    {


        #region Props  
        private readonly IConfiguration _configuration;
        private readonly string _webApplicationSettings;
        private readonly string _CultureInfo;
        private readonly string _Cultures;
        #endregion


        #region Ctors
        public _AppSettingsCulturesService(IConfiguration configuration,
                                                string webApplicationSettings = AppSettings.WebApplicationSettings,
                                                string CultureInfo = AppSettings.WebApplication_CultureInfo,
                                                string Cultures = AppSettings.Cultures)
        {
            _configuration = configuration;
            _webApplicationSettings = webApplicationSettings;
            _CultureInfo = CultureInfo;
            _Cultures = Cultures;

        }

        public _AppSettingsCulturesService()
        {
        }
        #endregion



        public List<CultureModel> GetCultures()
        {
            List<CultureModel> langs = _configuration
                .GetSection(_webApplicationSettings)
                .GetSection(_CultureInfo)
                .GetSection(_Cultures)
                .Get<List<CultureModel>>();
            return langs;
        }

        public CultureModel GetDefaultCulture()
        {
            List<CultureModel> langs = _configuration
                 .GetSection(_webApplicationSettings)
                 .GetSection(_CultureInfo)
                 .GetSection(_Cultures)
                 .Get<List<CultureModel>>();
            return langs[0];
        }
    }
}
