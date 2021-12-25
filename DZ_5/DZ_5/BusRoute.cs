using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5
{
    class BusRoute
    {
        public int id { get; set; }
        public string pointdep { get; set; }
        public string pointarr { get; set; }
        public int sum { get; set; }





        public BusRoute(int id,  string pointdep, string pointarr, int sum)
        {
            this.id = id;
            this.pointdep = pointdep;
            this.pointarr = pointarr;
            this.sum = sum;
        }
    }
}
