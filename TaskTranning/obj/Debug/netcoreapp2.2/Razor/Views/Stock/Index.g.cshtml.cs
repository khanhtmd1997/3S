#pragma checksum "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4405b5acda62940068275abb59cb669fc7750846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Index), @"mvc.1.0.view", @"/Views/Stock/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stock/Index.cshtml", typeof(AspNetCore.Views_Stock_Index))]
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
#line 2 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
using TaskTranning.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4405b5acda62940068275abb59cb669fc7750846", @"/Views/Stock/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5150a7bc51847e0bdcea41547885033983a2d189", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskTranning.ViewModels.StockViewModel.StockViewModel>>
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
#line 4 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
  
    ViewBag.Title = Localizer.GetLocalizedHtmlString("Page Stock");
    Layout = "_NavbarDataTable";

#line default
#line hidden
            BeginContext(239, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
     if (TempData["succcessMessage"] != null)
    {

#line default
#line hidden
            BeginContext(292, 44, true);
            WriteLiteral("        <h5 class=\"text-danger text-center\">");
            EndContext();
            BeginContext(337, 27, false);
#line 11 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                       Write(TempData["succcessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(364, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 12 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(376, 65, true);
            WriteLiteral("    <div class=\"sectionContent\">\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(442, 46, false);
#line 14 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                           Write(Localizer.GetLocalizedHtmlString("Page Stock"));

#line default
#line hidden
            EndContext();
            BeginContext(488, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 15 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
         if (ViewBag.Count == 0)
        {

#line default
#line hidden
            BeginContext(537, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(553, 53, false);
#line 17 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("NOT DATA OF TABLE"));

#line default
#line hidden
            EndContext();
            BeginContext(606, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(609, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4405b5acda62940068275abb59cb669fc77508468811", async() => {
                BeginContext(632, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4405b5acda62940068275abb59cb669fc77508469074", async() => {
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
            BeginContext(678, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(716, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(732, 42, false);
#line 21 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
          Write(Localizer.GetLocalizedHtmlString("Finded"));

#line default
#line hidden
            EndContext();
            BeginContext(774, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(777, 13, false);
#line 21 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                                       Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(790, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(792, 42, false);
#line 21 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                                                      Write(Localizer.GetLocalizedHtmlString("Stocks"));

#line default
#line hidden
            EndContext();
            BeginContext(834, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(837, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4405b5acda62940068275abb59cb669fc775084612680", async() => {
                BeginContext(860, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4405b5acda62940068275abb59cb669fc775084612944", async() => {
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
            BeginContext(906, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 22 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(921, 124, true);
            WriteLiteral("        <table id=\"table_id\" class=\"table table-bordered\">\n            <thead>\n                <tr>\n                    <th>");
            EndContext();
            BeginContext(1046, 45, false);
#line 26 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("StoreName"));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(1122, 47, false);
#line 27 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("ProductName"));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(1200, 44, false);
#line 28 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("Quantity"));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(1275, 42, false);
#line 29 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                   Write(Localizer.GetLocalizedHtmlString("Action"));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 69, true);
            WriteLiteral("</th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 33 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
             foreach (var item  in Model)
            {
                if (@ViewBag.Count < 0)
                {

#line default
#line hidden
            BeginContext(1500, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(1524, 44, false);
#line 37 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                  Write(Localizer.GetLocalizedHtmlString("Not Data"));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 38 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1630, 94, true);
            WriteLiteral("                    <tr>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1725, 50, false);
#line 43 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Store.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 100, true);
            WriteLiteral("\n                        </td>\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(1876, 54, false);
#line 46 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 101, true);
            WriteLiteral("\n                        </td >\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(2032, 43, false);
#line 49 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 101, true);
            WriteLiteral("\n                        </td >\n                        <td scope=\"row\">\n                            ");
            EndContext();
            BeginContext(2176, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4405b5acda62940068275abb59cb669fc775084619685", async() => {
                BeginContext(2269, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4405b5acda62940068275abb59cb669fc775084619950", async() => {
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                                          WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                                                                              WriteLiteral(item.StoreId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2313, 29, true);
            WriteLiteral("\n                            ");
            EndContext();
            BeginContext(2342, 268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4405b5acda62940068275abb59cb669fc775084623920", async() => {
                BeginContext(2503, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(2536, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4405b5acda62940068275abb59cb669fc775084624332", async() => {
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
                BeginContext(2577, 29, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                                            WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                                                                                                WriteLiteral(item.StoreId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2610, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 58 "C:\Users\Admin\Desktop\3S\3S_Trainning\TaskTranning\Views\Stock\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2699, 48, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TaskTranning.ViewModels.StockViewModel.StockViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591