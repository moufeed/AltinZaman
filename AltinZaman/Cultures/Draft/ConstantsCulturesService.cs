using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamTechSDK.Web.Services.Configurations.Cultures;
using TamTechSDK.Web.Services.Configurations.Cultures.Models;

namespace AltinZaman.Cultures
{
    public class ConstantsCulturesService : ICulturesManager
    {
        #region Props    
        #endregion


        #region Ctors
        public ConstantsCulturesService()
        {
        }
        #endregion

        #region Services
        public List<CultureModel> GetCultures()
        {
            return new List<CultureModel>
            {
                new CultureModel{Name = "English", Culture = "en-US", Lang = "en"},
                new CultureModel{Name = "العربية", Culture = "ar-SA", Lang = "ar"}
            };
        }

        public CultureModel GetDefaultCulture()
        {
            return new CultureModel { Name = "English", Culture = "en-US", Lang = "en" };
        }
        #endregion
    }
}
