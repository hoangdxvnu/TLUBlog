using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TLU.Blog.Helpers
{
    public class BlogLang
    {
        private const string KEY_LANGUAGE = "TLULanguage";
        
        public static void SetLanguage(string pCulture)
        {
            BlogCookies.AddCookie(pCulture, KEY_LANGUAGE);
        }

        public static int CurrentLang
        {
            set { CurrentLang = value; }
            get
            {
                if (string.IsNullOrEmpty(BlogCookies.GetCookie(KEY_LANGUAGE)))
                    return 0;

                switch(BlogCookies.GetCookie(KEY_LANGUAGE))
                {
                    case "vi":
                        return (int)TLUCultureEnumType.vi;
                    case "en":
                        return (int)TLUCultureEnumType.en;
                    case "ja":
                        return (int)TLUCultureEnumType.ja;
                    default:
                        return (int)TLUCultureEnumType.vi;
                }
            }
        }
    }
}