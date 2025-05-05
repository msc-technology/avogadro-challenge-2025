using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise.VesselEntities
{
    public class BigVessel : Vessel
    {
        public BigVessel(string vesselName)
            : base(vesselName, VesselDimension.Big)
        {

        }

        public override string GetDetails()
        {
            return $"Vessel {VesselName} is has different dimension compared to the standard one." +
                $"\nIt can not cross all the ports present and needs a dedicated graph.";
        }
    }
}
