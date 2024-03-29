#pragma checksum "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c25e324a2a97cabfd8028b355cfb3399f5a940e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c25e324a2a97cabfd8028b355cfb3399f5a940e", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44259083edbd18a46ae939ec41501b10731a65fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
  
    string project_status = "Gelişmede";
    string class_text_status = "text-warning";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Projeler</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Proje Platformu </th>
                                <th> Proje İsmi </th>
                                <th> Proje Fiyatı </th>
                                <th> Proje Durumu </th>
                                <th> Tamamlanma Oranı </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {
                                if (item.Status == true)
                                {
                                    project_status = "Tamamlandı";
                                    class_text_status = "text-success";
                                }
                                else if (int.Parse(item.Value.ToString()) > 80 && int.Parse(item.Value.ToString()) < 100)
                                {
                                    project_status = "Yakın";
                                    class_text_status = "text-primary";
                                }
                                else
                                {
                                    project_status = "Gelişmede";
                                    class_text_status = "text-warning";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 48 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                   Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2134, "\"", 2154, 1);
#nullable restore
#line 51 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 2140, item.Platform, 2140, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Proje\" />\r\n                                    </td>\r\n                                    <td> ");
#nullable restore
#line 53 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 54 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺ </td>\r\n                                    <td");
            BeginWriteAttribute("class", " class=\"", 2375, "\"", 2401, 1);
#nullable restore
#line 55 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 2383, class_text_status, 2383, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 55 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                                               Write(project_status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td");
            BeginWriteAttribute("class", " class=\"", 2466, "\"", 2492, 1);
#nullable restore
#line 56 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 2474, class_text_status, 2474, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> %");
#nullable restore
#line 56 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
