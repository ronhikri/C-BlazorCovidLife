using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class Neighabored
     {
          public List<EventPlace> Eventss = new List<EventPlace>();
          public List<dataMonthNeighbored> datamonthneighbored = new List<dataMonthNeighbored>();
          private int idNeighabore;
          private String nameNeighbored;
          private int somepeople;
          private int someschools;
          private int somemarkets;
          private int somecelebrationplaces;
          private int somepatients;
          private int somehealths;
          private double amountEconomy;
          private double percentHealths;
        private double infection_coeficcent;
        public Neighabored(int idneighbored, String N_Neighbored, int somePeople, int someSchools, int someMarkets, int someCelebrationPlace, int somePatients, int someHealths, double AmountEconomy)
          {
               this.idNeighabore = idneighbored;
               this.nameNeighbored = N_Neighbored;
               this.somepeople = somePeople;
               this.someschools = someSchools;
               this.somemarkets = someMarkets;
               this.somecelebrationplaces = someCelebrationPlace;
               this.somepatients = somePatients;
               this.somehealths = someHealths;
               this.amountEconomy = AmountEconomy;
               fillevents();

          }
          public int getid
          {
               get
               {
                    return this.idNeighabore;
               }
               set
               {
                    this.idNeighabore = value;
               }
          }
          public String NameNeigh
          {
               get
               {
                    return this.nameNeighbored;
               }
               set
               {
                    this.nameNeighbored = value;
               }
          }
          public Neighabored()
          {
               fillevents();
          }
          public int somepeop
          {
               get
               {
                    return this.somepeople;
               }
               set
               {
                    this.somepeople = value;
               }
          }
          public int someschol
          {
               get
               {
                    return this.someschools;
               }
               set
               {
                    this.someschools = value;
               }
          }
          public int somesupermarkets
          {
               get
               {
                    return this.somemarkets;
               }
               set
               {
                    this.somemarkets = value;
               }
          }
          public int somecelebrationplac
          {
               get
               {
                    return this.somecelebrationplaces;

               }
               set
               {
                    this.somecelebrationplaces = value;
               }
          }
          public int somepat
          {
               get
               {
                    return this.somepatients;
               }
               set
               {
                    this.somepatients = value;
               }
          }
          public int somehealts
          {
               get
               {
                    return this.somehealths;
               }
               set
               {
                    this.somehealths = value;
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
          public double getPercentHealths
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
        public double getinfection_coffiecent
        {
            get
            {
                return infection_coeficcent;
            }
            set
            {
                this.infection_coeficcent = value;
            }
        }
          public void fillevents()
          {
               dataMonthNeighbored dn = new dataMonthNeighbored();
               dn.getMonthId = 1;
               dn.getNmaePlace = this.nameNeighbored;
               dn.getCountPeople = this.somepeople;
               dn.getCountHealths = this.somehealths;
               dn.getCountPatients = this.somepatients;
               dn.getPercentHealths = (double)(this.somehealts) / (double)(this.somepeople);
               dn.getAmountEconomy = this.amountEconomy;
               datamonthneighbored.Add(dn);
               School sc1 = new School("Tichon-Hadera" + this.nameNeighbored, "Yael", 200, 2500, 2500);
               School sc2 = new School("new Tichon" + this.nameNeighbored, "Auvi", 100, 2500, 2500);
               Eventss.Add(sc1);
               Eventss.Add(sc2);
               SuperMarket sp1 = new SuperMarket("Suk-Yeuda" + this.nameNeighbored, "Yakov", 6, 60, 60);
               SuperMarket sp2 = new SuperMarket("Rami-Levi" + this.nameNeighbored, "Ori", 5, 60, 60);
               Eventss.Add(sp1);
               Eventss.Add(sp2);
               CelebrationPlace cp1 = new CelebrationPlace("White-nights" + this.nameNeighbored, "Yuda", 20, 250, 250);
               CelebrationPlace cp2 = new CelebrationPlace("Sea-Stars" + this.nameNeighbored, "Dani", 30, 250, 250);
               Eventss.Add(cp1);
               Eventss.Add(cp2);
          }

     }
}
