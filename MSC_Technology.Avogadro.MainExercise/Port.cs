using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise
{
    /// <summary>
    /// Port class that should be considered as a Node of the graph. Override of Equals and GetHashCode is needed to comperisone, do not change it.
    /// </summary>
    public class Port
    {
        // Maybe something is missing here?

        public Port(string portName)
        {

        }

        /// <summary>
        /// Add new port connection for the actual port.
        /// </summary>
        /// <param name="connection">port and weight to create a connection</param>
        public void AddPortConnection(PortConnection connection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the name of th vessel
        /// </summary>
        /// <returns>Instance's vessel name</returns>
        public string GetName() => throw new NotImplementedException();

        /// <summary>
        /// Get all the port(s) connected to actual port
        /// </summary>
        /// <returns>List of ports connected</returns>
        public IList<PortConnection> GetPortConnections() => throw new NotImplementedException();

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Port)
            {
                var objPort = obj as Port;
                var objPortName = objPort?.GetName() ?? string.Empty;

                return GetName() == objPortName;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return GetName().GetHashCode();
        }
    }
}
