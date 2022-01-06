using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class Zone
     {
          public List<dataMonthZone> datamonthzone = new List<dataMonthZone>();
          private int id;
          public List<Neighabored> neighaboress = new List<Neighabored>();
          private String nameZone;
          private int totalPeople;
          private int totalPatients;
          private int totalHealths;
          private double percentHealths;
          private double amountEconomy;
          private String openOrClosed;
        private double infection_coeficcent;
        private string color;

          public Zone(int Id, String nZ, int totalpeo, int totalpatient, int totalhealth, double AmountEconomy)
          {
               this.nameZone = nZ;
               this.totalPeople = totalpeo;
               this.totalPatients = totalpatient;
               this.totalHealths = totalhealth;
               this.id = Id;
               this.amountEconomy = AmountEconomy;
               fillNeighbes();
          }
          public Zone()
          {
               fillNeighbes();
          }
          public String namezone
          {
               get
               {
                    return this.nameZone;
               }
               set
               {
                    this.nameZone = value;
               }
          }
          public int totalpeople
          {
               get
               {
                    return this.totalPeople;
               }
               set
               {
                    this.totalPeople = value;
               }
          }
          public int totalpateints
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
          public int totalhealths
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
          public int getId
          {
               get
               {
                    return this.id;
               }
               set
               {
                    this.id = value;
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
          public double HealthsPercent
          {
               get
               {
                    return this.percentHealths;
               }
               set
               {
                    this.percentHealths = value;
               }
          }
          public String OpenOrClosed
          {
               get
               {
                    return this.openOrClosed;
               }
               set
               {
                    this.openOrClosed = value;
               }
          }
        public double getCofficent_infection
        {
            get
            {
                return this.infection_coeficcent;
            }
            set
            {
                this.infection_coeficcent=value;
            }
        }
        public string getColor
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
          public void fillNeighbes()
          {
               dataMonthZone dz = new dataMonthZone();
               dz.getMonthId = 1;
               dz.getNmaePlace = this.nameZone;
               dz.getCountPeople = this.totalPeople;
               dz.getCountHealths = this.totalHealths;
               dz.getCountPatients = this.totalPatients;
               dz.getPercentHealths = (double)dz.getCountHealths / (double)dz.getCountPeople;
               dz.getAmountEconomy = this.amountEconomy;
               datamonthzone.Add(dz);
               String test = "NEVE-HAIM" + this.nameZone;
               Neighabored n1 = new Neighabored(1, test, 8000, 2, 2, 2, 100, 7900, 10987512.00);
               n1.getPercentHealths = (double)(n1.somehealts) / (double)(n1.somepeop);
               Neighabored n2 = new Neighabored(2, "YITHAK-RABIN" + this.nameZone, 8100, 2, 2, 2, 200, 7900, 12345987.00);
               n2.getPercentHealths = (double)(n2.somehealts) / (double)(n2.somepeop);
               Neighabored n3 = new Neighabored(3, "NEVE-SHANAN" + this.nameZone, 7900, 2, 2, 2, 300, 7600, 8976543.00);
               n3.getPercentHealths = (double)(n3.somehealts) / (double)(n3.somepeop);
               Neighabored n4 = new Neighabored(4, "NEVE-YITHAK" + this.nameZone, 8300, 2, 2, 2, 100, 8200, 15678951.00);
               n4.getPercentHealths = (double)(n4.somehealts) / (double)(n4.somepeop);
               Neighabored n5 = new Neighabored(5, "A-GEULA" + this.nameZone, 8500, 2, 2, 2, 200, 8300, 11245654.00);
               n5.getPercentHealths = (double)(n5.somehealts) / (double)(n5.somepeop);
               neighaboress.Add(n1);
               neighaboress.Add(n2);
               neighaboress.Add(n3);
               neighaboress.Add(n4);
               neighaboress.Add(n5);
          }
     }
}
