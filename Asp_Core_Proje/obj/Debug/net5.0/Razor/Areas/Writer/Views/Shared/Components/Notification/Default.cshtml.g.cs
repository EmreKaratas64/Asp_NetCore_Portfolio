#pragma checksum "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d6aa9c1e5cb0689e61d69a192b0fec3764bcc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_Notification_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d6aa9c1e5cb0689e61d69a192b0fec3764bcc1", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Shared_Components_Notification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
  
    string bg_class = "bg-info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <p class=\"mb-0 font-weight-normal float-left dropdown-header\">Bildirimler</p>\r\n");
#nullable restore
#line 11 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
     foreach (var item in Model)
    {
        if (item.status.ToLower() == "yeni")
        {
            bg_class = "bg-warning";
        }
        else if (item.status.ToLower() == "eski")
        {
            bg_class = "bg-success";
        }
        else if (item.status.ToLower() == "proje")
        {
            bg_class = "bg-info";
        }
        else
        {
            bg_class = "bg-danger";
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 755, "\"", 806, 2);
            WriteAttributeValue("", 762, "/Writer/Default/AnnouncementDetails/", 762, 36, true);
#nullable restore
#line 30 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 798, item.ID, 798, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item preview-item\">\r\n          \r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 922, "\"", 952, 2);
            WriteAttributeValue("", 930, "preview-icon", 930, 12, true);
#nullable restore
#line 33 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue(" ", 942, bg_class, 943, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"ti-info-alt mx-0\"></i>\r\n                </div>\r\n            </div>\r\n         \r\n            <div class=\"preview-item-content\">\r\n                <h6 class=\"preview-subject font-weight-normal\">");
#nullable restore
#line 39 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"font-weight-light small-text mb-0 text-muted\">\r\n                    ");
#nullable restore
#line 41 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
               Write(DateTime.Parse(item.Date.ToString()).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 45 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
