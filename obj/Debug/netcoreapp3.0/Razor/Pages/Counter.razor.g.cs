#pragma checksum "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d4dc5aa368a56caea5e4bd8c4546ebeb8e1893"
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
#line 1 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\_Imports.razor"
using ToDoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "Increment Amount");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Counter.razor"
                                             IncrementAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IncrementAmount = __value, IncrementAmount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, "Current count: ");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
