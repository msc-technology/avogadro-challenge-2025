using MSC_Technology.Avogadro.MainExcercise.VesselEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise
{
    public class PathManager : IDijkstra
    {
        private readonly IList<Vessel> _allVessels;

        private readonly IList<Port> _graphForStandardVessels;
        private readonly IList<Port> _graphForBigVessels;

        public PathManager()
        {
            _graphForStandardVessels = GraphData.GetGraphForStandardVessel();
            _graphForBigVessels = GraphData.GetGraphForBigVessels();
        }

        public void AddVessel(Vessel vessel)
        {
            throw new NotImplementedException();
        }

        public IList<Port> FindMinimumPath(string vesselName, string portNameFrom, string portNameTo)
        {
            throw new NotImplementedException();
        }

        public IList<Vessel> GetVessels() => _allVessels;
    }
}
