using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Web;

namespace TLU.Blog.Helpers
{
    /// <summary>
    /// <Author>HoangDX</Author>
    /// <Date>2015 - Sep - 11</Date>
    /// <Description>Get culture name</Description>
    /// </summary>

    public class TLUResourceManager
    {

        public static ResourceManager _resoure = new ResourceManager("TLU.Blog.Resource.TLUResource", typeof(TLU.Blog.MvcApplication).Assembly);

        public static CultureInfo _culture;
        
        public static void SetLanguage(string pValue)
        {
            _culture = CultureInfo.CreateSpecificCulture(pValue);

            Resource.TLUResource.Culture = _culture;
        }

        public static string GetValueByKey(string pValueKey)
        {
            return _resoure.GetString(pValueKey, _culture);
        }
    }
}