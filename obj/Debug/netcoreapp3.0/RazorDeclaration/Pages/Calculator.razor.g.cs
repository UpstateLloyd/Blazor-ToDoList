#pragma checksum "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4022ca6941a7ffcc426c75c0f86fbfee79cd30f4"
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
#line 2 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\Calculator.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "F:\Projects\personal\Razor Tut\ToDoList\blazor-todolist\Pages\Calculator.razor"
       
    StringBuilder CurrentOperand = new StringBuilder("0");
    StringBuilder PreviousOperand = new StringBuilder();
    StringBuilder SafeCurrent = new StringBuilder("0");
    StringBuilder SafePrevious = new StringBuilder("0");
    string Operator = "$";
    float Result = 0;
    bool NewOperation = false;

    private void UpdateHeading(string buttonNumber)
    {
        if (!string.IsNullOrWhiteSpace(buttonNumber))
        {
            if (NewOperation == false)
            {
                if (CurrentOperand.ToString() == "0")
                {
                    if (buttonNumber == ".")
                    {
                        if (!CurrentOperand.ToString().Contains("."))
                        {
                            CurrentOperand.Append(".");
                            SafeCurrent.Append(".");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (float.Parse(buttonNumber) > 0)
                    {
                        CurrentOperand.Clear();
                        CurrentOperand.Append(buttonNumber);
                        SafeCurrent.Clear();
                        SafeCurrent.Append(buttonNumber);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (buttonNumber == ".")
                    {
                        if (!CurrentOperand.ToString().Contains("."))
                        {
                            CurrentOperand.Append(".");
                            SafeCurrent.Append(".");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        CurrentOperand.Append(buttonNumber);
                        SafeCurrent.Append(buttonNumber);
                    }
                }
            }
            else
            {
                if (buttonNumber == ".")
                {
                    CurrentOperand.Clear();
                    CurrentOperand.Append("0" + buttonNumber);
                    SafeCurrent.Clear();
                    SafeCurrent.Append(buttonNumber);
                    NewOperation = false;
                }
                else
                {
                    CurrentOperand.Clear();
                    CurrentOperand.Append(buttonNumber);
                    SafeCurrent.Clear();
                    SafeCurrent.Append(buttonNumber);
                    NewOperation = false;
                }
            }
        }
        if (string.IsNullOrWhiteSpace(CurrentOperand.ToString()))
        {
            CurrentOperand.Append("0");
        }
    }

    private void DeletePressed()
    {
        if (!string.IsNullOrWhiteSpace(CurrentOperand.ToString()))
        {
            if (CurrentOperand.ToString() != "0")
            {
                CurrentOperand.Remove(CurrentOperand.Length - 1, 1);
                SafeCurrent.Remove(SafeCurrent.Length - 1, 1);
            }
            else if (CurrentOperand.Length == 1)
            {
                CurrentOperand.Remove(CurrentOperand.Length - 1, 1);
                CurrentOperand.Append("0");
                SafeCurrent.Remove(SafeCurrent.Length - 1, 1);
                SafeCurrent.Append("0");
            }
            else
            {
                return;
            }
        }
    }

    private void AllClear()
    {
        CurrentOperand.Clear();
        PreviousOperand.Clear();
        CurrentOperand.Append("0");
        SafeCurrent.Clear();
        SafePrevious.Clear();
        SafePrevious.Append("0");
        SafeCurrent.Append("0");
        Operator = "$";
    }

    private void SelectOperation(string NewOperator)
    {
        if (!string.IsNullOrWhiteSpace(NewOperator))
        {
            if (PreviousOperand.ToString().Contains("*") || PreviousOperand.ToString().Contains("-") || PreviousOperand.ToString().Contains("+") || PreviousOperand.ToString().Contains("/"))
            {
                PerformCalculation(SafePrevious, SafeCurrent, Operator);
                PreviousOperand.Append(CurrentOperand + NewOperator);
                SafePrevious.Append(CurrentOperand);
                Operator = NewOperator;
                CurrentOperand.Clear();
                SafeCurrent.Clear();
                SafeCurrent.Append("0");
            }
            else
            {
                PreviousOperand.Clear();
                PreviousOperand.Append(CurrentOperand);
                PreviousOperand.Append(NewOperator);
                CurrentOperand.Clear();
                Operator = NewOperator;
                SafePrevious.Clear();
                SafePrevious.Append(SafeCurrent);
                SafeCurrent.Clear();
                SafeCurrent.Append("0");
            }
        }
    }

    private void PerformCalculation(StringBuilder PrevOperand, StringBuilder CurrOperand, string Operator)
    {
        if (Operator == "$")
        {
            return;
        }
        else
        {
            if (!String.IsNullOrWhiteSpace(Operator) && CurrOperand.Length > 0 && PrevOperand.Length > 0)
            {
                float IntPrevious = 0;
                float IntCurrent = 0;
                String ResultString = "";

                if (float.TryParse(PrevOperand.ToString(), out IntPrevious) && float.TryParse(CurrOperand.ToString(), out IntCurrent))
                {
                    switch (Operator)
                    {
                        case "+":
                            Result = IntPrevious + IntCurrent;
                            break;
                        case "-":
                            Result = IntPrevious - IntCurrent;
                            break;
                        case "*":
                            Result = IntPrevious * IntCurrent;
                            break;
                        case "/":
                            if (IntCurrent == 0)
                            {
                                Result = 0;
                            }
                            else
                            {
                                Result = IntPrevious / IntCurrent;
                            }
                            break;
                        default:
                            break;
                    }

                    ResultString = Result.ToString();
                    CurrentOperand.Clear();
                    SafeCurrent.Clear();
                    PreviousOperand.Clear();
                    SafePrevious.Clear();
                    SafePrevious.Append("0");
                    SafeCurrent.Append(ResultString);
                    CurrentOperand.Append(ResultString);
                    NewOperation = true;
                    Operator = "$";
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
