#pragma checksum "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317e662270bf4db7ec2f0024e4ece5f464e057fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotels_Index), @"mvc.1.0.view", @"/Views/Hotels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317e662270bf4db7ec2f0024e4ece5f464e057fd", @"/Views/Hotels/Index.cshtml")]
    public class Views_Hotels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AsyncHotel.Models.Hotel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1551, "\"", 1574, 1);
#nullable restore
#line 58 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
WriteAttributeValue("", 1566, item.Id, 1566, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1627, "\"", 1650, 1);
#nullable restore
#line 59 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
WriteAttributeValue("", 1642, item.Id, 1642, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1705, "\"", 1728, 1);
#nullable restore
#line 60 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
WriteAttributeValue("", 1720, item.Id, 1720, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\gordn\Documents\projects\codefellows\401net\AsyncHotel\AsyncHotel\AsyncHotel\Views\Hotels\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AsyncHotel.Models.Hotel>> Html { get; private set; }
    }
}
#pragma warning restore 1591