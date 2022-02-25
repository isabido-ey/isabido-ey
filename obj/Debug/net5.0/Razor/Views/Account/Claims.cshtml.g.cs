#pragma checksum "C:\Users\KH339JK\Downloads\Auth0StrataSample\Views\Account\Claims.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ef8bdfaed2f494936fabd0eb03c33abd670173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Claims), @"mvc.1.0.view", @"/Views/Account/Claims.cshtml")]
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
#line 1 "C:\Users\KH339JK\Downloads\Auth0StrataSample\Views\_ViewImports.cshtml"
using SampleMvcApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ef8bdfaed2f494936fabd0eb03c33abd670173", @"/Views/Account/Claims.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0c17365c09780748b3fa13ad5cc14fc4bde2f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Claims : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">

        <h3>Claims associated with current User</h3>
        <p>This page displays all the claims associated the the current User. This is useful when debugging to see which claims are being populated from the Auth0 ID Token.</p>

        <table class=""table"">
            <thead>
            <tr>
                <th>
                    Claim
                </th>
                <th>
                    Value
                </th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "C:\Users\KH339JK\Downloads\Auth0StrataSample\Views\Account\Claims.cshtml"
             foreach (var claim in User.Claims)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 22 "C:\Users\KH339JK\Downloads\Auth0StrataSample\Views\Account\Claims.cshtml"
                   Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 23 "C:\Users\KH339JK\Downloads\Auth0StrataSample\Views\Account\Claims.cshtml"
                   Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 25 "C:\Users\KH339JK\Downloads\Auth0StrataSample\Views\Account\Claims.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
