using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public sealed class Country
     {
          private static Country s_instance;
          public List<Zone> zones = new List<Zone>();
          private String nameCountry;
          private int totalHealths;
          private int totalPatients;
          private int AmountPeople;

          public Country(String namecontry,int totalhealth,int totalpatient,int amountpeople)
          {
               this.nameCountry = namecontry;
               this.totalHealths = totalhealth;
               this.totalPatients = totalpatient;
               this.AmountPeople = amountpeople;
               fillCountry();
          }
          public Country()
          {
               fillCountry();
          }
          public static Country GetInstance
          {
               get
               {
                    if(s_instance==null)
                    {
                         s_instance = new Country();
                    }
                    return s_instance;
               }
          }
          public String getNmaeCountrty
          {
               get
               {
                    return this.nameCountry;
               }
               set
               {
                    this.nameCountry = value;
               }
          }
          public int getTotalhealths
          {
               get
               {
                    return this.totalHealths;
               }
               set
               {
                    this.totalHealths = value;
               }
          }
          public int getTotalPatients
          {
               get
               {
                    return this.totalPatients;
               }
               set
               {
                    this.totalPatients = value;
               }
          }
          public int getAmountPeople
          {
               get
               {
                    return this.AmountPeople;
               }
               set
               {
                    this.AmountPeople = value;
               }
          }
          public void fillCountry()
          {
               this.nameCountry = "Israel";
               this.totalPatients = 44000;
               this.totalHealths = 8846000;
               this.AmountPeople = 8890000;
            Zone z1 = new Zone(1, "Metula", 100000, 1000, 99000, 12987651234.00);
            z1.HealthsPercent = (double)(z1.totalhealths) / (double)(z1.totalpeople);
            Zone z2 = new Zone(2, "Naheriya", 140000, 1200, 138800, 20198747896.00);
            z2.HealthsPercent = (double)(z2.totalhealths) / (double)(z2.totalpeople);
               Zone z3 = new Zone(3, "Heifa", 400000, 3000, 397000, 32987543125.00);
               z3.HealthsPercent = (double)(z3.totalhealths) / (double)(z3.totalpeople);
            Zone z4 = new Zone(4, "Binyamina", 132000, 1345, 130655, 16578912914.00);
            z4.HealthsPercent = (double)(z4.totalhealths) / (double)(z4.totalpeople);
            Zone z5 = new Zone(5, "Zichron-Yakov", 75000, 900, 74100, 7238974136.00);
            z5.HealthsPercent = (double)(z5.totalhealths) / (double)(z5.totalpeople);
            Zone z6 = new Zone(6, "Ceasaria", 72000, 1600, 70400, 7109853279.00);
            z6.HealthsPercent = (double)(z6.totalhealths) / (double)(z6.totalpeople);
               Zone z7 = new Zone(7, "Hadera", 80000, 500, 79500, 7689432678.00);
               z7.HealthsPercent = (double)(z7.totalhealths) / (double)(z7.totalpeople);
               Zone z8 = new Zone(8, "Netania", 120000, 800, 119200, 19876549765.00);
               z8.HealthsPercent = (double)(z8.totalhealths) / (double)(z8.totalpeople);
               Zone z9 = new Zone(9, "Hertelia", 150000, 1000, 149000, 25678549876.00);
               z9.HealthsPercent = (double)(z9.totalhealths) / (double)(z9.totalpeople);
               Zone z10 = new Zone(10, "Tel-Aviv", 500000, 6500, 493500, 50987123456.00);
               z10.HealthsPercent = (double)(z10.totalhealths) / (double)(z10.totalpeople);
            Zone z11 = new Zone(11, "Ashdod", 135000, 2000, 133000, 22876423789.00);
            z11.HealthsPercent = (double)(z11.totalhealths) / (z11.totalpeople);
            Zone z12 = new Zone(12, "Ashcelon", 140000, 2134, 137866, 23457812911.00);
            z12.HealthsPercent = (double)(z12.totalhealths) / (z12.totalpeople);
               Zone z13 = new Zone(13, "Jerusalim", 700000, 10000, 690000, 60987654789.00);
               z13.HealthsPercent = (double)(z13.totalhealths) / (double)(z13.totalpeople);
               Zone z14 = new Zone(14, "Beer-Sheva", 450000, 5000, 445000, 35980653215.00);
               z14.HealthsPercent = (double)(z14.totalhealths) / (double)(z14.totalpeople);
            Zone z15 = new Zone(15, "Dimona", 101457, 1345, 100112, 11457890456.00);
            z15.HealthsPercent = (double)(z15.totalhealths) / (double)(z15.totalpeople);
               Zone z16 = new Zone(16, "Eilat", 430000, 5000, 425000, 28790643128.00);
            z16.HealthsPercent = (double)(z16.totalhealths) / (double)(z16.totalpeople);
               zones.Add(z1);
               zones.Add(z2);
               zones.Add(z3);
               zones.Add(z4);
               zones.Add(z5);
               zones.Add(z6);
               zones.Add(z7);
               zones.Add(z8);
            zones.Add(z9);
            zones.Add(z10);
            zones.Add(z11);
            zones.Add(z12);
            zones.Add(z13);
            zones.Add(z14);
            zones.Add(z15);
            zones.Add(z16);
          }
          public List<String> aaraysZones()
          {
               List<String> a = new List<string>();
               foreach(var zon in this.zones)
               {
                    a.Add(zon.namezone);
               }
               return a;
          }
     }
}
