#pragma checksum "C:\BlazorCovidLife\Pages\SeletEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49fbd682a8fe5592ad68885e28d328bafaf8db15"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SelectEvent")]
    public partial class SeletEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Select-Event</h3>\r\n");
            __builder.AddMarkupContent(1, "<head>\r\n    <meta http-equiv=\"refresh\" content=\"10\">\r\n</head>\r\n");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "em");
            __builder.AddContent(4, "Name: ");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
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
#line 10 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                user.getId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "radio");
            __builder.AddAttribute(14, "id", "ocassion");
            __builder.AddAttribute(15, "name", "Even");
            __builder.AddAttribute(16, "value", "ocassss");
            __builder.AddAttribute(17, "checked", (
#nullable restore
#line 14 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                                                        user.nameEventPlace

#line default
#line hidden
#nullable disable
            ) + "==3");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                                                                                            ()=>user.nameEventPlace=3

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddMarkupContent(20, "<label for=\"ocassion\">ocassion</label>\r\n<br>\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "radio");
            __builder.AddAttribute(23, "id", "school");
            __builder.AddAttribute(24, "name", "Even");
            __builder.AddAttribute(25, "value", "scool");
            __builder.AddAttribute(26, "checked", (
#nullable restore
#line 17 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                                                    user.nameEventPlace

#line default
#line hidden
#nullable disable
            ) + "==2");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                                                                                        ()=>user.nameEventPlace=2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.AddMarkupContent(29, "<label for=\"school\">School</label>\r\n<br>\r\n");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "radio");
            __builder.AddAttribute(32, "id", "market");
            __builder.AddAttribute(33, "name", "Even");
            __builder.AddAttribute(34, "value", "Markets");
            __builder.AddAttribute(35, "checked", (
#nullable restore
#line 20 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                                                      user.nameEventPlace

#line default
#line hidden
#nullable disable
            ) + "==1");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                                                                                          ()=>user.nameEventPlace=1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.AddMarkupContent(38, "<label for=\"market\">Market</label>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                          movepagess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "enter to next page ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(44, "<label for=\"moneyToYo\">how much money you have?</label>\r\n");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "id", "amountuser");
            __builder.AddAttribute(48, "name", "creditsOfUser");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
                                amountmoney

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => amountmoney = __value, amountmoney));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\BlazorCovidLife\Pages\SeletEvent.razor"
 
    Data.User user;
    Data.Country country;
    double amountmoney;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        user = Data.User.GetInstance;
        country = Data.Country.GetInstance;
        amountmoney = user.Somecredts;

    }


    private void movepagess()
    {
        Nav.NavigateTo("/updateData");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
