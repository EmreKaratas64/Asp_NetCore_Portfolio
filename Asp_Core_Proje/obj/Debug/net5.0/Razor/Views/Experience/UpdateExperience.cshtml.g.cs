#pragma checksum "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af81f2fa1d523e39f0e4ef74beb5faabad4d4d05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_UpdateExperience), @"mvc.1.0.view", @"/Views/Experience/UpdateExperience.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af81f2fa1d523e39f0e4ef74beb5faabad4d4d05", @"/Views/Experience/UpdateExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44259083edbd18a46ae939ec41501b10731a65fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience_UpdateExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
  
    ViewData["Title"] = "UpdateExperience";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"col-md-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Deneyim Düzenle</h4>\r\n");
#nullable restore
#line 14 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
             using (Html.BeginForm("UpdateExperience", "Experience", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af81f2fa1d523e39f0e4ef74beb5faabad4d4d054463", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 18 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
                   Write(Html.HiddenFor(e => e.ExperienceID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <label class=\"form-control-label\">Deneyim Başlık</label>\r\n                        ");
#nullable restore
#line 20 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
                   Write(Html.TextBoxFor(e => e.Name, new { @class = "form-control", required = "required", placeholder = "Deneyim başlık" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Deneyim Tarih</label>\r\n                        ");
#nullable restore
#line 24 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
                   Write(Html.TextBoxFor(e => e.Date, new { @class = "form-control", required = "required", placeholder = "Deneyim tarih" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Denyim Fotoğraf</label>\r\n                        ");
#nullable restore
#line 28 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
                   Write(Html.TextBoxFor(e => e.ImageUrl, new { @class = "form-control", required = "required", placeholder = "Deneyim fotoğraf" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Denyim Açıklama</label>\r\n                        ");
#nullable restore
#line 32 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
                   Write(Html.TextAreaFor(e => e.Description, new { @class = "form-control", required = "required", placeholder = "Deneyim açıklama", rows = "5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <br />
                    <button type=""submit"" class=""btn btn-outline-success btn-icon-text"">
                        <i class=""mdi mdi-upload btn-icon-prepend""></i> Deneyimi Düzenle
                    </button>
                    <a href=""/Experience/Index/"" class=""btn btn-dark btn-icon-text"" style=""float:right"">
                        <i class=""mdi mdi-reload btn-icon-prepend""></i> İptal Et
                    </a>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\Experience\UpdateExperience.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591
