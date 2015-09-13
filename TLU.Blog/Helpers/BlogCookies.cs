using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TLU.Blog.Helpers
{
    /// <summary>
    /// <author>HoangDX</author>
    /// <description>Allowing add, remove cookie</description>
    /// <date>2015 - Sep - 7</date>
    /// </summary>
    public class BlogCookies
    {
        public static void AddCookie(Object pValue, string pKey)
        {
            var httpCookie = new HttpCookie(pKey);

            httpCookie.Value = pValue.ToString();

            if (HttpContext.Current.Request.Cookies[pKey] == null)
                HttpContext.Current.Response.Cookies.Add(httpCookie);
            else
                HttpContext.Current.Response.Cookies.Set(httpCookie);

        }

        public static string GetCookie(string pKey)
        {
            if (HttpContext.Current.Request.Cookies[pKey] != null)
                return HttpContext.Current.Request.Cookies[pKey].Value;
            return string.Empty;
        }


    }
}