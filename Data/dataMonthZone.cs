using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
    public class dataMonthZone : dataMonth
    {
        string colur;
        public dataMonthZone()
             : base()
        {

        }
        public string getcolour
        {
            get
            {
                return this.colur;
            }
            set
            {
                this.colur = value;
            }
        }
      
     }
}
