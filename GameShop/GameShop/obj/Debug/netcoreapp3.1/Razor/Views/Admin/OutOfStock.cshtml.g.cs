#pragma checksum "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e47f01aaf8a372c2f1da388aab37b09338897016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OutOfStock), @"mvc.1.0.view", @"/Views/Admin/OutOfStock.cshtml")]
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
#line 1 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\_ViewImports.cshtml"
using GameShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\_ViewImports.cshtml"
using GameShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e47f01aaf8a372c2f1da388aab37b09338897016", @"/Views/Admin/OutOfStock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e4f2d1382b70432e23cf03130c3870902af444", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OutOfStock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameShop.Models.Admins.AdminGamesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
  
    ViewData["Title"] = "Out of stock games";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e47f01aaf8a372c2f1da388aab37b093388970165434", async() => {
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
            WriteLiteral("\r\n    <div class=\"row\" style=\"align-content\">\r\n");
#nullable restore
#line 7 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
         foreach (var game in Model.Games)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--\r\n        <div class=\"col-md-3 product-men\">\r\n            <div class=\"product-chr-info chr\">\r\n                <div class=\"img-thumbnail\" >\r\n                    <a>\r\n                        <img src=\"data:image/png;base64, ");
#nullable restore
#line 14 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                                    Write(game.ImageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" width=\"300\" height=\"500\" alt=\"\" />\r\n                    </a>\r\n                </div>\r\n                <div class=\"caption\">\r\n                    <p>Name: ");
#nullable restore
#line 18 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                        Write(game.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <p>Id: ");
#nullable restore
#line 19 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                      Write(game.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <p>Price: ");
#nullable restore
#line 20 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                         Write(game.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                </div>\r\n                <a asp-controller=\"Admin\" asp-action=\"DeleteGame\" asp-route-id=\"");
#nullable restore
#line 22 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                                                           Write(game.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete Game</a>\r\n                <a asp-controller=\"Admin\" asp-action=\"EditGame\" asp-route-id=\"");
#nullable restore
#line 23 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                                                         Write(game.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit Game</a>\r\n            </div>\r\n        </div>\r\n\r\n        -->\r\n");
#nullable restore
#line 28 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
             if ((game.Id != Guid.Empty) && (game.Stock == 0) )
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-4 col-lg-4 col-md-6\" style=\"border-style: groove\">\r\n                    <div class=\"single-product mb-60\">\r\n                        <div class=\"product-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1369, "\"", 1413, 2);
            WriteAttributeValue("", 1375, "data:image/png;base64,", 1375, 22, true);
#nullable restore
#line 34 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
WriteAttributeValue(" ", 1397, game.ImageFile, 1398, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"350\" height=\"500\"");
            BeginWriteAttribute("alt", " alt=\"", 1439, "\"", 1445, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"product-caption\">\r\n                            <h4 align=\"center\">");
#nullable restore
#line 37 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                          Write(game.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h4 align=\"center\">");
#nullable restore
#line 38 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                          Write(game.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                        </div>\r\n                        <div align=\"center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e47f01aaf8a372c2f1da388aab37b0933889701611125", async() => {
                WriteLiteral("Delete Game");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                                                                                       WriteLiteral(game.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e47f01aaf8a372c2f1da388aab37b0933889701613658", async() => {
                WriteLiteral("Edit Game");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
                                                                                                     WriteLiteral(game.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n<a  class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\'", 2174, "\'", 2212, 1);
#nullable restore
#line 49 "C:\Users\Traian\source\repos\GameShop\GameShop\Views\Admin\OutOfStock.cshtml"
WriteAttributeValue("", 2181, Url.Action("AddGame", "Admin"), 2181, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add Game</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameShop.Models.Admins.AdminGamesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
