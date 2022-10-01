#pragma checksum "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\Instructor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a6b3066239bc61db04bfe1cd8b18f290e266ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_Index), @"mvc.1.0.view", @"/Views/Instructor/Index.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\_ViewImports.cshtml"
using GUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\_ViewImports.cshtml"
using GUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a6b3066239bc61db04bfe1cd8b18f290e266ee", @"/Views/Instructor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbcbfafbebf67d032365250bdcdb2ec1de59de2", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\Instructor\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""section-header"">
        <h1>Students</h1>
        <div class=""section-header-breadcrumb"">
            <div class=""breadcrumb-item active""><a href=""#"">Home</a></div>
            <div class=""breadcrumb-item""><a href=""#"">Students</a></div>
        </div>
    </div>

    <div class=""section-body"">
        <div class=""row"">

            <div class=""col-12 col-md-12 col-lg-12 "">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4>Students List</h4>
                    </div>
                    <div class=""card-body p-0"">
                        <div class=""table-responsive"">
                            <div id=""datatable_wrapper""
                                 class=""dataTables_wrapper container-fluid dt-bootstrap4 no-footer"">
                                <div class=""dt--top-section"">
                                    <div class=""row"">
                                        <div clas");
            WriteLiteral(@"s=""d-flex justify-content-md-start justify-content-center"">
                                            <div class=""dt-buttons"">
                                                <button class=""dt-button buttons-copy buttons-html5 btn btn-sm""
                                                        tabindex=""0""
                                                        aria-controls=""datatable"">
                                                    <span>Copy</span>
                                                </button>
                                                <button class=""dt-button buttons-csv buttons-html5 btn btn-sm""
                                                        tabindex=""0""
                                                        aria-controls=""datatable"">
                                                    <span>CSV</span>
                                                </button>
                                                <button class=""dt-button buttons-excel buttons-html5 ");
            WriteLiteral(@"btn btn-sm""
                                                        tabindex=""0""
                                                        aria-controls=""datatable"">
                                                    <span>Excel</span>
                                                </button>
                                                <button class=""dt-button buttons-print btn btn-sm""
                                                        tabindex=""0""
                                                        aria-controls=""datatable"">
                                                    <span>Print</span>
                                                </button>
                                            </div>
                                        </div>
                                        <div class=""d-flex justify-content-md-end justify-content-center mt-md-0 mt-3"">
                                            <div id=""datatable_filter"" class=""dataTables_filter"">
                     ");
            WriteLiteral(@"                           <label>
                                                    Search:<input type=""search"" class=""form-control""
                                                                  placeholder=""Search...""
                                                                  aria-controls=""datatable"">
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class=""table-container"">
                                    <ul class=""table-list"">
                                        <li class=""body-table table-1"">
                                            <span>#</span>
                                            <span class=""sort-fill"">
                                                <i class=""fa-solid fa-angle-up hover-sort-up""></i>
                              ");
            WriteLiteral(@"                  <i class=""fa-solid fa-angle-down hover-sort-down""></i>
                                            </span>
                                        </li>
                                        <li class=""body-table table-2"">
                                            <span>Name</span>
                                            <span class=""sort-fill"">
                                                <i class=""fa-solid fa-angle-up hover-sort-up""></i>
                                                <i class=""fa-solid fa-angle-down hover-sort-down""></i>
                                            </span>
                                        </li>
                                        <li class=""body-table table-2"">
                                            <span>Email</span>
                                            <span class=""sort-fill"">
                                                <i class=""fa-solid fa-angle-up hover-sort-up""></i>
                                 ");
            WriteLiteral(@"               <i class=""fa-solid fa-angle-down hover-sort-down""></i>
                                            </span>
                                        </li>
                                        <li class=""body-table table-2"">
                                            <span>Status</span>
                                            <span class=""sort-fill"">
                                                <i class=""fa-solid fa-angle-up hover-sort-up""></i>
                                                <i class=""fa-solid fa-angle-down hover-sort-down""></i>
                                            </span>
                                        </li>
                                        <li class=""body-table table-2"">
                                            <span>Action</span>
                                            <span class=""sort-fill"">
                                                <i class=""fa-solid fa-angle-up hover-sort-up""></i>
                                 ");
            WriteLiteral(@"               <i class=""fa-solid fa-angle-down hover-sort-down""></i>
                                            </span>
                                        </li>
                                    </ul>
                                    <ul class=""table-list"" id=""list_instructor"">
                                    </ul>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    $.ajax({
        type: 'GET',
        url: ""http://localhost:57678/Instructor"",
        success: function (data) {
            $.each(data, function (key, value) {
                var status
                if (value.status == true) {
                    status = 'Active'
                    $('#list_instructor').append(
                        `<l");
            WriteLiteral(@"i class=""body-table table-1"">
                            <span>1</span>
                        </li>
                        <li class=""body-table table-2"">
                            <span>${value.name}</span>
                        </li>
                        <li class=""body-table table-2"">
                            <span>${value.email}</span>
                        </li>
                        <li class=""body-table table-2 table-status"">
                            <span class=""body-status"">${status}</span>
                        </li>
                        <li class=""body-table table-2"">
                            <button type=""button"" class=""btn-block"">Block</button>
                        </li>`
                    );
                } else {
                    status = 'De-Active'
                    $('#list_instructor').append(
                        `<li class=""body-table table-1"">
                            <span>1</span>
                        </li>
       ");
            WriteLiteral(@"                 <li class=""body-table table-2"">
                            <span>${value.username}</span>
                        </li>
                        <li class=""body-table table-2"">
                            <span>${value.email}</span>
                        </li>
                        <li class=""body-table table-2 table-status"">
                            <span class=""body-status"">${status}</span>
                        </li>
                        <li class=""body-table table-2"">
                            <button type=""button"" class=""btn-block"">Active</button>
                        </li>`
                    );
                }

            });
        },
    });
</script>

");
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
