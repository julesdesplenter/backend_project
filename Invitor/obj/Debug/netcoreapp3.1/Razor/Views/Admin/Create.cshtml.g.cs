#pragma checksum "C:\Users\jules\Documents\school\backend\backend_project\Invitor\Views\Admin\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda326be714141bf3cc5e03f11404198ffc9550f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Create), @"mvc.1.0.view", @"/Views/Admin/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda326be714141bf3cc5e03f11404198ffc9550f", @"/Views/Admin/Create.cshtml")]
    public class Views_Admin_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Invitor.Model.Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jules\Documents\school\backend\backend_project\Invitor\Views\Admin\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Event</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""EventId"" class=""control-label""></label>
                <input asp-for=""EventId"" class=""form-control"" />
                <span asp-validation-for=""EventId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Capacity"" class=""control-label""></label>
                <input asp-for=""Capacity"" class=""form-control"" />
                <span asp-validation-for=""Capacity"" class=""text-danger""");
            WriteLiteral(@"></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CloseDate"" class=""control-label""></label>
                <input asp-for=""CloseDate"" class=""form-control"" />
                <span asp-validation-for=""CloseDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StartTime"" class=""control-label""></label>
                <input asp-for=""StartTime"" class=""form-control"" />
                <span asp-validation-for=""StartTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""dateTime"" class=""control-label""></label>
                <input asp-for=""dateTime"" class=""form-control"" />
                <span asp-validation-for=""dateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </");
            WriteLiteral("form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\jules\Documents\school\backend\backend_project\Invitor\Views\Admin\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Invitor.Model.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
