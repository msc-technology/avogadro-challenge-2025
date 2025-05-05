using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise
{
    /// <summary>
    /// Class created to manage connection between port.
    /// <para>It could be a starting point an can be used as it is, but feel free to change it if necessary for your implementation.</para>
    /// </summary>
    public class PortConnection
    {
        private readonly Port _port;
        private readonly int _weight;

        public PortConnection(Port port, int weight)
        {
            _port = port;
            _weight = weight;
        }

        /// <summary>
        /// Create connection to a Port (node) defining the weight of the arc
        /// </summary>
        /// <param name="portTo">Destination port</param>
        /// <param name="weight">Weight of the arc</param>
        /// <returns></returns>
        public static PortConnection CreateConnectionTo(Port portTo, int weight)
        {
            return new PortConnection(portTo, weight);
        }

        /// <summary>
        /// Create a bidirectional connection between two Ports (nodes)
        /// </summary>
        /// <param name="portA">First port</param>
        /// <param name="portB">Second port</param>
        /// <param name="weight">Weight of the arc</param>
        public static void CreateConnectionBetween(Port portA, Port portB, int weight)
        {
            var connectionToPortA = CreateConnectionTo(portB, weight);
            var connectionToPortB = CreateConnectionTo(portA, weight);

            portA.AddPortConnection(connectionToPortA);
            portB.AddPortConnection(connectionToPortB);
        }

        public Port GetConnectedPort() => _port;
        public int GetConnectionWeight() => _weight;
    }
}
