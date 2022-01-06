using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class HomeItem:Item
     {
          public HomeItem(int i, String n, double Sm,double ci)
             : base(i, n, Sm,ci)
          {
          }
          public HomeItem()
               :base()
          {

          }
     }
}
