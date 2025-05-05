using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise.VesselEntities
{
    public class StandardVessel : Vessel
    {
        public double TotalContainerNumber { get; set; }

        public StandardVessel(string vesselName, int toatalContainerNumber)
            : base(vesselName, VesselDimension.Standard)
        {
            TotalContainerNumber = toatalContainerNumber;
        }

        public override string GetDetails()
        {
            return $"Vessel name: {VesselName}." +
                $"\nThis is a vessel that can embark {TotalContainerNumber} normal container";
        }
    }
}
