#pragma checksum "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e95e3a16e0d97cccf6a6ab5bf7f85e928a4ed89c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\_ViewImports.cshtml"
using cart_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\_ViewImports.cshtml"
using cart_app.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95e3a16e0d97cccf6a6ab5bf7f85e928a4ed89c", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa03e3cc25d07a0f100f921df82eedd544eae3c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
  

    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95e3a16e0d97cccf6a6ab5bf7f85e928a4ed89c3447", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e95e3a16e0d97cccf6a6ab5bf7f85e928a4ed89c4417", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
         foreach (var product in ViewBag.products)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-sm-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">\r\n                            ");
#nullable restore
#line 21 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
                       Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    \r\n                        </h5>\r\n                        <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 543, "\"", 563, 1);
#nullable restore
#line 24 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
WriteAttributeValue("", 549, product.Photo, 549, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">\r\n                                ");
#nullable restore
#line 27 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
                           Write(product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h5>\r\n                            <h5");
                BeginWriteAttribute("href", " href=\"", 804, "\"", 811, 0);
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 812, "\"", 820, 0);
                EndWriteAttribute();
                WriteLiteral("> Price : ");
#nullable restore
#line 29 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
                                                     Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"
                                                                    Write(product.Currency);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n    </div>\r\n    <div class=\"card-footer\">\r\n        Total Price : 610.99 ???\r\n    </div>\r\n    <br />\r\n   \r\n    <a href=\"https://www.payjinn.com/PinTAN/UbwPTStep1?SessionCode=10000040051-038156175010\" class=\"btn btn-success\">??DEME YAP</a>\r\n\r\n \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
