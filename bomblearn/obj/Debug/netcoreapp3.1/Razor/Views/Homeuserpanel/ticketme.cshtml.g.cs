#pragma checksum "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d773068543e42111a6955e2e473b24861e33df70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homeuserpanel_ticketme), @"mvc.1.0.view", @"/Views/Homeuserpanel/ticketme.cshtml")]
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
#line 1 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using layedata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using datacore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d773068543e42111a6955e2e473b24861e33df70", @"/Views/Homeuserpanel/ticketme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db25fef0661f34da64eab986bfcdab84e8b5f36", @"/Views/_ViewImports.cshtml")]
    public class Views_Homeuserpanel_ticketme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/data/css/cssuserpanela.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
  
    ViewData["Title"] = "سوالات من";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d773068543e42111a6955e2e473b24861e33df704511", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"<section class=""ui container sec2userpanel"">
    <div class=""ui grid"">
        <div class=""col3"">
            <div class=""kenariconcol9 floatleft"">
                <h2 class=""txtright marginnone"">0</h2>
                <h4 class=""txtright marginnone"">دوره های من</h4>
            </div>
            <div class=""iconlol3 float_right"">
                <i class=""huge graduation cap icon card cardicon""></i>
            </div>
        </div>
        <div class=""col3"">
            <div class=""kenariconcol9 floatleft"">
                <h2 class=""txtright marginnone"">0</h2>
                <h4 class=""txtright marginnone"">کیف پول من</h4>
            </div>
            <div class=""iconlol3 float_right"">
                <i class=""huge credit card icon cardicon""></i>
            </div>
        </div>
        <div class=""col3"">
            <div class=""kenariconcol9 floatleft"">
                <h2 class=""txtright marginnone"">آمیرحسین فرخنده فر</h2>
                <h4 class=""txtright marginnone"">دانشجو</h4>
            </div");
            WriteLiteral(@">
            <div class=""iconlol3 float_right"">
                <i class=""huge user icon card cardicon""></i>
            </div>
        </div>
        <div class=""col42 right"">
            <div class=""ui vertical fluid right menu"">
                <a class=""item txtright active"">
                    دوره های من
                </a>
                <a class=""item txtright"">
                    فاکتور ها
                </a>
                <a class=""item txtright"">
                    سوالات من
                </a>
                <a class=""item txtright"">
                    پاسخ های من
                </a>
                <a class=""item txtright activemenukenar"">
                    تیکت های من
                </a>
");
#nullable restore
#line 53 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
                 if (ViewBag.isteacher)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1953, "\"", 1991, 2);
            WriteAttributeValue("", 1960, "doreadmin/", 1960, 10, true);
#nullable restore
#line 55 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
WriteAttributeValue("", 1970, User.Identity.Name, 1970, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item txtright\">\n                        پنل دوره های من\n                    </a>\n");
#nullable restore
#line 58 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a class=""item txtright"">
                    خروج از حساب کاربری
                </a>
            </div>
        </div>
        <div class=""col12 stretched column"">
            <div style=""overflow-x:auto;"">
                <table>
                    <tr>
                        <th class=""txtcenter"">تاریخ</th>
                        <th class=""txtcenter"">تعداد پاسخ</th>
                        <th class=""txtcenter"">وضعیت</th>
                        <th class=""txtcenter"">عنوان تیکت</th>
                    </tr>
                    <tr>
                        <td class=""txtcenter"">1399/05/13</td>
                        <td class=""txtcenter"">1</td>
                        <td class=""txtcenter colorgreen"">پاسخ داده شده</td>
                        <td class=""txtcenter""><a>دانلود اندوروید استودیو</a></td>
                    </tr>
                    <tr>
                        <td class=""txtcenter"">1399/02/01</td>
                        <td class=""txtcenter"">1</td>
                      ");
            WriteLiteral(@"  <td class=""txtcenter colorgreen"">پاسخ داده شده</td>
                        <td class=""txtcenter""><a>استفاده از میکروفن و وب کم</a></td>
                    </tr>
                    <tr>
                        <td class=""txtcenter"">1399/02/01</td>
                        <td class=""txtcenter"">1</td>
                        <td class=""txtcenter colonavy"">درحال بررسی</td>
                        <td class=""txtcenter""><a>code first یا dbfirst</a></td>
                    </tr>
                </table>
            </div>
        </div>
        <div class=""col4 right"">
            <div class=""ui vertical fluid right menu"">
                <a class=""item txtright active"">
                    دوره های من
                </a>
                <a class=""item txtright"">
                    فاکتور ها
                </a>
                <a class=""item txtright"">
                    سوالات من
                </a>
                <a class=""item txtright"">
                    پاسخ های من
                </a>
           ");
            WriteLiteral("     <a class=\"item txtright activemenukenar\">\n                    تیکت های من\n                </a>\n");
#nullable restore
#line 111 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
                 if (ViewBag.isteacher)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 4327, "\"", 4365, 2);
            WriteAttributeValue("", 4334, "doreadmin/", 4334, 10, true);
#nullable restore
#line 113 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
WriteAttributeValue("", 4344, User.Identity.Name, 4344, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item txtright\">\n                        پنل دوره های من\n                    </a>\n");
#nullable restore
#line 116 "C:\Users\amir hossein aziz\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\ticketme.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"item txtright\">\n                    خروج از حساب کاربری\n                </a>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591