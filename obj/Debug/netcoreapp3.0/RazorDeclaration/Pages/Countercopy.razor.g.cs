#pragma checksum "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Countercopy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea971571093508be869df92b6a348d3942a32621"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Countercopy.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/countercopy")]
    public partial class Countercopy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\lhotchkiss\Documents\Projects\Scripts\Tuts\ToDoList\Pages\Countercopy.razor"
       

    [Parameter]
    public string IncrementAmount { get; set; }

    [Parameter]
    public string ButtonValue { get; set; }

    StringBuilder myStringBuilder = new StringBuilder();
    void IncrementCount(MouseEventArgs e)
    {
        myStringBuilder.Append(IncrementAmount);
    }
    void Decrement()
    {
        if (!String.IsNullOrWhiteSpace(myStringBuilder.ToString()))
        {
            myStringBuilder.Remove(myStringBuilder.Length-1, 1);
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
