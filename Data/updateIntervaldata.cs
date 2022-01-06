using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class updateIntervaldata
     {
          User user;
          Country country;
          dataMonthNeighbored dn;
          dataMonthZone dz;
          public updateIntervaldata()
          {

          }
          public void updateData(object sender, System.Timers.ElapsedEventArgs e)
          {
               int maxn = 0;
               int maxz = 0;
               double sum = 0;
               user = User.GetInstance;
               if (user.getisload)
               {
                    country = Country.GetInstance;
                updateColur();
                    for (int i = 0; i < country.zones.Count; i++)
                    {
                         sum = 0;
                         for (int j = 0; j < country.zones[i].neighaboress.Count; j++)
                         {
                              maxn = country.zones[i].neighaboress[j].datamonthneighbored.Count;
                              dn = new dataMonthNeighbored();
                              dn.getMonthId = maxn + 1;
                              dn.getNmaePlace = country.zones[i].neighaboress[j].NameNeigh;
                              dn.getCountPeople = country.zones[i].neighaboress[j].somepeop;
                              dn.getCountPatients = country.zones[i].neighaboress[j].somepat;
                              dn.getCountHealths = country.zones[i].neighaboress[j].somehealts;
                              dn.getPercentHealths = country.zones[i].neighaboress[j].getPercentHealths;
                              dn.getAmountEconomy = country.zones[i].neighaboress[j].getAmountEconomy;
                              country.zones[i].neighaboress[j].datamonthneighbored.Add(dn);
                              double mana = (double)(country.zones[i].neighaboress[j].somepat) / (double)(country.zones[i].neighaboress[j].somepeop);
                              double hezka = Math.Pow(2.72, mana);
                              double newdata = hezka * country.zones[i].neighaboress[j].somepat - country.zones[i].neighaboress[j].somepat + country.zones[i].neighaboress[j].somehealts;
                              country.zones[i].neighaboress[j].somehealts = (int)newdata;
                              country.zones[i].neighaboress[j].somepat = country.zones[i].neighaboress[j].somepeop - country.zones[i].neighaboress[j].somehealts;
                        country.zones[i].neighaboress[j].getPercentHealths = (double)(country.zones[i].neighaboress[j].somehealts) / (double)(country.zones[i].neighaboress[j].somepeop);
                              sum = sum + (double)(country.zones[i].neighaboress[j].somehealts) / (double)(country.zones[i].neighaboress[j].somepeop);
                              country.zones[i].neighaboress[j].getAmountEconomy = country.zones[i].neighaboress[j].getAmountEconomy * 1.2;





                         }
                         maxz = country.zones[i].datamonthzone.Count;
                         dz = new dataMonthZone();
                         dz.getMonthId = maxz + 1;
                         dz.getNmaePlace = country.zones[i].namezone;
                         dz.getCountPeople = country.zones[i].totalpeople;
                         dz.getCountPatients = country.zones[i].totalpateints;
                         dz.getCountHealths = country.zones[i].totalhealths;
                         dz.getPercentHealths = (double)(country.zones[i].totalhealths) / (double)(country.zones[i].totalpeople);
                         dz.getAmountEconomy = country.zones[i].getAmountEconomy;
                    dz.getcolour = country.zones[i].getColor;
                         country.zones[i].datamonthzone.Add(dz);
                         double mena = sum / country.zones[i].neighaboress.Count;
                         country.zones[i].totalpateints = (int)(mena * country.zones[i].totalpateints);
                         sum = 0;
                         country.zones[i].totalhealths = country.zones[i].totalpeople - country.zones[i].totalpateints;
                         country.zones[i].HealthsPercent = (double)(country.zones[i].totalhealths) / (double)(country.zones[i].totalpeople);
                         country.zones[i].getAmountEconomy = country.zones[i].getAmountEconomy * 1.02;


                    }
               }
          }
        public void updateColur()
        {
            string[] arra = new string[country.zones.Count];
            string[] arrb = new string[country.zones.Count];
            string[] arrc = new string[country.zones.Count];
            int counta = 0;
            int countb = 0;
            int countc = 0;
            double suma = 0;
            double sumb = 0;
           double sumc = 0;
            double avga = 0;
            double avgb = 0;
            double avgc = 0;
            for(int i=0;i<country.zones.Count;i++)
            {
                country.zones[i].HealthsPercent = (double)(country.zones[i].totalhealths) / (double)(country.zones[i].totalpeople);
            }
            for(int i=0;i<country.zones.Count;i++)
            {
                suma = suma + country.zones[i].HealthsPercent;
            }
            avga = (double)suma /country.zones.Count;
            for(int i=0;i<country.zones.Count;i++)
            {
                if(country.zones[i].HealthsPercent>=avga)
                {
                    arra[counta] = country.zones[i].namezone;
                    country.zones[i].getColor = "Green";
                    counta++;
                }
                else
                {
                    arrb[countb] = country.zones[i].namezone;
                    countb++;
                }
            }
            for(int i=0;i<countb;i++)
            {
                for(int j=0;j<country.zones.Count;j++)
                {
                    if(country.zones[j].namezone.Equals(arrb[i]))
                    {
                        sumb = sumb + country.zones[j].HealthsPercent;
                        break;
                    }
                }
            }
            avgb = (double)sumb / countb;
            for(int i=0;i<countb;i++)
            {
                for(int j=0;j<country.zones.Count;j++)
                {
                    if(arrb[i].Equals(country.zones[j].namezone))
                    {
                        if(country.zones[j].HealthsPercent>=avgb&&country.zones[j].HealthsPercent<avga)
                        {
                            country.zones[j].getColor = "Yellow";
                        }
                       if(country.zones[j].HealthsPercent<avgb)
                        {
                            arrc[countc] = country.zones[j].namezone;
                            countc++;
                        }
                    }
                }
            }
            for(int i=0;i<countc;i++)
            {
                for(int j=0;j<country.zones.Count;j++)
                {
                   if(country.zones[j].namezone.Equals(arrc[i]))
                    {
                        sumc = sumc + country.zones[j].HealthsPercent;
                        break;
                    }

                }

            }
            avgc = (double)sumc / countc;
            for(int i=0;i<countc;i++)
            {
                for(int j=0;j<country.zones.Count;j++)
                {
                    if(country.zones[j].namezone.Equals(arrc[i]))
                    {
                        if(country.zones[j].HealthsPercent>=avgc&&country.zones[j].HealthsPercent<avgb)
                        {
                            country.zones[j].getColor = "Orange";
                        }
                        if(country.zones[j].HealthsPercent<avgc)
                        {
                            country.zones[j].getColor = "Red";
                        }
                    }
                }
            }


        }
       
     }
}
