using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi
{
   public class Cab
    {
        public Cab(int id, string car, District district)
        {
            Id = id;
            Car = car;
            CurrentDistrict = district;
            IsAvalible = true;
        }
        public int Id { get; set; }
        public string Car { get; set; }
        public District CurrentDistrict { get; set; }
        public bool IsAvalible { get; set; }

        public int ArrivalTime { get; set; }

        public void CalculateArrivalTime(District customerDistrict)
        {
            Id (IsAvalible)
                {
                if (customerDistrict.Number == CurrentDistrict.Number)
                    ArrivalTime = 4;
                else
                {
                    var route = customerDistrict.DistanceFromCentrum - CurrentDistrict.DistanceFromCentrum);
                    ArrivalTime = route * 5;
                }
                if (!IsAvalible)
                    ArrivalTime += 12;
            }
        }
    }
}
