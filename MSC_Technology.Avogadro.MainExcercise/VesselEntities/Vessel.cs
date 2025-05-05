using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise.VesselEntities
{
    public enum VesselDimension
    {
        Standard,
        Big
    }

    /// <summary>
    /// Vessel abstract class. Override of Equals and GetHashCode is needed to comperisone, do not change it.
    /// </summary>
    public abstract class Vessel
    {
        public string VesselName { get; set; }
        public VesselDimension VesselDimension { get; set; }

        public Vessel(string vesselName, VesselDimension vesselDimension)
        {
            VesselName = vesselName;
            VesselDimension = vesselDimension;
        }

        public virtual string GetDetails()
        {
            return $"Vessel name: {VesselName}." +
                $"\nThis is a generic Vessel.";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Vessel)
            {
                var objVessel = obj as Vessel;
                var objVesselName = objVessel?.VesselName ?? string.Empty;

                return VesselName == objVesselName;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return VesselName.GetHashCode();
        }
    }
}
