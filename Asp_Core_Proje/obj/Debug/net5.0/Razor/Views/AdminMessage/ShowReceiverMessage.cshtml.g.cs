#pragma checksum "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6a989c557507010b0f1e5ada518720cc2ce1292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_ShowReceiverMessage), @"mvc.1.0.view", @"/Views/AdminMessage/ShowReceiverMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a989c557507010b0f1e5ada518720cc2ce1292", @"/Views/AdminMessage/ShowReceiverMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44259083edbd18a46ae939ec41501b10731a65fe", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMessage_ShowReceiverMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterMessage>
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
#line 3 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
  
    ViewData["Title"] = "ShowReceiverMessage";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";
    string date_of_contact = DateTime.Parse(Model.Date.ToString()).ToString("dd/MM/yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Gelen Mesaj</h4>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a989c557507010b0f1e5ada518720cc2ce12924278", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 16 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
               Write(Html.HiddenFor(s => s.WriterMessageID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"form-control-label\">Başlık</label>\r\n                    ");
#nullable restore
#line 18 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
               Write(Html.TextBoxFor(s => s.Subject, new { @class = "form-control", placeholder = "Başlık" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"form-control-label\">Göndren</label>\r\n                    ");
#nullable restore
#line 22 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
               Write(Html.TextBoxFor(s => s.SenderName, new { @class = "form-control", placeholder = "Gönderen" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"form-control-label\">Göndren Mail</label>\r\n                    ");
#nullable restore
#line 26 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
               Write(Html.TextBoxFor(s => s.Sender, new { @class = "form-control", placeholder = "Gönderen mail" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"form-control-label\">Tarih</label>\r\n                    ");
#nullable restore
#line 30 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
               Write(Html.TextBoxFor(modelItem => date_of_contact, new { @class = "form-control",placeholder="Tarih" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"form-control-label\">İçerik</label>\r\n                    ");
#nullable restore
#line 34 "D:\C#-Asp_Projeler\Core_Proje\Asp_Core_Proje\Views\AdminMessage\ShowReceiverMessage.cshtml"
               Write(Html.TextAreaFor(s => s.MessageContent, new { @class = "form-control", placeholder = "İçerik", rows = "10" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <br />
                <a href=""/AdminMessage/ReceiverMessageList/"" class=""btn btn-outline-success btn-icon-text"">
                    <i class=""mdi mdi-arrow-left-bold-circle-outline""></i> Geri Dön
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
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591