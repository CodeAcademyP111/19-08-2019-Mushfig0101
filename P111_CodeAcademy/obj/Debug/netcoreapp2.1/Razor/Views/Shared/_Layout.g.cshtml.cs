#pragma checksum "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c690dcbb7c00c94e072ddbdd9a89c393eb70e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c690dcbb7c00c94e072ddbdd9a89c393eb70e94", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066dcdb60183ecdf4e3f7ba650ae6df3c2731fda", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/scss/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo/logo-in_img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo/logo-in_page.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/JS/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 990, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee9d8906f8124be285159f298d716cbf", async() => {
                BeginContext(43, 176, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>");
                EndContext();
                BeginContext(220, 13, false);
#line 8 "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(233, 738, true);
                WriteLiteral(@"</title>

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">

    <link href=""https://npmcdn.com/flickity@2/dist/flickity.css"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Josefin+Slab|Monoton&display=swap"" rel=""stylesheet"">

    <link href=""https://fonts.googleapis.com/css?family=Merriweather+Sans:400,700&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.2/css/all.css"">
    <link rel=""stylesheet"" href=""https://unpkg.com/flickity@2/dist/flickity.min.css"">
    <!-- up start -->
    <link href=""https://unpkg.com/aos@2.3.1/dist/aos.css"" rel=""stylesheet"">
    <!-- uo end -->
    ");
                EndContext();
                BeginContext(971, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7fc65669d1fc48b79aa31ca79275c033", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1018, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1027, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1031, 10534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6abddc478bc0477da063b9e9139b0b6b", async() => {
                BeginContext(1037, 190, true);
                WriteLiteral("\r\n    <header class=\"fixed-top\">\r\n        <div class=\"container\">\r\n            <nav class=\"navbar navbar-expand-lg navbar-light\">\r\n                <a class=\"navbar-brand logowhite\" href=\"#\">");
                EndContext();
                BeginContext(1227, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cbd6980cd01a4e7e9edb60c52b41f8fc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1265, 65, true);
                WriteLiteral("</a>\r\n                <a class=\"navbar-brand logoblack\" href=\"#\">");
                EndContext();
                BeginContext(1330, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41871799c064468bb9283203b30e45ce", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1369, 4287, true);
                WriteLiteral(@"</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup""
                        aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-end"" id=""navbarNavAltMarkup"">
                    <ul class=""navbar-nav menu"">
                        <li class=""menu-item"">
                            <a class=""nav-item nav-link active"" href=""#"">Home </a>
                        </li>
                        <li class=""menu-item"">
                            <a class=""nav-item nav-link active"" href=""#"">Layout</a>
                            <ul class=""dropdown-menu"">
                                <li class=""dropdown-item""><a href=""#"">Topbar</a></li>
                                <li class=""dropdown-item""><a href=""#"">Header</a></li>
                   ");
                WriteLiteral(@"             <li class=""dropdown-item""><a href=""#"">Mainmenu</a></li>
                                <li class=""dropdown-item""><a href=""#"">Page Title</a></li>
                                <li class=""dropdown-item""><a href=""#"">Page Menu</a></li>
                                <li class=""dropdown-item""><a href=""#"">Sidebars</a></li>
                                <li class=""dropdown-item""><a href=""#"">Footers</a></li>
                                <li class=""dropdown-item""><a href=""#"">Footers</a></li>
                                <li class=""dropdown-item""><a href=""#"">Layout Demos</a></li>
                            </ul>
                        </li>
                        <li class=""menu-item"">
                            <a class=""nav-item nav-link active"" href=""#"">Features</a>
                            <ul class=""dropdown-menu"">
                                <li class=""dropdown-item""><a href=""#"">Sliders</a></li>
                                <li class=""dropdown-item""><a href=""#"">");
                WriteLiteral(@"Widjets</a></li>
                                <li class=""dropdown-item""><a href=""#"">Page Loaders</a></li>
                                <li class=""dropdown-item""><a href=""#"">Modal Auto Open</a></li>
                                <li class=""dropdown-item""><a href=""#"">Cookie Notify</a></li>
                                <li class=""dropdown-item""><a href=""#"">Menu labels</a></li>
                            </ul>
                        </li>
                        <li class=""menu-item""><a class=""nav-item nav-link active"" href=""#"">Elements</a></li>
                        <li class=""menu-item"">
                            <a class=""nav-item nav-link active"" href=""#"">Pages</a>

                            <ul class=""dropdown-menu"">
                                <li class=""dropdown-item""><a href=""#"">About us</a></li>
                                <li class=""dropdown-item""><a href=""#"">Contact us</a></li>
                                <li class=""dropdown-item""><a href=""#"">User page</a></");
                WriteLiteral(@"li>
                                <li class=""dropdown-item""><a href=""#"">Services</a></li>
                                <li class=""dropdown-item""><a href=""#"">Our tem</a></li>
                                <li class=""dropdown-item""><a href=""#"">Our clients</a> </li>
                                <li class=""dropdown-item""><a href=""#"">About us</a></li>
                                <li class=""dropdown-item""><a href=""#"">Maintenance</a></li>
                                <li class=""dropdown-item""><a href=""#"">404 page</a></li>
                            </ul>
                        </li>
                        <li class=""menu-item"">
                            <a class=""nav-item nav-link active"" href=""#"">Portfolio </a>
                        </li>
                        <li class=""menu-item"">
                            <a class=""nav-item nav-link active"" href=""#"">Blog </a>
                        </li>
                        <li class=""menu-item"">
                            <a cla");
                WriteLiteral("ss=\"nav-item nav-link active\" href=\"#\">Shop </a>\r\n                        </li>\r\n\r\n\r\n                    </ul>\r\n                </div>\r\n            </nav>\r\n        </div>\r\n    </header>\r\n    ");
                EndContext();
                BeginContext(5657, 12, false);
#line 96 "C:\Users\Code\source\repos\P111_CodeAcademy\P111_CodeAcademy\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5669, 5851, true);
                WriteLiteral(@"

    <footer>
        <section id=""footer"">
            <div class=""container-fluid"">
                <div class=""row justify-content-center align-items-center text-center"">
                    <div class=""col-md-4"">
                        <div class=""footer_left_content"">
                            <h4>POLO HTML5 TEMPLATE</h4>
                            <p>
                                Built with love in Fort Worth, Texas, USA<br>
                                All rights reserved. Copyright © 2019. INSPIRO.
                            </p>
                            <a href=""#"" class=""btn btn-inverted"">Purchase Now</a>
                        </div>
                    </div>


                    <div class=""col-md-8"">
                        <div class=""row"">
                            <div class=""col-md-3"">
                                <div class=""widget"">
                                    <span>discover</span>
                                    <ul>
              ");
                WriteLiteral(@"                          <li><a href=""#"">Features</a></li>
                                        <li><a href=""#"">Layouts</a></li>
                                        <li><a href=""#"">Corporate</a></li>
                                        <li><a href=""#"">Updates</a></li>
                                        <li><a href=""#"">Pricing</a></li>
                                        <li><a href=""#"">Customers</a></li>

                                    </ul>

                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""widget"">
                                    <span>features</span>
                                    <ul>
                                        <li><a href=""#"">Layouts</a></li>
                                        <li><a href=""#"">Headers</a></li>
                                        <li><a href=""#"">Widgets</a></li>
                                     ");
                WriteLiteral(@"   <li><a href=""#"">Footers</a></li>

                                    </ul>

                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""widget"">
                                    <span>pages</span>
                                    <ul>
                                        <li><a href=""#"">Portfolio</a></li>
                                        <li><a href=""#"">Blog </a></li>
                                        <li><a href=""#"">Shop</a></li>
                                    </ul>

                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""widget"">
                                    <span>support</span>
                                    <ul>
                                        <li><a href=""#"">Help Desk</a></li>
                                      ");
                WriteLiteral(@"  <li><a href=""#"">Help Desk</a></li>
                                        <li><a href=""#"">Contact Us</a></li>
                                    </ul>


                                </div>
                            </div>
                        </div>
                    </div>




                </div>
                <div class=""container-fluuid"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""footer_finish justify-content-center align-items-center text-center"">
                                <p>
                                    © 2019 POLO - Responsive Multi-Purpose HTML5 Template. All Rights Reserved.
                                    <a href=""#"">INSPIRO</a>
                                </p>

                            </div>

                        </div>

                    </div>
                </div>





            </div>
            <a class=""up"">
              ");
                WriteLiteral(@"  <i class=""fas fa-chevron-up""></i>
            </a>
        </section>
    </footer>

    <script>
        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the image and insert it inside the modal - use its ""alt"" text as a caption
        var show = document.getElementById(""showImg"");
        var img = document.getElementById(""myImg"");
        var modalImg = document.getElementById(""img01"");
        var captionText = document.getElementById(""caption"");
        show.onclick = function () {
            modal.style.display = ""block"";
            modalImg.src = img.src;
            captionText.innerHTML = this.alt;
        }

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = ""none"";
        }
    </script>

    <script src=""https://code.jquery");
                WriteLiteral(@".com/jquery-3.3.1.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/flickity/2.2.0/flickity.pkgd.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/gsap/2.1.3/TweenMax.min.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
    <!-- up start -->
    <script src=""https://unpkg.com/aos@2.3.1/dist/aos.js""></script>
    <!-- up end -->
    <script src=""https://npmcdn.com/flickity@2/dist/flickity.pkgd.js""></script>
    ");
                EndContext();
                BeginContext(11520, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29618f92d3d49d9b45423c26a211db8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11556, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11565, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
