using System;
using System.Collections.Generic;
using System.Text;

namespace MyTotto.Data.Models.Comparers
{
    public class ManufacturerEqualityComparer : IEqualityComparer<Manufacturer>
    {
        public bool Equals(Manufacturer m1, Manufacturer m2)
        {
            return m1.Id == m2.Id;
        }

        public int GetHashCode(Manufacturer manufacturer)
        {
            return manufacturer.Id.GetHashCode();
        }
    }
}
