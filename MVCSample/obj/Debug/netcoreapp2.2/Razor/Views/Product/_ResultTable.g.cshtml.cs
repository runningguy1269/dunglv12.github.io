#pragma checksum "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3731c002d37a3f95ffaec4ca8c64da62cc921ee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__ResultTable), @"mvc.1.0.view", @"/Views/Product/_ResultTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/_ResultTable.cshtml", typeof(AspNetCore.Views_Product__ResultTable))]
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
#line 1 "D:\download\Sample_Dung\Sample\MVCSample\Views\_ViewImports.cshtml"
using MVCSample;

#line default
#line hidden
#line 2 "D:\download\Sample_Dung\Sample\MVCSample\Views\_ViewImports.cshtml"
using MVCSample.Business.Models;

#line default
#line hidden
#line 6 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 7 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#line 8 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3731c002d37a3f95ffaec4ca8c64da62cc921ee0", @"/Views/Product/_ResultTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd779066e3fac9bfdce9afa68d11b2cc60d582d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__ResultTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCSample.Business.Entities.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/global/plugins/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/global/plugins/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/global/plugins/owl-carousel/assets/js/jquery-1.9.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
  
    Layout = null;
var pagedList = (IPagedList)Model;

#line default
#line hidden
            BeginContext(208, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3731c002d37a3f95ffaec4ca8c64da62cc921ee05602", async() => {
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
            EndContext();
            BeginContext(296, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(298, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3731c002d37a3f95ffaec4ca8c64da62cc921ee06854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(375, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(377, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3731c002d37a3f95ffaec4ca8c64da62cc921ee08031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 97, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(564, 2357, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3731c002d37a3f95ffaec4ca8c64da62cc921ee09320", async() => {
                BeginContext(570, 774, true);
                WriteLiteral(@"
                <table id=""tblProduct"" class=""table table-hover table-bordered"">
                    <thead>

                        <tr>
                            <th>Id</th>
                            <th>Tên hàng</th>
                            <th>Nhà cung cấp</th>
                            <th>Danh mục</th>
                            <th>Quy cách</th>
                            <th>Đơn giá</th>
                            <th>Đơn vị lưu kho</th>
                            <th>Đơn vị xuất bán</th>
                            <th>Mức độ đặt hàng lại</th>
                            <th>Giảm giá</th>
                            <th>Hành động</th>
                        </tr>
                    </thead>
                    <tbody>
");
                EndContext();
#line 35 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                         foreach (var p in Model)
                    {



#line default
#line hidden
                BeginContext(1422, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1485, 38, false);
#line 40 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                           Write(Html.DisplayFor(model => p.product_id));

#line default
#line hidden
                EndContext();
                BeginContext(1523, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(1582, 40, false);
#line 41 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.product_name));

#line default
#line hidden
                EndContext();
                BeginContext(1622, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(1681, 49, false);
#line 42 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.Supplier.company_name));

#line default
#line hidden
                EndContext();
                BeginContext(1730, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(1789, 50, false);
#line 43 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.Category.category_name));

#line default
#line hidden
                EndContext();
                BeginContext(1839, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(1898, 45, false);
#line 44 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.quantity_per_unit));

#line default
#line hidden
                EndContext();
                BeginContext(1943, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(2002, 38, false);
#line 45 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.unit_price));

#line default
#line hidden
                EndContext();
                BeginContext(2040, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(2099, 42, false);
#line 46 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.units_in_stock));

#line default
#line hidden
                EndContext();
                BeginContext(2141, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(2200, 42, false);
#line 47 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.units_on_order));

#line default
#line hidden
                EndContext();
                BeginContext(2242, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(2301, 41, false);
#line 48 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.reorder_level));

#line default
#line hidden
                EndContext();
                BeginContext(2342, 58, true);
                WriteLiteral("</td>\r\n                            <td style=\"width:60%;\">");
                EndContext();
                BeginContext(2401, 40, false);
#line 49 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                              Write(Html.DisplayFor(model => p.discontinued));

#line default
#line hidden
                EndContext();
                BeginContext(2441, 73, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2515, 118, false);
#line 51 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = p.product_id }, new { @class = "btn btn-primary", @style = "color:white" }));

#line default
#line hidden
                EndContext();
                BeginContext(2633, 50, true);
                WriteLiteral("\r\n\r\n\r\n                                <a data-id=\"");
                EndContext();
                BeginContext(2684, 12, false);
#line 54 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                       Write(p.product_id);

#line default
#line hidden
                EndContext();
                BeginContext(2696, 123, true);
                WriteLiteral("\" class=\"btn btn-danger\" style=\"color:white\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 57 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"

                    }

#line default
#line hidden
                BeginContext(2844, 70, true);
                WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2921, 103, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            Trang ");
            EndContext();
            BeginContext(3026, 69, false);
#line 67 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
              Write(pagedList.PageCount < pagedList.PageNumber ? 0 : pagedList.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3096, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(3100, 19, false);
#line 67 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
                                                                                        Write(pagedList.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3119, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3134, 120, false);
#line 68 "D:\download\Sample_Dung\Sample\MVCSample\Views\Product\_ResultTable.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new
            {
            page
            })));

#line default
#line hidden
            EndContext();
            BeginContext(3254, 52, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCSample.Business.Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591