#pragma checksum "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7afd2c4af1a959fe2d5e1f8b964fc371514f596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminPedidos_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminPedidos/Details.cshtml")]
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
#line 1 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7afd2c4af1a959fe2d5e1f8b964fc371514f596", @"/Areas/Admin/Views/AdminPedidos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798c89ae1590f3f97cffe7393fc1f92d2ad95e33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminPedidos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LanchesMac.Models.Pedido>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Detalhes do Pedido</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 11 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 14 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 17 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 20 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 23 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 26 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 29 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 32 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 35 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 38 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 41 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 44 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 47 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 50 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 53 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 56 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 59 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 62 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 65 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PedidoEnviado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 68 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PedidoEnviado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-3\">\r\n            ");
#nullable restore
#line 71 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-9\">\r\n            ");
#nullable restore
#line 74 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7afd2c4af1a959fe2d5e1f8b964fc371514f59613071", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\LuthianniAlves\Downloads\LanchesMac\LanchesMac\LanchesMac\Areas\Admin\Views\AdminPedidos\Details.cshtml"
                           WriteLiteral(Model.PedidoId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7afd2c4af1a959fe2d5e1f8b964fc371514f59615255", async() => {
                WriteLiteral("Retornar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanchesMac.Models.Pedido> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
