#pragma checksum "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525cc5e46044346f6296c84255a792cd2f29e6f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gallery_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Gallery/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525cc5e46044346f6296c84255a792cd2f29e6f8", @"/Areas/Admin/Views/Gallery/Add.cshtml")]
    public class Areas_Admin_Views_Gallery_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn.Models.Image>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"" >Add image to   ");
#nullable restore
#line 11 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
                                                          Write(ViewBag.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                    <daiv class=""card card-primary"">
                        <form method=""post"" asp-controller=""gallery"" asp-action=""add"" enctype=""multipart/form-data"">
                            <div class=""card-body"">
                                <div class=""form-group"">
                                    <label for=""name"">Name</label>
                                    ");
#nullable restore
#line 18 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
                               Write(Html.TextBoxFor(c => c.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"desciption\">Desciption</label>\r\n                                    ");
#nullable restore
#line 22 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
                               Write(Html.TextBoxFor(c => c.Desciption, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""form-group"">
                                    <label for=""exampleInputFile"">File input</label>
                                    <div class=""custom-file"">
                                        <input type=""file"" class=""custom-file-input"" name=""fileUpload"" id=""customFile"">
                                        <label class=""custom-file-label""></label>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""form-check"">
                                        ");
#nullable restore
#line 33 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
                                   Write(Html.CheckBoxFor(c => c.Featured));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <label class=""form-check-label"" for=""status"">Featured</label>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""form-check"">
                                        ");
#nullable restore
#line 39 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
                                   Write(Html.CheckBoxFor(c => c.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <label class=""form-check-label"" for=""status"">Status</label>
                                    </div>
                                </div>
                                <div class=""form-group"" hidden>
                                    <div class=""form-check"">
                                        ");
#nullable restore
#line 45 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Gallery\Add.cshtml"
                                   Write(Html.TextBoxFor(c => c.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <label class=""form-check-label"" for=""status"">Featured</label>
                                    </div>
                                </div>
                            </div>
                            <!-- /.card-body -->
                            <div class=""card-footer"">
                                <button type=""submit"" class=""btn btn-primary"">Save</button>
                            </div>
                        </form>
                    </daiv>
                </div>
                <!-- /.card -->

            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    $(function () {\r\n        bsCustomFileInput.init();\r\n    });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn.Models.Image> Html { get; private set; }
    }
}
#pragma warning restore 1591