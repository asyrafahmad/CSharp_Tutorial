#pragma checksum "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b0348c4507f2c6b1a2d3bf939c48adf2003784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b0348c4507f2c6b1a2d3bf939c48adf2003784", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f55ead7e6d17a1038fc1229575bae97ccf8c6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheatSheet.Models.ListVideos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 31, true);
            WriteLiteral("\r\n<h2>Tutorial navigator</h2>\r\n");
            EndContext();
#line 7 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"
 foreach (var item in Model.lsVideos)
{

#line default
#line hidden
            BeginContext(152, 70, true);
            WriteLiteral("    <div class=\"col-sm-6 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n");
            EndContext();
            BeginContext(1277, 60, true);
            WriteLiteral("<div class=\"caption\">\r\n    <iframe width=\"100%\" height=\"200\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1337, "\"", 1381, 2);
            WriteAttributeValue("", 1343, "https://www.youtube.com/embed/", 1343, 30, true);
#line 12 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"
WriteAttributeValue("", 1373, item.Id, 1373, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1382, 136, true);
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n\r\n\r\n    <h3>");
            EndContext();
            BeginContext(1519, 10, false);
#line 15 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"
   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 17, true);
            WriteLiteral("</h3>\r\n\r\n        ");
            EndContext();
            BeginContext(1547, 44, false);
#line 17 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"
   Write(Html.Raw(item.Description.Substring(0, 100)));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 45, true);
            WriteLiteral("\r\n            <a id=\"onClick\">See More</a><p>");
            EndContext();
            BeginContext(1636, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63ec7b225e844f13bf7d20d8a5e8afe1", async() => {
                BeginContext(1719, 10, true);
                WriteLiteral("Learn more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1645, "~/Tutorial/Introduction?v=", 1645, 26, true);
#line 18 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"
AddHtmlAttributeValue("", 1671, item.Id, 1671, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1733, 109, true);
            WriteLiteral("<a href=\"#\" class=\"btn btn-default\" role=\"button\">Add Favourite</a></p>\r\n</div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 22 "D:\Sapura\C# CheatSheet\CSharp CheatSheet\CSharp CheatSheet\Views\Menu\Index.cshtml"

}

#line default
#line hidden
            BeginContext(1847, 5546, true);
            WriteLiteral(@"




<script>
    var channelName = 'kudvenkat';
    var vidHeight = 400;
    var vidWidth = 500;
    var vidMaxResult = 20; // Maximum can be 50

    $(document).ready(function () {
        $.get(""https://www.googleapis.com/youtube/v3/playlistItems"", {
            part: 'contentDetails',
            forUsername: channelName,
            key: '  ' //Browser API Key
        },
            function (data) {
                $.each(data.items, function (i, item) {
                    console.log(item); // See in Browser Console
                    pid = item.contentDetails.relatedPlaylists.uploads;
                    getVideos(pid);
                })
            }
        );
        function getVideos(pid) {
            $.get(""https://www.googleapis.com/youtube/v3/playlistItems"", {
                part: 'snippet',
                maxResults: vidMaxResult,
                playlistId: pid,
                key: 'AIzaSyB7cEKc5O5lr9aF10Gr3ODo_AFbIGOjjHM' //Browser API Key
            }");
            WriteLiteral(@",
                function (data) {
                    var outputVideo;
                    $.each(data.items, function (i, item) {
                        console.log(item); // See in Browser Console
                        vidId = item.snippet.resourceId.videoId;
                        outputVideo = '<li><iframe height=""' + vidHeight + '"" width=""' + vidWidth + '"" src=\""//www.youtube.com/embed/' + vidId + '""> </iframe></li>';

                        //Append to result list
                        $('#result').append(outputVideo);
                    })
                }
            );
        }
    });</script>


<script type=""text/javascript"">
    var tag = document.createElement('script');
    tag.id = 'iframe-demo';
    tag.src = 'https://www.youtube.com/iframe_api';
    var firstScriptTag = document.getElementsByTagName('script')[0];
    firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

    //var key = 'AIzaSyB7cEKc5O5lr9aF10Gr3ODo_AFbIGOjjHM';
    //var playlistId");
            WriteLiteral(@" = 'PLAC325451207E3105';
    //var URL = 'https://www.googleapis.com/youtube/v3/playlistItems';

    var player;
    function onYouTubeIframeAPIReady() {
        player = new YT.Player('existing-iframe-example', {
            events: {
                'onReady': onPlayerReady,
                'onStateChange': onPlayerStateChange
            }
        });
    }
    function onPlayerReady(event) {
        document.getElementById('existing-iframe-example').style.borderColor = '#FF6D00';
    }
    function changeBorderColor(playerStatus) {
        var color;
        if (playerStatus == -1) {
            color = ""#37474F""; // unstarted = gray
        } else if (playerStatus == 0) {
            color = ""#FFFF00""; // ended = yellow
        } else if (playerStatus == 1) {
            color = ""#33691E""; // playing = green
        } else if (playerStatus == 2) {
            color = ""#DD2C00""; // paused = red
        } else if (playerStatus == 3) {
            color = ""#AA00FF""; // buffering = ");
            WriteLiteral(@"purple
        } else if (playerStatus == 5) {
            color = ""#FF6DOO""; // video cued = orange
        }
        if (color) {
            document.getElementById('existing-iframe-example').style.borderColor = color;
        }
    }
    function onPlayerStateChange(event) {
        changeBorderColor(event.data);
    }


</script>






<script>
    $(document).ready(function () {



        var key = 'AIzaSyB7cEKc5O5lr9aF10Gr3ODo_AFbIGOjjHM';
        var playlistId = 'PLAC325451207E3105';
        var URL = 'https://www.googleapis.com/youtube/v3/playlistItems';

        var options = {
            part: 'snippet',
            key: key,
            maxResults: 20,
            playlistId: playlistId
        }

        loadVids();

        function loadVids() {
            $.getJSON(URL, options, function (data) {
                console.log(data);
                var id = data.items[0].snippet.resourceId.videoId;
                mainVid(id);
                results");
            WriteLiteral(@"Loop(data);
            })
        }

        function mainVid(id) {
            $('#video').html(`<iframe
                                                                    width=""640"" height=""360"" src=""https://www.youtube.com/embed/${id}""
                                                                    frameborder=""0"" style=""border: solid 4px #37474F"" ></iframe>`);
        };



        function resultsLoop(data) {

            $.each(data.items, function (i, item) {

                var thumb = item.snippet.thumbnails.medium.url;
                var title = item.snippet.title;
                var desc = item.snippet.description.substring(0, 100);
                var vid = item.snippet.resourceId.videoId;

                $('main').append(` <img src=""${thumb}"" alt=""""  class=""thumb"">
                                                                            <h3>${title}</h3>
                                                                            <p>${desc}</p> <p<a href=""~/Tut");
            WriteLiteral(@"orial/ReadingAndWritingConsole""
                                                                            class=""btn btn-primary"" role=""button"">Learn more</a><a href=""#""
                                                                            class=""btn btn-default"" role=""button"">Button</a> </p>
                                                        `);
            });
        }



    });


</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheatSheet.Models.ListVideos> Html { get; private set; }
    }
}
#pragma warning restore 1591
