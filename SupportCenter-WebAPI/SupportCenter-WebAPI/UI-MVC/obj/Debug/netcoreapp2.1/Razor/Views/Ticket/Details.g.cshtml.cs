#pragma checksum "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9998261c7c045d078f0ebed249befb9f6a148b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Details), @"mvc.1.0.view", @"/Views/Ticket/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Details.cshtml", typeof(AspNetCore.Views_Ticket_Details))]
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
#line 1 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\_ViewImports.cshtml"
using SC.UI.Web.MVC;

#line default
#line hidden
#line 2 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\_ViewImports.cshtml"
using SC.UI.Web.MVC.Models;

#line default
#line hidden
#line 1 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
using SC.BL.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9998261c7c045d078f0ebed249befb9f6a148b", @"/Views/Ticket/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab2f5f54e45fb9920fc35cf33cd13a0fb8398a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SC.BL.Domain.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TicketDetailsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
  
    ViewBag.Title = "Ticket";

#line default
#line hidden
            BeginContext(89, 21, true);
            WriteLiteral("\r\n<h2>Ticket</h2>\r\n\r\n");
            EndContext();
            BeginContext(380, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4172ce57e8004fcfb907be69b476ecff", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(432, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(436, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59763fac0d9d48e48c8be50898454bef", async() => {
                BeginContext(492, 6, true);
                WriteLiteral("Bewerk");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
                       WriteLiteral(Model.TicketNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(502, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(505, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb5360f856884149bfe1c1f647f07908", async() => {
                BeginContext(527, 5, true);
                WriteLiteral("Lijst");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(536, 58, true);
            WriteLiteral("\r\n\r\n<h3>Responses</h3>\r\n<p><button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 594, "\"", 646, 3);
            WriteAttributeValue("", 604, "loadResponsesOfTicket(", 604, 22, true);
#line 22 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
WriteAttributeValue("", 626, Model.TicketNumber, 626, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 645, ")", 645, 1, true);
            EndWriteAttribute();
            BeginContext(647, 160, true);
            WriteLiteral(">(Her)laad antwoorden</button></p>\r\n<table id=\"responses\" class=\"table\">\r\n    <tr>\r\n        <th>Antwoord</th><th>Datum</th><th>Klant antwoord?</th>\r\n    </tr>\r\n");
            EndContext();
#line 27 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
     foreach (TicketResponse response in (IEnumerable<TicketResponse>) ViewBag.Responses)
    {

#line default
#line hidden
            BeginContext(905, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(936, 13, false);
#line 30 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
           Write(response.Text);

#line default
#line hidden
            EndContext();
            BeginContext(949, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(959, 13, false);
#line 30 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
                                  Write(response.Date);

#line default
#line hidden
            EndContext();
            BeginContext(972, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(981, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ac0fe16d1834dc9a8516e578558c921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => response.IsClientResponse);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1035, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1064, 168, true);
            WriteLiteral("</table>\r\n<input id=\"responseText\" name=\"responseText\" type=\"text\" style=\"margin-right: 5px\" />\r\n<button type=\"button\" onclick=\"postResponse()\">Verzenden</button>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1251, 1341, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        // Toon responses
        function loadResponsesOfTicket(ticketNumber) {
            $.ajax('/api/TicketResponses?ticketnumber='+ticketNumber, {
                    type: 'GET',
                    dataType: 'json' // data-type expected back (response-data parsed to object)
                })
                .done(function (data) { showTicketResponses(data); })
                .fail(function () { alert('Oeps, something went wrong!'); });
        }
        function showTicketResponses(responses) {
            $('table#responses').find('tr:gt(0)').remove();
            setTimeout(function () {
                    responses.forEach(function (response) { addResponseToList(response); });
            }, 1000);
        }
        function addResponseToList(response) {
            var date = new Date(response.date);
            var checked = response.isClientResponse ? 'checked=""checked""' : '';
            $('table#responses').append('<tr>'
            ");
                WriteLiteral(@"    +'<td>'+response.text+'</td>'
                +'<td>'+date.toLocaleString()+'</td>'
                +'<td><input type=""checkbox"" disabled '+checked+'/></td>'
                +'</tr>');
        }
        
        // Voeg nieuw response toe
        function postResponse() {
            var ticketNumber = '");
                EndContext();
                BeginContext(2593, 18, false);
#line 68 "F:\REPOS\OnderzoeksTopic\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
                           Write(Model.TicketNumber);

#line default
#line hidden
                EndContext();
                BeginContext(2611, 787, true);
                WriteLiteral(@"';
            var answer = $('#responseText').val();
            if (answer) {
                var newResponse = { ticketNumber: ticketNumber, responseText: answer, 
                                    isClientResponse: false }
                $.ajax('/api/TicketResponses', { 
                        type: 'POST',
                        data: JSON.stringify(newResponse),
                        contentType : 'application/json',
                        dataType: 'json' // data-type expected back
                    })
                    .done(function (data) { addResponseToList(data); 
                        $('#responseText').val(''); })
                    .fail(function () { alert('Oeps, something went wrong!'); });
            }
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SC.BL.Domain.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
