#pragma checksum "C:\BlazorCovidLife\Pages\OptManagerPlease.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1964c19b1b42d74f599c160a5d613dea5af32f05"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/OptMange")]
    public partial class OptManagerPlease : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>options for manager</h3>\r\n");
            __builder.AddMarkupContent(1, "<head>\r\n    <meta http-equiv=\"refresh\" content=\"10\">\r\n</head>\r\n");
            __builder.OpenElement(2, "p");
            __builder.OpenElement(3, "em");
            __builder.AddContent(4, "Name: ");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
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
#line 10 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
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
#line 12 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
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
#line 14 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
                     user.nameNeighabored

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.AddMarkupContent(23, "<label for=\"SelectAmount\">Select Amount People that allowed to arrive to event:</label>\r\n<br>\r\n");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "id", "selectamountpeople");
            __builder.AddAttribute(27, "name", "selectamount");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
                                peopleenter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => peopleenter = __value, peopleenter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "id", "excep");
            __builder.AddAttribute(34, "name", "explationtouser");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
                                legalNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => legalNumber = __value, legalNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n<br>\r\n");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
                                          AmountpeopleEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Update Amount People ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
                                          movepageToChargeCredits

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "enter to page to select charge credits ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(48, "<label for=\"moneyToY\">how much money you have?</label>\r\n");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "id", "amountcreditsuser");
            __builder.AddAttribute(52, "name", "creditsOfU");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
                                amountcreditsyofyou

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => amountcreditsyofyou = __value, amountcreditsyofyou));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\BlazorCovidLife\Pages\OptManagerPlease.razor"
       
    Data.User user;
    Data.Country country;
    double amountcreditsyofyou;
    String peopleenter;
    String legalNumber;
    int peopleEnter;
    Data.Zone zone;
    Data.Zone zoni;
    Data.Neighabored neighboree;
    Data.Neighabored neigee;
    int countmothszone;
    int countmonthsneighbored;
    Data.dataMonthZone datazone;
    Data.dataMonthNeighbored dataneigh;
    protected override void OnInitialized()
    {
        user = Data.User.GetInstance;
        country = Data.Country.GetInstance;
        if (user.nameZone != null && user.nameNeighabored != null)
        {
            countmothszone = searchgetIdMaxZone();
            countmonthsneighbored = searchgetIdMaxNeighbored();
        }
        amountcreditsyofyou = user.Somecredts;

    }


    private void movepageToChargeCredits()
    {
        Nov.NavigateTo("/ChargeCredits");
    }
    private void AmountpeopleEnter()
    {
        try
        {
            if (!user.getisload)
            {
                legalNumber = "you must loggin";
            }
            else
            {
                if (!user.getisload)
                    legalNumber = "You must load data";
                else
                {
                    if ((user.nameZone == null) || (user.nameZone == ""))
                        legalNumber = "You must select zone";


                    else
                    {
                        if (!(user.isManage))
                        {
                            legalNumber = "you are not manage";
                        }
                        else
                        {
                            peopleEnter = int.Parse(peopleenter);
                            if (user.nameEventPlace == 1)
                            {
                                if (peopleEnter > 60)
                                {
                                    legalNumber = "you select number that bigger 60";
                                }
                                else
                                {
                                    int i = searchZone();
                                    int j = searxhneighbor();
                                    int p = country.zones[i].neighaboress[j].somepat;
                                    double mana = (double)peopleEnter / 60;
                                    int totalit = (int)((Math.Pow(2.72, mana)) * p);
                                    if (totalit >= country.zones[i].neighaboress[j].somepeop)
                                        legalNumber = "the number of healths bigger all people";
                                    else
                                    {
                                        country.zones[i].neighaboress[j].somepat = totalit;
                                        country.zones[i].neighaboress[j].somehealts = country.zones[i].neighaboress[j].somepeop - country.zones[i].neighaboress[j].somepat;
                                        double mananeigh = (double)(country.zones[i].neighaboress[j].somepat) / (country.zones[i].neighaboress[j].somepeop);
                                        country.zones[i].totalpateints = (int)(mananeigh * country.zones[i].totalpeople);
                                        country.zones[i].totalhealths = country.zones[i].totalpeople - country.zones[i].totalpateints;
                                        country.zones[i].HealthsPercent = (double)(country.zones[i].totalhealths) / (double)(country.zones[i].totalpeople);
                                        country.zones[i].neighaboress[j].getPercentHealths = (double)(country.zones[i].neighaboress[j].somehealts) / (double)(country.zones[i].neighaboress[j].somepeop);
                                        datazone = new Data.dataMonthZone();

                                        countmothszone++;
                                        datazone.getMonthId = countmothszone;
                                        datazone.getNmaePlace = country.zones[i].namezone;
                                        datazone.getCountPeople = country.zones[i].totalpeople;
                                        datazone.getCountHealths = country.zones[i].totalhealths;
                                        datazone.getCountPatients = country.zones[i].totalpateints;
                                        datazone.getPercentHealths = country.zones[i].HealthsPercent;
                                        datazone.getAmountEconomy = country.zones[i].getAmountEconomy;
                                        country.zones[i].datamonthzone.Add(datazone);
                                        dataneigh = new Data.dataMonthNeighbored();
                                        countmonthsneighbored++;
                                        dataneigh.getMonthId = countmonthsneighbored;
                                        dataneigh.getNmaePlace = country.zones[i].neighaboress[j].NameNeigh;
                                        dataneigh.getCountPeople = country.zones[i].neighaboress[j].somepeop;
                                        dataneigh.getCountHealths = country.zones[i].neighaboress[j].somehealts;
                                        dataneigh.getCountPatients = country.zones[i].neighaboress[j].somepat;
                                        dataneigh.getPercentHealths = country.zones[i].neighaboress[j].getPercentHealths;
                                        dataneigh.getAmountEconomy = country.zones[i].neighaboress[j].getAmountEconomy;
                                        country.zones[i].neighaboress[j].datamonthneighbored.Add(dataneigh);
                                        legalNumber = "you chang the amount of patients";


                                    }
                                }


                            }
                            if (user.nameEventPlace == 2)
                            {
                                if (peopleEnter > 2500)
                                {
                                    legalNumber = "you select number that bigger 2500";
                                }
                                else
                                {
                                    int i = searchZone();
                                    int j = searxhneighbor();
                                    int p = country.zones[i].neighaboress[j].somepat;
                                    double mana = (double)peopleEnter / 2500;
                                    int totalit = (int)((Math.Pow(2.72, mana)) * p);
                                    if (totalit >= country.zones[i].neighaboress[j].somepeop)
                                        legalNumber = "the number of healths bigger all people";
                                    else
                                    {
                                        country.zones[i].neighaboress[j].somepat = totalit;
                                        country.zones[i].neighaboress[j].somehealts = country.zones[i].neighaboress[j].somepeop - country.zones[i].neighaboress[j].somepat;
                                        double mananeigh = (double)(country.zones[i].neighaboress[j].somepat) / (country.zones[i].neighaboress[j].somepeop);
                                        country.zones[i].totalpateints = (int)(mananeigh * country.zones[i].totalpeople);
                                        country.zones[i].totalhealths = country.zones[i].totalpeople - country.zones[i].totalpateints;
                                        country.zones[i].HealthsPercent = (double)(country.zones[i].totalhealths) / (double)(country.zones[i].totalpeople);
                                        country.zones[i].neighaboress[j].getPercentHealths = (double)(country.zones[i].neighaboress[j].somehealts) / (double)(country.zones[i].neighaboress[j].somepeop);
                                        datazone = new Data.dataMonthZone();

                                        countmothszone++;
                                        datazone.getMonthId = countmothszone;
                                        datazone.getNmaePlace = country.zones[i].namezone;
                                        datazone.getCountPeople = country.zones[i].totalpeople;
                                        datazone.getCountHealths = country.zones[i].totalhealths;
                                        datazone.getCountPatients = country.zones[i].totalpateints;
                                        datazone.getPercentHealths = country.zones[i].HealthsPercent;
                                        datazone.getAmountEconomy = country.zones[i].getAmountEconomy;
                                        country.zones[i].datamonthzone.Add(datazone);
                                        dataneigh = new Data.dataMonthNeighbored();
                                        countmonthsneighbored++;
                                        dataneigh.getMonthId = countmonthsneighbored;
                                        dataneigh.getNmaePlace = country.zones[i].neighaboress[j].NameNeigh;
                                        dataneigh.getCountPeople = country.zones[i].neighaboress[j].somepeop;
                                        dataneigh.getCountHealths = country.zones[i].neighaboress[j].somehealts;
                                        dataneigh.getCountPatients = country.zones[i].neighaboress[j].somepat;
                                        dataneigh.getPercentHealths = country.zones[i].neighaboress[j].getPercentHealths;
                                        dataneigh.getAmountEconomy = country.zones[i].neighaboress[j].getAmountEconomy;
                                        country.zones[i].neighaboress[j].datamonthneighbored.Add(dataneigh);
                                        legalNumber = "you chang the amount of patients";
                                    }
                                }
                            }
                            if (user.nameEventPlace == 3)
                            {
                                if (peopleEnter > 250)
                                {
                                    legalNumber = "you select number that bigger 250";
                                }

                                else
                                {

                                    int i = searchZone();
                                    int j = searxhneighbor();
                                    int p = country.zones[i].neighaboress[j].somepat;
                                    double mana = (double)peopleEnter / 250;
                                    int totalit = (int)((Math.Pow(2.72, mana)) * p);
                                    if (totalit >= country.zones[i].neighaboress[j].somepeop)
                                        legalNumber = "the number of healths bigger all people";
                                    else
                                    {
                                        country.zones[i].neighaboress[j].somepat = totalit;
                                        country.zones[i].neighaboress[j].somehealts = country.zones[i].neighaboress[j].somepeop - country.zones[i].neighaboress[j].somepat;
                                        double mananeigh = (double)(country.zones[i].neighaboress[j].somepat) / (country.zones[i].neighaboress[j].somepeop);
                                        country.zones[i].totalpateints = (int)(mananeigh * country.zones[i].totalpeople);
                                        country.zones[i].totalhealths = country.zones[i].totalpeople - country.zones[i].totalpateints;
                                        country.zones[i].HealthsPercent = (double)(country.zones[i].totalhealths) / (double)(country.zones[i].totalpeople);
                                        country.zones[i].neighaboress[j].getPercentHealths = (double)(country.zones[i].neighaboress[j].somehealts) / (double)(country.zones[i].neighaboress[j].somepeop);
                                        datazone = new Data.dataMonthZone();

                                        countmothszone++;
                                        datazone.getMonthId = countmothszone;
                                        datazone.getNmaePlace = country.zones[i].namezone;
                                        datazone.getCountPeople = country.zones[i].totalpeople;
                                        datazone.getCountHealths = country.zones[i].totalhealths;
                                        datazone.getCountPatients = country.zones[i].totalpateints;
                                        datazone.getPercentHealths = country.zones[i].HealthsPercent;
                                        datazone.getAmountEconomy = country.zones[i].getAmountEconomy;
                                        country.zones[i].datamonthzone.Add(datazone);
                                        dataneigh = new Data.dataMonthNeighbored();
                                        countmonthsneighbored++;
                                        dataneigh.getMonthId = countmonthsneighbored;
                                        dataneigh.getNmaePlace = country.zones[i].neighaboress[j].NameNeigh;
                                        dataneigh.getCountPeople = country.zones[i].neighaboress[j].somepeop;
                                        dataneigh.getCountHealths = country.zones[i].neighaboress[j].somehealts;
                                        dataneigh.getCountPatients = country.zones[i].neighaboress[j].somepat;
                                        dataneigh.getPercentHealths = country.zones[i].neighaboress[j].getPercentHealths;
                                        dataneigh.getAmountEconomy = country.zones[i].neighaboress[j].getAmountEconomy;
                                        country.zones[i].neighaboress[j].datamonthneighbored.Add(dataneigh);
                                        legalNumber = "you chang the amount of patients";
                                    }
                                }
                            }
                        }
                    }
                }


            }
        }
        catch (Exception e)
        {
            legalNumber = "you select int number";
        }
    }
    private int searchZone()
    {
        int x = 0;
        for (int i = 0; i < country.zones.Count; i++)
        {
            if (country.zones[i].namezone.Equals(user.nameZone))
            {
                x = i;
                break;

            }
        }
        return x;
    }
    private int searxhneighbor()
    {
        int y = 0;
        for (int i = 0; i < country.zones.Count; i++)
        {
            if (country.zones[i].namezone.Equals(user.nameZone))
            {
                for (int j = 0; j < country.zones[i].neighaboress.Count; j++)
                {
                    if (country.zones[i].neighaboress[j].NameNeigh.Equals(user.nameNeighabored))
                    {
                        y = j;
                        break;
                    }
                }
                break;
            }

        }
        return y;
    }
    public int searchgetIdMaxZone()
    {
        int max = 0;
        foreach (var zon in country.zones)
        {
            if (user.nameZone.Equals(zon.namezone))
            {
                zoni = zon;
                break;
            }
        }
        foreach (var dza in zoni.datamonthzone)
        {
            if (dza.getMonthId >= max)
                max = dza.getMonthId;
        }
        return max;
    }
    public int searchgetIdMaxNeighbored()
    {
        int max = 0;
        foreach (var zon in country.zones)
        {
            if (user.nameZone.Equals(zon.namezone))
            {
                zoni = zon;
                break;
            }
        }
        foreach (var neigh in zoni.neighaboress)
        {
            if (user.nameNeighabored.Equals(neigh.NameNeigh))
            {
                neigee = neigh;
                break;
            }
        }
        foreach (var dna in neigee.datamonthneighbored)
        {
            if (dna.getMonthId >= max)
                max = dna.getMonthId;
        }
        return max;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nov { get; set; }
    }
}
#pragma warning restore 1591
