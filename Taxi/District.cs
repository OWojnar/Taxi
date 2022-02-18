using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi
{
    public class District
    {
        public District(int number, string name, int distnace)
        {
            Number = number;
            Name = name;
            DistanceFromCentrum = distnace;

        }
        public int Number { get; set; }
        public string Name { get; set; }
        public int DistanceFromCentrum { get; set; }
    }
}
