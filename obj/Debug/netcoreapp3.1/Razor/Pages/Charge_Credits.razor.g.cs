#pragma checksum "C:\BlazorCovidLife\Pages\Charge_Credits.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2aac22655af08b22ded22c0363f1d3d830ba475"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCovidLife.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BlazorCovidLife\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BlazorCovidLife\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BlazorCovidLife\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BlazorCovidLife\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BlazorCovidLife\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BlazorCovidLife\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BlazorCovidLife\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BlazorCovidLife\_Imports.razor"
using BlazorCovidLife;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BlazorCovidLife\_Imports.razor"
using BlazorCovidLife.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChargeCredits")]
    public partial class Charge_Credits : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Charge_Credits</h3>\r\n");
            __builder.AddMarkupContent(1, "<head>\r\n    <meta http-equiv=\"refresh\" content=\"10\">\r\n</head>\r\n");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "em");
            __builder.AddContent(4, "Name: ");
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\BlazorCovidLife\Pages\Charge_Credits.razor"
              user.Namey

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.OpenElement(7, "p");
            __builder.OpenElement(8, "em");
            __builder.AddContent(9, "The Id: ");
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\BlazorCovidLife\Pages\Charge_Credits.razor"
                user.getId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(12, "<label for=\"HowMoney\">How Amount Money You Select:</label>\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "id", "selectamountMoney");
            __builder.AddAttribute(16, "name", "selectMoney");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\BlazorCovidLife\Pages\Charge_Credits.razor"
                                CounterMoney

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CounterMoney = __value, CounterMoney));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "id", "showillegalOrLegal");
            __builder.AddAttribute(23, "name", "showExplationToUser");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\BlazorCovidLife\Pages\Charge_Credits.razor"
                                illegalString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => illegalString = __value, illegalString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n<br>\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\BlazorCovidLife\Pages\Charge_Credits.razor"
                                          UpdateMoney

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Update Money To User ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\BlazorCovidLife\Pages\Charge_Credits.razor"
       

    Data.User user;
    String CounterMoney = "";
    String illegalString = "";
    double CurrentMoney;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        user = Data.User.GetInstance;
    }
    private void UpdateMoney()
    {
        try
        {
            CurrentMoney = double.Parse(CounterMoney);
            if (CurrentMoney < 0)
            {
                illegalString = "You Should to enter number bigger 0";
            }
            else
            {
                user.Somecredts = user.Somecredts + CurrentMoney;
                illegalString = "You add your money";
            }
        }
        catch (Exception e)
        {
            illegalString = "you should to enter double number";
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591