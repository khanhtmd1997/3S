#pragma checksum "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\_ViewImports.cshtml"
using TaskTranning;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\_ViewImports.cshtml"
using TaskTranning.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
using TaskTranning.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb0", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5150a7bc51847e0bdcea41547885033983a2d189", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskTranning.ViewModels.ProductViewModel.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/create.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
  
    ViewBag.Title = Localizer.GetLocalizedHtmlString("Page Product");
    Layout = "_NavbarDataTable";

#line default
#line hidden
            BeginContext(245, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 8 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
     if (TempData["succcessMessage"] != null)
    {

#line default
#line hidden
            BeginContext(297, 44, true);
            WriteLiteral("        <h5 class=\"text-danger text-center\">");
            EndContext();
            BeginContext(342, 27, false);
#line 10 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                                       Write(TempData["succcessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(369, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 11 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(381, 65, true);
            WriteLiteral("    <div class=\"sectionContent\">\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(447, 48, false);
#line 13 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                           Write(Localizer.GetLocalizedHtmlString("Page Product"));

#line default
#line hidden
            EndContext();
            BeginContext(495, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 14 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
         if (ViewBag.Count == 0)
        {

#line default
#line hidden
            BeginContext(544, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(560, 53, false);
#line 16 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("NOT DATA OF TABLE"));

#line default
#line hidden
            EndContext();
            BeginContext(613, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(616, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb08851", async() => {
                BeginContext(639, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb09114", async() => {
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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(685, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 17 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(723, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(739, 42, false);
#line 20 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("Finded"));

#line default
#line hidden
            EndContext();
            BeginContext(781, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(784, 13, false);
#line 20 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                                                       Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(797, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(799, 44, false);
#line 20 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                                                                      Write(Localizer.GetLocalizedHtmlString("Products"));

#line default
#line hidden
            EndContext();
            BeginContext(843, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(846, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb012730", async() => {
                BeginContext(869, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb012994", async() => {
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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(915, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 21 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(930, 116, true);
            WriteLiteral("        <table id=\"table_id\" class=\"table table-bordered\">\n            <thead>\n            <tr>\n                <th>");
            EndContext();
            BeginContext(1047, 47, false);
#line 25 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("ProductName"));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1121, 45, false);
#line 26 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("BrandName"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1193, 48, false);
#line 27 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("CategoryName"));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1268, 45, false);
#line 28 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("ModelYear"));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1340, 45, false);
#line 29 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("ListPrice"));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1412, 43, false);
#line 30 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("Picture"));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 26, true);
            WriteLiteral("</th>\n                <th>");
            EndContext();
            BeginContext(1482, 42, false);
#line 31 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
               Write(Localizer.GetLocalizedHtmlString("Action"));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 65, true);
            WriteLiteral("</th>\n            </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 35 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
             foreach (var item  in Model)
            {
                if (@ViewBag.Count < 0)
                {

#line default
#line hidden
            BeginContext(1703, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(1727, 44, false);
#line 39 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                  Write(Localizer.GetLocalizedHtmlString("Not Data"));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 40 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1833, 94, true);
            WriteLiteral("                    <tr>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1928, 46, false);
#line 45 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 101, true);
            WriteLiteral("\n                        </td >\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(2076, 50, false);
#line 48 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Brand.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 101, true);
            WriteLiteral("\n\n                        </td>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(2228, 56, false);
#line 52 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 100, true);
            WriteLiteral("\n                        </td>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(2385, 44, false);
#line 55 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 100, true);
            WriteLiteral("\n                        </td>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(2530, 44, false);
#line 58 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 104, true);
            WriteLiteral("\n                        </td>\n                        <td scope=\"row\">\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2678, "\"", 2735, 2);
            WriteAttributeValue("", 2684, "/images/", 2684, 8, true);
#line 61 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
WriteAttributeValue("", 2692, Html.DisplayFor(modelItem => item.Picture), 2692, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2736, 140, true);
            WriteLiteral(" width=\"30\"/>\n                        </td>\n                        <td scope=\"row\" style=\"text-align: center\">\n                            ");
            EndContext();
            BeginContext(2876, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb022499", async() => {
                BeginContext(2921, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb022764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2965, 29, true);
            WriteLiteral("\n                            ");
            EndContext();
            BeginContext(2994, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb025963", async() => {
                BeginContext(3107, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(3140, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9147832ddbac7ced0ad8656dd2dd26a1a8ebcdb026375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3181, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3214, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 70 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Product\Index.cshtml"
                }

            }

#line default
#line hidden
            BeginContext(3304, 48, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ResourcesServices Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TaskTranning.ViewModels.ProductViewModel.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591