#pragma checksum "D:\架构学习\Source\ZhaoXiSource\AuthProject\Views\Authorization\InfoUserPolicy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e23fde5badb3e393735cab29fdb22d7614c235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorization_InfoUserPolicy), @"mvc.1.0.view", @"/Views/Authorization/InfoUserPolicy.cshtml")]
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
#line 1 "D:\架构学习\Source\ZhaoXiSource\AuthProject\Views\_ViewImports.cshtml"
using AuthProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\架构学习\Source\ZhaoXiSource\AuthProject\Views\_ViewImports.cshtml"
using AuthProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e23fde5badb3e393735cab29fdb22d7614c235", @"/Views/Authorization/InfoUserPolicy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f64d6c09ad739a7a4e682bfe521f8773f215187", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_InfoUserPolicy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\架构学习\Source\ZhaoXiSource\AuthProject\Views\Authorization\InfoUserPolicy.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>InfoUserPolicy</h1>\r\n<h3>UserName:");
#nullable restore
#line 7 "D:\架构学习\Source\ZhaoXiSource\AuthProject\Views\Authorization\InfoUserPolicy.cshtml"
        Write(base.Context.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
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
