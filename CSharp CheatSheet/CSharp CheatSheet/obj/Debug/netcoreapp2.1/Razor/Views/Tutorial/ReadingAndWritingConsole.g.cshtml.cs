#pragma checksum "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Tutorial\ReadingAndWritingConsole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30adefc68a0b950703069e80c849cc94826bdf61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tutorial_ReadingAndWritingConsole), @"mvc.1.0.view", @"/Views/Tutorial/ReadingAndWritingConsole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tutorial/ReadingAndWritingConsole.cshtml", typeof(AspNetCore.Views_Tutorial_ReadingAndWritingConsole))]
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
#line 1 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\_ViewImports.cshtml"
using CSharp_CheatSheet;

#line default
#line hidden
#line 2 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\_ViewImports.cshtml"
using CSharp_CheatSheet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30adefc68a0b950703069e80c849cc94826bdf61", @"/Views/Tutorial/ReadingAndWritingConsole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f55ead7e6d17a1038fc1229575bae97ccf8c6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Tutorial_ReadingAndWritingConsole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Tutorial\ReadingAndWritingConsole.cshtml"
  
    ViewData["Title"] = "ReadingAndWritingConsole";

#line default
#line hidden
            BeginContext(62, 1063, true);
            WriteLiteral(@"
<h2>ReadingAndWritingConsole</h2>

<div class=""panel panel-default"">
    <div class=""panel-heading"">Introduction</div>
    <div class=""panel-body"">
        <div class=""embed-responsive embed-responsive-16by9"">
            <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/6QcHJ33YrYk"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
        </div>
        <div>Code</div>
        <figure class=""highlight"">
            <pre><code><span>
    using System;

    class Program
    {
    static void Main()
    {
    // Prompt the user for his name
    Console.WriteLine(""Please enter your name"");
    // Read the name from console
    string UserName = Console.ReadLine();
    // Concatenate name with hello word and print
    Console.WriteLine(""Hello "" + UserName);

    //Placeholder syntax to print name with hello word
    //Console.WriteLine(""Hello {0}"", UserName);
    }
    }
</span></code></pre>
");
            WriteLiteral("        </figure>\r\n    </div>\r\n</div>\r\n");
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
