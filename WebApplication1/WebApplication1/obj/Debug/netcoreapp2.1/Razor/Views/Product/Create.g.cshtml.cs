#pragma checksum "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58380095a9ca1d264f617e21a0952a05191b08e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Create.cshtml", typeof(AspNetCore.Views_Product_Create))]
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
#line 1 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58380095a9ca1d264f617e21a0952a05191b08e5", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: 1px solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(68, 30, true);
            WriteLiteral("<h1></h1>\r\n<h2>Create</h2>\r\n\r\n");
            EndContext();
            BeginContext(98, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "280c955bfb004cb2a1a5f12262bc1176", async() => {
                BeginContext(158, 172, true);
                WriteLiteral("\r\n\r\n    name: <input type=\"text\" value=\"\" name=\"Name\">\r\n    price: <input type=\"number\" value=\"\" name=\"Price\">\r\n    <input type=\"submit\" name=\"create\" value=\"Create\" />\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(337, 22, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n");
            EndContext();
            BeginContext(359, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d3ad426028045a495bacbf75f324813", async() => {
                BeginContext(419, 222, true);
                WriteLiteral("\r\n    id: <input type=\"text\" name=\"Id\" value=\"\" />\r\n    name: <input type=\"text\" name=\"Name\" value=\"\" />\r\n    price: <input type=\"text\" name=\"Price\" value=\"\" />\r\n    <input type=\"submit\" name=\"update\" value=\"Update\" />\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 28, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n<ul>\r\n");
            EndContext();
#line 25 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(720, 26, true);
            WriteLiteral("        <li>\r\n            ");
            EndContext();
            BeginContext(747, 12, false);
#line 28 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
       Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(759, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(763, 13, false);
#line 28 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
                       Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(776, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 792, "\"", 827, 2);
            WriteAttributeValue("", 799, "/Product/Edit?id=", 799, 17, true);
#line 29 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
WriteAttributeValue("", 816, product.Id, 816, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(828, 59, true);
            WriteLiteral(">Edit</a>&nbsp;\r\n            <a href=\"#\" class=\"btn-delete\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 887, "\"", 903, 1);
#line 30 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
WriteAttributeValue("", 892, product.Id, 892, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(904, 28, true);
            WriteLiteral(">Delete</a>\r\n        </li>\r\n");
            EndContext();
#line 32 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
    }

#line default
#line hidden
            BeginContext(939, 27, true);
            WriteLiteral("</ul>\r\n<br /><br /><br />\r\n");
            EndContext();
#line 35 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
            BeginContext(1002, 48, true);
            WriteLiteral("    <div style=\"border: 1px solid\">\r\n        <p>");
            EndContext();
            BeginContext(1051, 10, false);
#line 38 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
      Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 23, true);
            WriteLiteral("</p>\r\n        <p>name: ");
            EndContext();
            BeginContext(1085, 12, false);
#line 39 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
            Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 24, true);
            WriteLiteral("</p>\r\n        <p>price: ");
            EndContext();
            BeginContext(1122, 13, false);
#line 40 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
             Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 18, true);
            WriteLiteral("</p>\r\n    </div>\r\n");
            EndContext();
#line 42 "D:\dotnetCore\learn\WebApplication1\WebApplication1\Views\Product\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1156, 1778, true);
            WriteLiteral(@"
<script>
    var listBtnDelete = document.getElementsByClassName(""btn-delete"");
    for (var i = 0; i < listBtnDelete.length; i++) {
        listBtnDelete[i].onclick = function () {
            if (confirm(""Are you sure"")) {
                var curentDeleteButton = this;
                var xmlhtmlrequest = new XMLHttpRequest();
                var deleteID = this.id;
                xmlhtmlrequest.onreadystatechange = function () {
                    if (this.readyState === 4 && this.status === 200) {
                        alert(""DELETE SUCCESS"");
                        //document.getElementById(""product - "" + deleteID).remove();
                        curentDeleteButton.parentElement.remove();
                    }

                }
                XMLHttpRequest.open(""DELETE"", ""Product/DELETE"" + deleteID, true);
                xmlhtmlrequest.send();
                // call ajax
                var checkAll = document.getElementById(""check-all"");
                var listCheckbox");
            WriteLiteral(@" = document.getElementsByClassName(""check-item"");
                checkAll.onclick = function () {
                    for (var i = 0; i < listCheckbox.length; i++) {
                        listCheckbox[i].checked = this.checked;
                    }
                }
                var deleteAll = document.getElementById(""delete-id"");
                deleteAll.onclick = function () {
                    var checkedItem = document.querySelectionAll("".check-item:checked"");
                    var deleteIds = new Array();
                    for (var i = 0; i < checkedItem.length; i++) {
                        deleteIds.push(checkedItem[i].id.re)
                    }
                }
            }
        };
    }
</script>");
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
