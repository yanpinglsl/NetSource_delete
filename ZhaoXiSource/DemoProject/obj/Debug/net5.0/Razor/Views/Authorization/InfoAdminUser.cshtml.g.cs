#pragma checksum "D:\架构学习\Source\ZhaoXiSource\DemoProject\Views\Authorization\InfoAdminUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7a0db591705d5faeeda42f269a67087a75d4f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorization_InfoAdminUser), @"mvc.1.0.view", @"/Views/Authorization/InfoAdminUser.cshtml")]
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
#line 1 "D:\架构学习\Source\ZhaoXiSource\DemoProject\Views\_ViewImports.cshtml"
using DemoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\架构学习\Source\ZhaoXiSource\DemoProject\Views\_ViewImports.cshtml"
using DemoProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc7a0db591705d5faeeda42f269a67087a75d4f1", @"/Views/Authorization/InfoAdminUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5c02823e45e62b1549594c69f9b51e88914cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_InfoAdminUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\架构学习\Source\ZhaoXiSource\DemoProject\Views\Authorization\InfoAdminUser.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>InfoAdminUser</h1>\r\n<h3>UserName:");
#nullable restore
#line 7 "D:\架构学习\Source\ZhaoXiSource\DemoProject\Views\Authorization\InfoAdminUser.cshtml"
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
