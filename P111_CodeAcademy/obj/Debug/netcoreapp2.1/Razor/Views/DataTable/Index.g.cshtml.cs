#pragma checksum "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\DataTable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "253c7a39440130f12da4d2212bfa840a22c5ef6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataTable_Index), @"mvc.1.0.view", @"/Views/DataTable/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DataTable/Index.cshtml", typeof(AspNetCore.Views_DataTable_Index))]
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
#line 1 "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\_ViewImports.cshtml"
using P111_CodeAcademy.Models;

#line default
#line hidden
#line 2 "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\_ViewImports.cshtml"
using P111_CodeAcademy.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253c7a39440130f12da4d2212bfa840a22c5ef6c", @"/Views/DataTable/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066dcdb60183ecdf4e3f7ba650ae6df3c2731fda", @"/Views/_ViewImports.cshtml")]
    public class Views_DataTable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\DataTable\Index.cshtml"
  
    ViewData["Title"] = "DataTable";
    Layout = "~/Views/Shared/_Layoutpages.cshtml";

#line default
#line hidden
            BeginContext(99, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(106, 13, false);
#line 7 "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\DataTable\Index.cshtml"
Write(ViewBag.Table);

#line default
#line hidden
            EndContext();
            BeginContext(119, 18811, true);
            WriteLiteral(@"</h3>



<main>
    <section id=""title"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""content_title"">
                        <h1>
                            Data Tables
                        </h1>
                        <p>Inspiration comes of working every day.</p>
                    </div>
                    <div class=""content_link"">
                        <ul>
                            <li class=""after""><a href=""#"">Shortcodes</a></li>
                            <li class=""after""><a href=""#"">Shortcodes </a></li>
                            <li><a href=""#"">Accordion</a></li>

                        </ul>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <table id=""datatable"" class=""table table-bordered table-hover dataTable"" style=""width: 100%;""
                       role=""grid"" aria-describedby=""datatable_info"">
  ");
            WriteLiteral(@"                  <thead>
                        <tr role=""row"">
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
                                aria-label=""Name: activate to sort column ascending"" style=""width: 122px;"">Name</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
                                aria-label=""Position: activate to sort column ascending"" style=""width: 193px;"">
                                Position
                            </th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
                                aria-label=""Office: activate to sort column ascending"" style=""width: 84px;"">
                                Office
                            </th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
               ");
            WriteLiteral(@"                 aria-label=""Age: activate to sort column ascending"" style=""width: 42px;"">Age</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
                                aria-label=""Date: activate to sort column ascending"" style=""width: 71px;"">Date</th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
                                aria-label=""Salary: activate to sort column ascending"" style=""width: 68px;"">
                                Salary
                            </th>
                            <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1""
                                aria-label=""Status: activate to sort column ascending"" style=""width: 69px;"">
                                Status
                            </th>
                            <th class=""noExport sorting_asc"" tabindex=""0"" aria-controls=""datatable"" r");
            WriteLiteral(@"owspan=""1""
                                colspan=""1"" aria-label=""Actions: activate to sort column descending""
                                style=""width: 70px;"" aria-sort=""ascending"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr role=""row"" class=""odd"">
                            <td class="""">Airi Satou</td>
                            <td>Accountant</td>
                            <td>Tokyo</td>
                            <td>33</td>
                            <td>2008/11/28</td>
                            <td>$162,700</td>
                            <td><span class=""badge badge-pill badge-secondary"">Inactive</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                          ");
            WriteLiteral(@"      <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>
                        <tr role=""row"" class=""even"">
                            <td class="""">Angelica Ramos</td>
                            <td>Chief Executive Officer (CEO)</td>
                            <td>London</td>
                            <td>47</td>
                            <td>2009/10/09</td>
                            <td>$1,200,000</td>
                            <td><span class=""badge badge-pill badge-warning"">In progress</span></td>
                            <td class=""sorting_1"">
                             ");
            WriteLiteral(@"   <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>

                        <tr role=""row"" class=""odd"">
                            <td class="""">Angelica Ramos</td>
                            <td>Chief Executive Officer (CEO)</td>
                            <td>London</td>
                            <td>47</td>
                            <td>2009/10/09</td>
                       ");
            WriteLiteral(@"     <td>$1,200,000</td>
                            <td><span class=""badge badge-pill badge-warning"">In progress</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>

                        <tr role=""row"" class=""even"">
                            <td class="""">Ashton Cox</td>
                    ");
            WriteLiteral(@"        <td>Junior Technical Author</td>
                            <td>San Francisco</td>
                            <td>66</td>
                            <td>2009/01/12</td>
                            <td>$86,000</td>
                            <td><span class=""badge badge-pill badge-secondary"">Inactive</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a");
            WriteLiteral(@">
                            </td>
                        </tr>

                        <tr role=""row"" class=""odd"">
                            <td class="""">Ashton Cox</td>
                            <td>Junior Technical Author</td>
                            <td>San Francisco</td>
                            <td>66</td>
                            <td>2009/01/12</td>
                            <td>$86,000</td>
                            <td><span class=""badge badge-pill badge-secondary"">Inactive</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
          ");
            WriteLiteral(@"                      <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>

                        <tr role=""row"" class=""even"">
                            <td class="""">Bradley Greer</td>
                            <td>Software Engineer</td>
                            <td>London</td>
                            <td>41</td>
                            <td>2012/10/13</td>
                            <td>$132,000</td>
                            <td><span class=""badge badge-pill badge-info"">Pending</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class");
            WriteLiteral(@"=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>


                        <tr role=""row"" class=""odd"">
                            <td class="""">Brenden Wagner</td>
                            <td>Software Engineer</td>
                            <td>San Francisco</td>
                            <td>28</td>
                            <td>2011/06/07</td>
                            <td>$206,850</td>
                            <td><span class=""badge badge-pill badge-warning"">In progress</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2""");
            WriteLiteral(@" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>
                        <tr role=""row"" class=""even"">
                            <td class="""">Brielle Williamson</td>
                            <td>Integration Specialist</td>
                            <td>New York</td>
                            <td>61</td>
                            <td>2012/12/02</td>
                            <td>$372,000</t");
            WriteLiteral(@"d>
                            <td><span class=""badge badge-pill badge-secondary"">Inactive</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>
                        <tr role=""row"" class=""odd"">
                            <td class="""">Bruno Nash</td>
                            <td>Software Engin");
            WriteLiteral(@"eer</td>
                            <td>London</td>
                            <td>38</td>
                            <td>2011/05/03</td>
                            <td>$163,500</td>
                            <td><span class=""badge badge-pill badge-success"">Completed</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
 ");
            WriteLiteral(@"                       </tr>
                        <tr role=""row"" class=""even"">
                            <td class="""">Caesar Vance</td>
                            <td>Pre-Sales Support</td>
                            <td>New York</td>
                            <td>21</td>
                            <td>2011/12/12</td>
                            <td>$106,450</td>
                            <td><span class=""badge badge-pill badge-warning"">In progress</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" ");
            WriteLiteral(@"data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>
                        <tr role=""row"" class=""odd"">
                            <td class="""">Cara Stevens</td>
                            <td>Sales Assistant</td>
                            <td>New York</td>
                            <td>46</td>
                            <td>2011/12/06</td>
                            <td>$145,600</td>
                            <td><span class=""badge badge-pill badge-primary"">Active</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-origi");
            WriteLiteral(@"nal-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>
                        <tr role=""row"" class=""even"">
                            <td class="""">Cedric Kelly</td>
                            <td>Senior Javascript Developer</td>
                            <td>Edinburgh</td>
                            <td>22</td>
                            <td>2012/03/29</td>
                            <td>$433,060</td>
                            <td><span class=""badge badge-pill badge-secondary"">Inactive</span></td>
                            <td class=""sorting_1"">
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-tit");
            WriteLiteral(@"le=""Edit"">
                                    <i class=""far fa-edit""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Delete"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                                <a class=""ml-2"" href=""#"" data-toggle=""tooltip"" data-original-title=""Settings"">
                                    <i class=""fas fa-cogs""></i>
                                </a>
                            </td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <th rowspan=""1"" colspan=""1"">Name</th>
                            <th rowspan=""1"" colspan=""1"">Position</th>
                            <th rowspan=""1"" colspan=""1"">Office</th>
                            <th rowspan=""1"" colspan=""1"">Age</th>
                            <th rowspan=""1"" cols");
            WriteLiteral(@"pan=""1"">Date</th>
                            <th rowspan=""1"" colspan=""1"">Salary</th>
                            <th rowspan=""1"" colspan=""1"">Status</th>
                            <th rowspan=""1"" colspan=""1"">Actions</th>
                        </tr>
                    </tfoot>
                </table>
            </div>

        </div>
    </section>

</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
