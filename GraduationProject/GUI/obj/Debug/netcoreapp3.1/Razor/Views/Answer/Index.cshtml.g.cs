#pragma checksum "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\Answer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a75c842af09e420af3e1abffc1f08ecce9d6232c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answer_Index), @"mvc.1.0.view", @"/Views/Answer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a75c842af09e420af3e1abffc1f08ecce9d6232c", @"/Views/Answer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbcbfafbebf67d032365250bdcdb2ec1de59de2", @"/Views/_ViewImports.cshtml")]
    public class Views_Answer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\Answer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_InstructorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"" id=""create_course"">
    <div class=""row"" id=""course_form"">
        <div class=""col-md-8"">
            <div class=""my_courses_tabs"">
                <div class=""tab-content"" id=""pills-tabContent"">
                    <div class=""tab-pane fade show active"" id=""pills-my-courses"" role=""tabpanel"">
                        <div class=""table-responsive mt-30"">
                            <table class=""table ucp-table"">
                                <thead class=""thead-s"">
                                    <tr>
                                        <th class=""text-center"" scope=""col"">#</th>
                                        <th class=""text-center"" scope=""col"">Title</th>
                                        <th class=""text-center"" scope=""col"">Action</th>
                                    </tr>
                                </thead>
                                <tbody id=""list_answer"">
                                </tbody>
                         ");
            WriteLiteral(@"   </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""top_countries col-md-4"">
            <div class=""top_countries_title"">
                <h2>Add Answer</h2>
            </div>
            <div class=""payout_content"">
                <div class=""explore_search"">
                    <div class=""ui search focus"">
                        <label>Title</label>
                        <div class=""ui input swdh11 swdh15"" id=""input_Qid"">

                            <input class=""prompt srch_explore"" id=""answer_title"" type=""text"" placeholder=""Enter Title"" name=""amount""");
            BeginWriteAttribute("required", " required=\"", 1803, "\"", 1814, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>
            </div>
            <div class=""payout_content"">
                <button type=""submit"" onclick=""create_answer()"" class=""payout__btn"">Add Answer</button>
            </div>
        </div>
    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    $.ajax({
        type: 'GET',
        url: ""http://localhost:57678/Course/Quizz/");
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Documents\GraduationProject\GUI\Views\Answer\Index.cshtml"
                                             Write(ViewBag.sectionId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        success: function (data) {

            $.each(data, function (key, value) {
                $.each(value.question, function (key, value1) {
                    $.each(value1.answer, function (key, value2) {
                        $('#input_Qid').append(
                            `<input id=""ques_id"" type=""hidden"" value=""${value2.questionId}"">`
                        );
                        $('#list_answer').append(
                            `
                            <tr>
                                <td class=""text-center"">1</td>
                                <td class=""text-center"">${value2.title}</td>
                                <td class=""text-center d-flex justify-content-center"">
                                    <button class=""create_btn_dash"" onclick=""delete_lecture_course('${value2.id}')"">Delete</button>
                                </td>
                            </tr>`
                        );
                    });
                });
            WriteLiteral(@"
            });
        },
    });

    function create_answer() {
        var title = $(""#answer_title"").val();
        var id = $(""#ques_id"").val();
        $.ajax({
            url: ""http://localhost:57678/Courses/Answer"",
            type: ""POST"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            data: JSON.stringify({ 'id': id, 'answer': title }),
            success: function (data) {
                location.reload();
            },
            error: function (e) {
                alert(""fail"")
                console.log('Error in Operation');
            }
        });
    }

    //function delete_lecture_course(id) {
    //    $.ajax({
    //        url: ""http://localhost:57678/Course/Lecture/Delete/"" + id,
    //        type: ""put"",
    //        contentType: ""application/json"",
    //        success: function () {
    //            location.reload();
    //        }
    //    })
    //}


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