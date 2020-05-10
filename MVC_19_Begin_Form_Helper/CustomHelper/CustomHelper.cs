using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_19_Begin_Form_Helper
{
    public static class CustomHelper
    {
        public static string SayfayaGit(string actionName)
        {
            return "<a href='" + actionName + "'>" + actionName + "</a>";
        }

        public static MvcHtmlString Resim(this HtmlHelper htmlHelper, string kaynak, string alternatifMetin, string genislik, string yukseklik)
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.Attributes.Add("src", kaynak);
            tagBuilder.Attributes.Add("alt", alternatifMetin);
            tagBuilder.Attributes.Add("width", genislik);
            tagBuilder.Attributes.Add("height", yukseklik);
            return MvcHtmlString.Create(tagBuilder.ToString(TagRenderMode.SelfClosing));
        }
    }
}