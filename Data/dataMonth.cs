using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class dataMonth
     {
          private int MonthId;
          private string namePlace;
          private int countPeople;
          private int countHealths;
          private int countPatients;
          private double precentHealths;
          private double amountEconomy;
        private double coffiecient_infaction;

          public dataMonth()
          {

          }
          public int getMonthId
          {
               get
               {
                    return this.MonthId;
               }
               set
               {
                    this.MonthId = value;
               }
          }

          public string getNmaePlace
          {
               get
               {
                    return this.namePlace;
               }
               set
               {
                    this.namePlace = value;
               }
          }
          public int getCountPeople
          {
               get
               {
                    return this.countPeople;
               }
               set
               {
                    this.countPeople = value;
               }
          }
          public int getCountHealths
          {
               get
               {
                    return this.countHealths;
               }
               set
               {
                    this.countHealths = value;
               }
          }
          public int getCountPatients
          {
               get
               {
                    return this.countPatients;
               }
               set
               {
                    this.countPatients = value;
               }
          }
          public double getPercentHealths
          {
               get
               {
                    return this.precentHealths;
               }
               set
               {
                    this.precentHealths = value;
               }
          }
          public double getAmountEconomy
          {
               get
               {
                    return this.amountEconomy;
               }
               set
               {
                    this.amountEconomy = value;
               }
          }
        public double get_Coffiecint_Infaction
        {
            get
            {
                return this.coffiecient_infaction;
            }
            set
            {
                this.coffiecient_infaction = value;
            }
        }


     }
}
