using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class Item
     {
          int idItem;
          String nameItem;
          double someMoneyUnitItem;
          double howMuchItemInMarket;

     public Item(int iid,String nameofitem,double monetUnitItem,double countitems)
          {
               idItem = iid;
               nameItem = nameofitem;
               someMoneyUnitItem = monetUnitItem;
               howMuchItemInMarket = countitems;
          }
          public Item()
          {

          }
          public int ididofitem
          {
               get
               {
                    return this.idItem;
               }
               set
               {
                    this.idItem = value;
               }
          }
          public String NameOffItemm
          {
               get
               {
                    return this.nameItem;
               }
               set
               {
                    this.nameItem = value;
               }
          }
          public double SomeMoneyUnitOfItem
          {
               get
               {
                    return this.someMoneyUnitItem;
               }
               set
               {
                    this.someMoneyUnitItem = value;
               }
          }
          public double HowMuchiteminMarket
          {
               get
               {
                    return this.howMuchItemInMarket;
               }
               set
               {
                    this.howMuchItemInMarket = value;
               }
          }

     
     }


}
