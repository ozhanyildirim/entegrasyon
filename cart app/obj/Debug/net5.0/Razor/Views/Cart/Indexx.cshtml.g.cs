#pragma checksum "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f79c9d6dad1160508216beeb3ba55894913e18d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Indexx), @"mvc.1.0.view", @"/Views/Cart/Indexx.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f79c9d6dad1160508216beeb3ba55894913e18d", @"/Views/Cart/Indexx.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa03e3cc25d07a0f100f921df82eedd544eae3c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Indexx : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f79c9d6dad1160508216beeb3ba55894913e18d3386", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f79c9d6dad1160508216beeb3ba55894913e18d4356", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml"
     foreach (var product in ViewBag.products)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 337, "\"", 357, 1);
#nullable restore
#line 19 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml"
WriteAttributeValue("", 343, product.Photo, 343, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 21 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml"
                                              Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml"
                                            Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ??? </p>\r\n                            <a href=\"#\" class=\"btn btn-primary\">Sepete Ekle</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\OZHAN\source\repos\cart app\cart app\Views\Cart\Indexx.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 2031, "\"", 2038, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">??DEME YAP</a>\r\n\r\n\r\n");
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
