using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class CelebrationPlace:EventPlace
     {
          public CelebrationPlace(String nE, String nM, int hMW, int capacclients, int currentclients)
          :base(nE, nM, hMW, capacclients, currentclients)
          {

          }
          public CelebrationPlace()
               :base()
          {

          }
     }
}
