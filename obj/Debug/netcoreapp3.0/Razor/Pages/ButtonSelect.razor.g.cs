#pragma checksum "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443994f198e654262885f6c4e8afaf3836a9f99b"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\_Imports.razor"
using ToDoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/btnselect")]
    public partial class ButtonSelect : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Button Select</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "calculator-grid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "output");
            __builder.AddMarkupContent(6, "\r\n        <div class=\"previous-operand\"></div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "current-operand");
            __builder.AddContent(9, 
#nullable restore
#line 9 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                                      myStringBuilder

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<button class=\"span-two\">AC</button>\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                       DeletePressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Del");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("/")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "/");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("1")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("2")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("3")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("*")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "*");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("4")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("5")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("6")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("+")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("7")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("8")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("9")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(63, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "-");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading(".")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                        () => UpdateHeading("0")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "span-two");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
                                         () => UpdateHeading("1")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "=");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\ButtonSelect.razor"
       
    StringBuilder myStringBuilder = new StringBuilder();

    private void UpdateHeading(string buttonNumber)
    {
        myStringBuilder.Append(buttonNumber);
    }

    private void DeletePressed()
    {
        myStringBuilder.Remove(myStringBuilder.Length - 1, 1);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
