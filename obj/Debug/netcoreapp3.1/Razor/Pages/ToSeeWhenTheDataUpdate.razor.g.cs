#pragma checksum "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81340251827cf432fbb3364673888e5efa4d5035"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ToSeeUpdateData")]
    public partial class ToSeeWhenTheDataUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TםSeeWhenTheDataUpdate</h3>\r\n");
            __builder.AddMarkupContent(1, "<head>\r\n    <meta http-equiv=\"refresh\" content=\"10\">\r\n</head>\r\n");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "em");
            __builder.AddContent(4, "Name: ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
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
#line 8 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
                user.getId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n");
            __builder.OpenElement(12, "p");
            __builder.OpenElement(13, "em");
            __builder.AddContent(14, "Zone: ");
            __builder.AddContent(15, 
#nullable restore
#line 10 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
              user.nameZone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<br>\r\n");
            __builder.OpenElement(17, "p");
            __builder.OpenElement(18, "em");
            __builder.AddContent(19, "neighabored: ");
            __builder.AddContent(20, 
#nullable restore
#line 12 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
                     user.nameNeighabored

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.AddMarkupContent(23, "<label for=\"SelectAmountData\">select amount people that will patients and to see the amount of weeks:</label>\r\n<br>\r\n");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "id", "selectamountpeople");
            __builder.AddAttribute(27, "name", "selectamount");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
                                peopleEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => peopleEnter = __value, peopleEnter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "id", "excep");
            __builder.AddAttribute(34, "name", "explationtouser");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
                                legalNumbercheck

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => legalNumbercheck = __value, legalNumbercheck));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
                                          AmountpeopleEnterPlease

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Update Amount People ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(43, "<label for=\"moneyToY\">how much money you have?</label>\r\n");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "id", "amountcredituse");
            __builder.AddAttribute(47, "name", "creditsuse");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
                                amountcreditsyofyo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => amountcreditsyofyo = __value, amountcreditsyofyo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\BlazorCovidLife\Pages\ToSeeWhenTheDataUpdate.razor"
       

    String peopleEnter;
    String legalNumbercheck;
    Data.User user;
    Data.Country country;
    int peopleenter;
    Data.Zone zone;
    int[] peopleamountneigbor;
    double amountcreditsyofyo;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        user = Data.User.GetInstance;
        country = Data.Country.GetInstance;
        peopleamountneigbor = new int[searchcount()];
        amountcreditsyofyo = user.Somecredts;


    }
    private void AmountpeopleEnterPlease()
    {
        int countweeks = 0;
        try
        {
            if (!user.getLogin)
                legalNumbercheck = "you login please";
            else
            {
                if (!user.getisload)
                    legalNumbercheck = "you load the data";
                else
                {
                    if ((user.nameZone == null) || (user.nameZone == ""))
                        legalNumbercheck = "You select zone please";
                    else
                    {
                        peopleenter = int.Parse(peopleEnter);
                        if (!user.isManage && user.Somecredts < 100)
                        {
                            legalNumbercheck = "no enough money";
                        }
                        else
                        {
                            if (!user.isManage)
                                user.Somecredts = user.Somecredts - 100;
                            int p = searchzone();
                            if (peopleenter >= country.zones[p].totalpateints)
                                legalNumbercheck = "enter more people that patients people in zone";
                            else
                            {
                                int y = country.zones[p].totalpateints;
                                int count = searchcount();
                                for (int i = 0; i < count; i++)
                                    peopleamountneigbor[i] = country.zones[p].neighaboress[i].somehealts;
                                while (y > peopleenter)
                                {
                                    double sum = 0;
                                    for (int i = 0; i < count; i++)
                                    {
                                        int somepatient = country.zones[p].neighaboress[i].somepeop - peopleamountneigbor[i];
                                        double mana = (double)(somepatient) / (double)(country.zones[p].neighaboress[i].somepeop);
                                        double hezka = Math.Pow(2.72, mana);
                                        peopleamountneigbor[i] = (int)(hezka * somepatient - somepatient + peopleamountneigbor[i]);
                                        sum = sum + (double)(peopleamountneigbor[i]) / (double)(country.zones[p].neighaboress[i].somepeop);

                                    }
                                    countweeks++;
                                    double mena = sum / count;
                                    y = (int)(y * mena);


                                }
                                legalNumbercheck = countweeks.ToString() + " " + "Weeks";
                            }
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {


        }

    }

    private int searchzone()
    {
        int p = 0;
        for (int i = 0; i < country.zones.Count; i++)
        {
            if (country.zones[i].namezone.Equals(user.nameZone))
            {
                p = i;
                break;
            }
        }
        return p;

    }
    private int searchcount()
    {
        int count = 0;
        if (user.nameZone != null && user.nameZone != "")
        {
            foreach (var zon in country.zones)
            {
                if (zon.namezone.Equals(user.nameZone))
                {
                    zone = zon;
                    break;
                }
            }
            count = zone.neighaboress.Count;
        }
        return count;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
