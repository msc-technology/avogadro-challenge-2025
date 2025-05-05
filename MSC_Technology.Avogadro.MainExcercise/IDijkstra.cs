using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise
{
    public interface IDijkstra
    {
        IList<Port> FindMinimumPath(string vesselName, string portNameFrom, string portNameTo);
    }
}
