#pragma checksum "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84313cf4e4b9c52eaaa50a005a80467b92918412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNavbarNotificationList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNavbarNotificationList/Default.cshtml")]
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
#line 1 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\_ViewImports.cshtml"
using Asp_Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\_ViewImports.cshtml"
using Asp_Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84313cf4e4b9c52eaaa50a005a80467b92918412", @"/Views/Shared/Components/AdminNavbarNotificationList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44259083edbd18a46ae939ec41501b10731a65fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminNavbarNotificationList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <li class=""nav-item dropdown border-left"">
        <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
            <i class=""mdi mdi-bell""></i>
            <span class=""count bg-danger""></span>
        </a>
        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
            <h6 class=""p-3 mb-0"">Bildirimler</h6>
            <div class=""dropdown-divider""></div>
");
#nullable restore
#line 13 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 711, 2);
            WriteAttributeValue("", 678, "/AdminAnnouncement/Index/", 678, 25, true);
#nullable restore
#line 15 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml"
WriteAttributeValue("", 703, item.ID, 703, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-calendar text-success""></i>
                        </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject mb-1"">");
#nullable restore
#line 22 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-muted ellipsis mb-0\"> ");
#nullable restore
#line 23 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml"
                                                        Write(DateTime.Parse(item.Date.ToString()).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 26 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\AdminNavbarNotificationList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"dropdown-divider\"></div>\r\n");
            WriteLiteral("        </div>\r\n    </li>\r\n");
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
