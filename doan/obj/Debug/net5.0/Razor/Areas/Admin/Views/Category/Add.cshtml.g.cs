#pragma checksum "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Category\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b16dfad7029e0cf7583dd75b7d484e7a381034e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b16dfad7029e0cf7583dd75b7d484e7a381034e", @"/Areas/Admin/Views/Category/Add.cshtml")]
    public class Areas_Admin_Views_Category_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Category\Add.cshtml"
  
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
                        <h3 class=""card-title"">Category add</h3>
                    </div>
                    <div class=""card card-primary"">

                        <!-- /.card-header -->
                        <!-- form start -->
");
#nullable restore
#line 17 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Category\Add.cshtml"
                         using (Html.BeginForm())
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-body\">\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"name\">Name</label>\r\n                                        ");
#nullable restore
#line 23 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Category\Add.cshtml"
                                   Write(Html.TextBoxFor(c => c.Name , new {@class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                    </div>\r\n                                    <div class=\"form-check\">\r\n                                        ");
#nullable restore
#line 26 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Category\Add.cshtml"
                                   Write(Html.CheckBoxFor(c => c.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                      
                                        <label class=""form-check-label"" for=""status"">Status</label>
                                    </div>
                                </div>
                                <!-- /.card-body -->
");
            WriteLiteral("                                <div class=\"card-footer\">\r\n                                    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n                                </div>\r\n");
#nullable restore
#line 35 "E:\HSC\Đò án tốt nghiệp\Back-End\doan\DoAn\Areas\Admin\Views\Category\Add.cshtml"
                                       
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!-- /.card -->\r\n\r\n            </div>\r\n            <!-- /.col -->\r\n        </div>\r\n        <!-- /.row -->\r\n    </div>\r\n    <!-- /.container-fluid -->\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591