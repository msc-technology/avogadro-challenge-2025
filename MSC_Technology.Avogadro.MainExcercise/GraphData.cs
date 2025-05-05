using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise
{
    /// <summary>
    /// Class that contains the standard data.
    /// It should not be changed once cloned from the repository
    /// </summary>
    public static class GraphData
    {
        /// <summary>
        /// Retrieve the graph dedicated to standard vessels
        /// </summary>
        /// <returns>List of ports that compese the graph</returns>
        public static IList<Port> GetGraphForStandardVessel()
        {
            var portGenova = new Port("Genova");
            var portNapoli = new Port("Napoli");
            var portCivitavecchia = new Port("Civitavecchia");
            var portPalermo = new Port("Palermo");
            var portTaranto = new Port("Taranto");

            PortConnection.CreateConnectionBetween(portGenova, portNapoli, 10);
            PortConnection.CreateConnectionBetween(portGenova, portCivitavecchia, 5);
            PortConnection.CreateConnectionBetween(portNapoli, portCivitavecchia, 4);
            PortConnection.CreateConnectionBetween(portNapoli, portPalermo, 8);
            PortConnection.CreateConnectionBetween(portCivitavecchia, portTaranto, 6);
            PortConnection.CreateConnectionBetween(portPalermo, portTaranto, 7);

            var nodesList = new List<Port>
            {
                portGenova,
                portNapoli,
                portCivitavecchia,
                portPalermo,
                portTaranto
            };

            return nodesList;
        }

        /// <summary>
        /// Retrieve the graph dedicated to standard vessels
        /// </summary>
        /// <returns>List of ports that compese the graph</returns>
        public static IList<Port> GetGraphForBigVessels()
        {
            var portGenova = new Port("Genova");
            var portNapoli = new Port("Napoli");
            var portPalermo = new Port("Palermo");
            var portTaranto = new Port("Taranto");

            PortConnection.CreateConnectionBetween(portGenova, portNapoli, 10);
            PortConnection.CreateConnectionBetween(portNapoli, portPalermo, 6);
            PortConnection.CreateConnectionBetween(portNapoli, portTaranto, 7);
            PortConnection.CreateConnectionBetween(portPalermo, portTaranto, 15);

            var nodesList = new List<Port>
            {
                portGenova,
                portNapoli,
                portPalermo,
                portTaranto
            };

            return nodesList;
        }
    }
}
