#pragma checksum "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11f2ebd09a95549437eea54d2e66a98b6deff00"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/HistoryOrNeigh")]
    public partial class HistoryOrNeighabor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>historyOrNeighbor</h3>\r\n");
            __builder.AddMarkupContent(1, "<head>\r\n    <meta http-equiv=\"refresh\" content=\"10\">\r\n</head>\r\n");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "em");
            __builder.AddContent(4, "Name: ");
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
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
#line 9 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
                user.getId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "radio");
            __builder.AddAttribute(14, "id", "neighboran");
            __builder.AddAttribute(15, "name", "HorN");
            __builder.AddAttribute(16, "value", "neighboredeed");
            __builder.AddAttribute(17, "checked", "(" + (
#nullable restore
#line 11 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
                                                                                 user.getselectHistoryOrNeighabores

#line default
#line hidden
#nullable disable
            ) + "==1)");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
                                                                                                                                     ()=>user.getselectHistoryOrNeighabores=1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddMarkupContent(20, "<label for=\"DataNeighborsplease\">ToSeeDataNeighbored</label>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "radio");
            __builder.AddAttribute(23, "id", "HistoryZone");
            __builder.AddAttribute(24, "name", "HorN");
            __builder.AddAttribute(25, "value", "History");
            __builder.AddAttribute(26, "checked", "(" + (
#nullable restore
#line 15 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
                                                                            user.getselectHistoryOrNeighabores

#line default
#line hidden
#nullable disable
            ) + "==2)");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
                                                                                                                                ()=>user.getselectHistoryOrNeighabores=2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.AddMarkupContent(29, "<label for=\"DataZonePlease\">ToseeDataZone</label>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(30, "<label for=\"moneyToY\">how much money you have?</label>\r\n");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "id", "amountcredits");
            __builder.AddAttribute(34, "name", "credituser");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
                                amountcreditsyouruser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => amountcreditsyouruser = __value, amountcreditsyouruser));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\BlazorCovidLife\Pages\HistoryOrNeighabor.razor"
       

    Data.User user;
    double amountcreditsyouruser;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        user = Data.User.GetInstance;
        amountcreditsyouruser = user.Somecredts;

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
