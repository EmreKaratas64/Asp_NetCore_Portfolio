#pragma checksum "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b36d4eacda12df547b78c5781e76d1ed44b89a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#line 1 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b36d4eacda12df547b78c5781e76d1ed44b89a14", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44259083edbd18a46ae939ec41501b10731a65fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Deneyim Tablosu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Deneyim ID</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 27 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 30 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
                               Write(item.ExperienceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 31 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1138, "\"", 1192, 2);
            WriteAttributeValue("", 1145, "/Experience/DeleteExperience/", 1145, 29, true);
#nullable restore
#line 34 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1174, item.ExperienceID, 1174, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger btn-icon-text"">
                                        <i class=""mdi mdi-alert btn-icon-prepend""></i> Sil
                                    </a>
                                </td>

                                <td>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1492, "\"", 1546, 2);
            WriteAttributeValue("", 1499, "/Experience/UpdateExperience/", 1499, 29, true);
#nullable restore
#line 40 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1528, item.ExperienceID, 1528, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-success btn-icon-text"">
                                        <i class=""mdi mdi-upload btn-icon-prepend""></i> Düzenle
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 45 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </tbody>
                </table>
                <br />
                <a href=""/Experience/AddExperience/"" class=""btn btn-outline-primary btn-icon-text"">
                    <i class=""mdi mdi-file-check btn-icon-prepend""></i> Yeni Deneyim Ekle
                </a>

            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
