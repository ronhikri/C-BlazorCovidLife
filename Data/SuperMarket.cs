using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class SuperMarket:EventPlace
     {
         public List<Item> itemss = new List<Item>();
          public SuperMarket(String nE, String nM, int hMW, int capacclients, int currentclients)
               :base(nE,nM,hMW,capacclients,currentclients)
          {
               fillmarket();
          }
          public SuperMarket()
          :base()
          {
               fillmarket();
          }
          public void fillmarket()
          {
               FoodItem it1 = new FoodItem(1,"eggs",2.0,100.0);
               FoodItem it2 = new FoodItem(2, "poteto", 1.0,90.0);
               FoodItem it3 = new FoodItem(3, "tometo", 1.0,200.0);
               FoodItem it4 = new FoodItem(4, "cucumber", 1.0,200.0);
               FoodItem it5 = new FoodItem(5, "milk buttle", 1.5,150.0);
               FoodItem it6 = new FoodItem(6, "mit", 5.5,80.0);
               FoodItem it7 = new FoodItem(7, "water buttle", 0.5,250.0);
               FoodItem it8 = new FoodItem(8, "Kola-water", 2.5,130.0);
               FoodItem it9 = new FoodItem(9, "breed", 1.0,250.0);
               FoodItem it10 = new FoodItem(10, "carrot", 2.0, 100.0);
               FoodItem it11 = new FoodItem(11, "apple", 2.0,100.0);
               itemss.Add(it1);
               itemss.Add(it2);
               itemss.Add(it3);
               itemss.Add(it4);
               itemss.Add(it5);
               itemss.Add(it6);
               itemss.Add(it7);
               itemss.Add(it8);
               itemss.Add(it9);
               itemss.Add(it10);
               itemss.Add(it11);
               HomeItem it12 = new HomeItem(12, "bed", 60.0,20.0);
               HomeItem it13 = new HomeItem(13, "kettle", 12.0,50.0);
               HomeItem it14 = new HomeItem(14, "mikro-wave", 50.0,25.0);
               HomeItem it15 = new HomeItem(15, "freezer", 90.0,15.0);
               HomeItem it16 = new HomeItem(16, "window", 20.0,45.0);
               HomeItem it17 = new HomeItem(17, "closet", 60.0,20.0);
               HomeItem it18 = new HomeItem(18, "drawer", 10.0,60.0);
               HomeItem it19 = new HomeItem(19, "table", 30.0,50.0);
               HomeItem it20 = new HomeItem(20, "chair", 10.0,70.0);
               itemss.Add(it12);
               itemss.Add(it13);
               itemss.Add(it14);
               itemss.Add(it15);
               itemss.Add(it16);
               itemss.Add(it17);
               itemss.Add(it18);
               itemss.Add(it19);
               itemss.Add(it20);


          }
     }
}
