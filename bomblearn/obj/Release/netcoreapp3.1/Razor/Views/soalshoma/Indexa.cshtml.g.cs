#pragma checksum "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9047cdbb850190141aae53d1aedf5f52d44ea112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_soalshoma_Indexa), @"mvc.1.0.view", @"/Views/soalshoma/Indexa.cshtml")]
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
#line 1 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using layedata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using datacore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9047cdbb850190141aae53d1aedf5f52d44ea112", @"/Views/soalshoma/Indexa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d567f1434effcaf55c52eea1dbff70305f7299e", @"/Views/_ViewImports.cshtml")]
    public class Views_soalshoma_Indexa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<layedata.soal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/data/css/soalcss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/soalsearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9047cdbb850190141aae53d1aedf5f52d44ea1125223", async() => {
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
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css\">\r\n");
            }
            );
            WriteLiteral("<section>\r\n    <div class=\"ui container\">\r\n        <div class=\"divsoal\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9047cdbb850190141aae53d1aedf5f52d44ea1126684", async() => {
                WriteLiteral(@"
                <div class=""container w_100"">
                    <div class=""ui w_100 icon input"">
                        <input style=""padding-right: 40px !important;"" class=""paddingh3dore prompt txtright inputsoalsearch inputindexsearchbala"" id=""searchsoal"" name=""searchinput"" type=""text"" placeholder=""ببین سوالت قبلا پرسیده شده ؟"">
                        <button class=""btnsearchinputbalaindex""> <i class=""search icon""></i></button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <div class=\"w_100 textcenter\">\r\n");
#nullable restore
#line 20 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>تعداد سوالات مطرح شده :");
#nullable restore
#line 22 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                                         Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>تعداد سوالات مطرح شده :0</p>\r\n");
#nullable restore
#line 27 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1197, "\"", 1234, 2);
            WriteAttributeValue("", 1204, "/soal/create/", 1204, 13, true);
#nullable restore
#line 28 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
WriteAttributeValue("", 1217, ViewBag.iddore, 1217, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"ui inverted green button\">ثبت سوال جدید</button></a>\r\n            </div>\r\n        </div>\r\n        <div class=\"ui cards gridkhodam\">\r\n");
#nullable restore
#line 32 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"colsoalkoly\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1570, "\"", 1601, 2);
            WriteAttributeValue("", 1577, "/question/", 1577, 10, true);
#nullable restore
#line 37 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
WriteAttributeValue("", 1587, item.soalid, 1587, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"ui link card w_100\">\r\n\r\n                                <div class=\"content\">\r\n                                    <h2 class=\"txtright header titrsoalhame containerkhodam coloblack\">");
#nullable restore
#line 41 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                                                                                                  Write(item.soaltitr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <div class=\"meta txtright\">\r\n                                        <p class=\"fontsize12\">");
#nullable restore
#line 43 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                                                         Write(item.Dore.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n\r\n                                    <hr>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2126, "\"", 2157, 2);
            WriteAttributeValue("", 2133, "/question/", 2133, 10, true);
#nullable restore
#line 47 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
WriteAttributeValue("", 2143, item.soalid, 2143, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"ui floatleft primary basic button clbtnfllsoal\">دیدن سوال</button> </a>\r\n");
#nullable restore
#line 48 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                                     if (item.Javabs.Count == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"ui float_right negative basic button clbtnfllsoal\">پاسخی ثبت نشده است</button>\r\n");
#nullable restore
#line 51 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"ui float_right positive basic button clbtnfllsoal\">پاسخی ثبت شده است</button>\r\n");
#nullable restore
#line 55 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\soalshoma\Indexa.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#searchsoal"").autocomplete({
                source: '/api/soalapisearch/search'
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<layedata.soal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
