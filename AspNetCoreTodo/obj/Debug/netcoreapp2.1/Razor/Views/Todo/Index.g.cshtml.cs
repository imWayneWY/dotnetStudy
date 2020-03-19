#pragma checksum "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e3f626d959be47e3bf0bb7b18b354f319b8bff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#line 2 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#line 2 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3f626d959be47e3bf0bb7b18b354f319b8bff8", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
  
  ViewData["Title"] = "Manage your doto list";

#line default
#line hidden
            BeginContext(90, 74, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\n  <div class=\"panel-heading\">");
            EndContext();
            BeginContext(165, 17, false);
#line 7 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
                        Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 160, true);
            WriteLiteral("</div>\n  <table class=\"table table-hover\">\n    <thead>\n      <tr>\n        <td>&#x2714;</td>\n        <td>Item</td>\n        <td>Due</td>\n      </tr>\n    </thead>\n");
            EndContext();
#line 16 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
            BeginContext(387, 106, true);
            WriteLiteral("      <tr>\n        <td>\n          <input type=\"checkbox\" class=\"done-checkbox\">\n        </td>\n        <td>");
            EndContext();
            BeginContext(494, 10, false);
#line 22 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(504, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(523, 21, false);
#line 23 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
       Write(item.DueAt.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(544, 18, true);
            WriteLiteral("</td>\n      </tr>\n");
            EndContext();
#line 25 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(568, 91, true);
            WriteLiteral("  </table>\n  <div class=\"panel-footer add-item-from\">\n    <!-- TODO: Add item form -->\n    ");
            EndContext();
            BeginContext(660, 57, false);
#line 29 "/Users/weiyan/hack/dotnet/AspNetCoreTodo/AspNetCoreTodo/Views/Todo/Index.cshtml"
Write(await Html.PartialAsync("AddItemPartial", new TodoItem()));

#line default
#line hidden
            EndContext();
            BeginContext(717, 16, true);
            WriteLiteral("\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
