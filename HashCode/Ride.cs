using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode {
    public class Ride {
        public int ID { get; set; }
        public Corner Start { get; set; }
        public Corner Stop { get; set; }
        public int Earliest { get; set; }
        public int Latest { get; set; }

        public int Length => (Math.Abs(Start.Row - Stop.Row) + Math.Abs(Start.Column - Stop.Column));
    }
}
