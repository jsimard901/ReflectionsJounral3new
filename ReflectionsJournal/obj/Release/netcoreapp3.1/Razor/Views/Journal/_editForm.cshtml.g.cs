#pragma checksum "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0c68a9dad4f12bb259b894a1b82e0ae128d617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal__editForm), @"mvc.1.0.view", @"/Views/Journal/_editForm.cshtml")]
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
#line 1 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\_ViewImports.cshtml"
using ReflectionsJournal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\_ViewImports.cshtml"
using ReflectionsJournal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0c68a9dad4f12bb259b894a1b82e0ae128d617", @"/Views/Journal/_editForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6650f946d2652828592b0adb7bd3bbb5bb37ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal__editForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionsJournal.Models.EntryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 5 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.LabelFor(e => e.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.TextBoxFor(e => e.id, new{@class = "form-control", @readonly = "readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  \r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 13 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.LabelFor(e => e.entryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.TextBoxFor(e => e.entryDate, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.ValidationMessageFor(e => e.entryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.LabelFor(e => e.entryText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.TextAreaFor(e => e.entryText, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.ValidationMessageFor(e => e.entryText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 29 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.LabelFor(e => e.confidenceLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.TextBoxFor(e => e.confidenceLevel, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\student\Code_School\concepts_3\ReflectionsJounral3new\ReflectionsJournal\Views\Journal\_editForm.cshtml"
Write(Html.ValidationMessageFor(e => e.confidenceLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionsJournal.Models.EntryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
