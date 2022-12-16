#pragma checksum "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc0768c4157052232fc6396e9b87dd4b8812dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_SendBox), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/SendBox.cshtml")]
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
#line 1 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc0768c4157052232fc6396e9b87dd4b8812dad", @"/Areas/Writer/Views/Message/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Message_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Giden Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Konu</th>
                            <th>Alıcı</th>
                            <th>Tarih</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 27 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 30 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
                           Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 31 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <th>");
#nullable restore
#line 32 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
                           Write(item.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 33 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
                           Write(Convert.ToDateTime(item.Date).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 1210, "\"", 1276, 2);
            WriteAttributeValue("", 1217, "/Writer/Message/MessageDetailsSendBox/", 1217, 38, true);
#nullable restore
#line 34 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
WriteAttributeValue("", 1255, item.WriterMessageID, 1255, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detaylar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "D:\WebTasarım\Core_Proje\Asp_Core_Proje\Areas\Writer\Views\Message\SendBox.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
