using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode {
    public class Trip {
        public FirstLine FirstLine { get; set; }
        public List<Ride> Rides { get; set; }
        public Corner[,] Map { get; set; }

    }
}
