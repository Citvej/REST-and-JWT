#pragma checksum "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42236879130c0dff79d1a133c0e989f3a93ca3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Novices_Index), @"mvc.1.0.view", @"/Views/Novices/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Novices/Index.cshtml", typeof(AspNetCore.Views_Novices_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42236879130c0dff79d1a133c0e989f3a93ca3b", @"/Views/Novices/Index.cshtml")]
    public class Views_Novices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rain51.Controllers.Novice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Index.cshtml";

#line default
#line hidden
            BeginContext(128, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(287, 41, false);
#line 17 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.datum));

#line default
#line hidden
            EndContext();
            BeginContext(328, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(384, 41, false);
#line 20 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.avtor));

#line default
#line hidden
            EndContext();
            BeginContext(425, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(481, 44, false);
#line 23 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.besedilo));

#line default
#line hidden
            EndContext();
            BeginContext(525, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(643, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(692, 40, false);
#line 32 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.datum));

#line default
#line hidden
            EndContext();
            BeginContext(732, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(788, 40, false);
#line 35 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.avtor));

#line default
#line hidden
            EndContext();
            BeginContext(828, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(884, 43, false);
#line 38 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.besedilo));

#line default
#line hidden
            EndContext();
            BeginContext(927, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1002, "\"", 1031, 1);
#line 41 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
WriteAttributeValue("", 1017, item.NoviceId, 1017, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1032, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1084, "\"", 1113, 1);
#line 42 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
WriteAttributeValue("", 1099, item.NoviceId, 1099, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1114, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1168, "\"", 1197, 1);
#line 43 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
WriteAttributeValue("", 1183, item.NoviceId, 1183, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1198, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Neven\Documents\GitHub\REST-and-JWT\Project\Rain51\Views\Novices\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1248, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rain51.Controllers.Novice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
