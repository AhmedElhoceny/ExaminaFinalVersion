#pragma checksum "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08fa48be0b38de3177bf1189347f847704e0ecc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowContentElementReadings), @"mvc.1.0.view", @"/Views/Home/ShowContentElementReadings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowContentElementReadings.cshtml", typeof(AspNetCore.Views_Home_ShowContentElementReadings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08fa48be0b38de3177bf1189347f847704e0ecc9", @"/Views/Home/ShowContentElementReadings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/_ViewImports.cshtml")]
    public class Views_Home_ShowContentElementReadings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExaminaFinalVersion.Models.Reading>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml"
  
    Layout = "~/_Layout4.cshtml";

#line default
#line hidden
            BeginContext(87, 167, true);
            WriteLiteral("<div style=\"width: 100%; height: 100px; background: none;\"></div>\r\n<div class=\"PersonContent\">\r\n        <div class=\"PersonDetails\">\r\n            <p>DataID       :     ");
            EndContext();
            BeginContext(256, 16, false);
#line 9 "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml"
                              Write(Model.Reading_ID);

#line default
#line hidden
            EndContext();
            BeginContext(273, 40, true);
            WriteLiteral("</p>\r\n            <p>Title        :     ");
            EndContext();
            BeginContext(315, 28, false);
#line 10 "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml"
                              Write(Model.Readings_Reading_Title);

#line default
#line hidden
            EndContext();
            BeginContext(344, 40, true);
            WriteLiteral("</p>\r\n            <p>Script       :     ");
            EndContext();
            BeginContext(386, 21, false);
#line 11 "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml"
                              Write(Model.Readings_Script);

#line default
#line hidden
            EndContext();
            BeginContext(408, 40, true);
            WriteLiteral("</p>\r\n            <p>CourseName   :     ");
            EndContext();
            BeginContext(450, 18, false);
#line 12 "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml"
                              Write(ViewBag.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(469, 307, true);
            WriteLiteral(@"</p>
        </div>
        <div style=""width: 100%; height: 100px; background: none;""></div>
        <div class=""PersonCourses"">
            <div class=""CoursesElements"" style=""height:600px !important ; text-align:center"">
                <p style=""font-size:25px ; color:#0ead46 ; align-self:center"">");
            EndContext();
            BeginContext(778, 22, false);
#line 17 "E:\self study\WEB\projects\ExaminaFinalVersion Wallahi\ExaminaFinalVersion Wallahi\Views\Home\ShowContentElementReadings.cshtml"
                                                                          Write(Model.Readings_Content);

#line default
#line hidden
            EndContext();
            BeginContext(801, 50, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExaminaFinalVersion.Models.Reading> Html { get; private set; }
    }
}
#pragma warning restore 1591
