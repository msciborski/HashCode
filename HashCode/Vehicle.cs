using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public class Vehicle
    {
        private Ride ride;
        public int ID;
        public List<Ride> Rides= new List<Ride>();
        public bool IsBusy { get; set; }
        public Corner CurrentPosition { get; set; }
        private int remainingRoad = 0;

        public void SetNewRide(Ride newRide)
        {
            ride = newRide;
            remainingRoad = ride.Length + (Math.Abs(CurrentPosition.Row - ride.Start.Row) + Math.Abs(CurrentPosition.Column - ride.Start.Column));
            IsBusy = true;
        }

        public void CheckForDoneRide()
        {
            if (remainingRoad > 0)
            {
                remainingRoad--;
            }
            else
            {
                Rides.Add(ride);
                IsBusy = false;
                CurrentPosition = ride.Stop;
            }
        }

    }
}
