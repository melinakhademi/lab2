#pragma checksum "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8abf73329bf028d6c6ff2853e65877d29e3b1aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OldMovies), @"mvc.1.0.view", @"/Views/Home/OldMovies.cshtml")]
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
#line 1 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/_ViewImports.cshtml"
using MovieLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/_ViewImports.cshtml"
using MovieLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8abf73329bf028d6c6ff2853e65877d29e3b1aa", @"/Views/Home/OldMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OldMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
  
    //ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h3>This is a list of movies released before year 2000.</h3>\r\n<p>There are ");
#nullable restore
#line 8 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" movies in this category</p>\r\n\r\n");
#nullable restore
#line 10 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
 foreach (var movie in Model)
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div><a");
            BeginWriteAttribute("href", " href=\"", 265, "\"", 302, 2);
            WriteAttributeValue("", 272, "/Home/MovieDetails/", 272, 19, true);
#nullable restore
#line 12 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
WriteAttributeValue("", 291, movie.Id, 291, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
                                             Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - ");
#nullable restore
#line 12 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
                                                                Write(movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 13 "/Users/melinakhademi/Desktop/lab2/lab2-melinakhademi-main/Views/Home/OldMovies.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
