using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class School:EventPlace
     {
          public School(String nE, String nM, int hMW, int capacclients, int currentclients)
               :base(nE, nM, hMW, capacclients, currentclients)
          {

          }
          public School()
               :base()
          {

          }

     }
}
