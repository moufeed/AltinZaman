using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamTechSDK.Web.Services.Configurations.Cultures.Models;

namespace AltinZaman.Cultures.Constants
{
    public static class CultureConstants
    {

        public static readonly CultureModel DefaultCulture = new CultureModel
        {
            Name = "العربية",
            Culture = "ar",
            Lang = "ar"
        };

        public static readonly List<CultureModel> CulturesList = new List<CultureModel>
        {
            DefaultCulture
        };

        public static readonly string Constraint = DefaultCulture.Culture.Length == 2 ? "^([a||e])+([r||n])$" : "^([ar||en]{2})+(-)+([ar||en]{2})$";
    }
}
