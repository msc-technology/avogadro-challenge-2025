using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise.Tests
{
    public class PortTests
    {
        #region Private Methods

        private static Port CreatePort(string portName) 
            => new Port(portName);

        private static PortConnection CreatePortConnection(string portName, int weight)
            => new PortConnection(CreatePort(portName), weight);

        #endregion

        [Fact]
        public void Dummy_Working_Test()
        {
            // Arrange
            Port newPort = null!;

            // Act
            newPort = CreatePort("Dummy");

            // Assert
            newPort.Should().NotBeNull();
        }

        /// <summary>
        /// Check if connection to a port has been added properly
        /// </summary>
        [Fact]
        public void AddConnection_WhenCalledWithNewPort_ShouldAddPortConnection()
        {
            // Arrange
            var port = CreatePort("Port A");
            var portConnection = CreatePortConnection("Port B", 7);

            // Act
            port.AddPortConnection(portConnection);
            var portConnections = port.GetPortConnections();

            // Assert
            portConnections.Should().Contain(portConnection);
        }

        /// <summary>
        /// Check if connection to the port is not duplicated after trying to add an existing connection
        /// </summary>
        [Fact]
        public void AddConnection_WhenCalledWithDuplicatedConnection_ShouldNotDuplicateConnection()
        {
            // Arrange
            var port = CreatePort("Port A");
            var firstPortConnection = CreatePortConnection("Port B", 7);
            var secondPortConnection = CreatePortConnection("Port B", 4);

            // Act
            port.AddPortConnection(firstPortConnection);
            port.AddPortConnection(secondPortConnection);

            var portConnections = port.GetPortConnections();
            var numberOfConnectionWithB = portConnections.Where(connection => connection.GetConnectedPort().GetName() == "Port B").Count();

            // Assert
            numberOfConnectionWithB.Should().Be(1);
        }

        /// <summary>
        /// Check if port name is properly filled when new instance is created.
        /// </summary>
        [Fact]
        public void GetName_WhenCalled_ShouldReturnPortName()
        {
            // Arrange
            const string PORT_GENOVA = "Genova";

            // Act
            var portGenova = new Port(PORT_GENOVA);
            var portName = portGenova.GetName();

            // Assert
            portName.Should().Be(PORT_GENOVA);
        }

        /// <summary>
        /// Check if list of connections is not null when new instance is created.
        /// </summary>
        [Fact]
        public void GetConnections_WhenCalledRightBeforeConstructor_ShouldReturnNotNullList()
        {
            // Arrange
            const string PORT_GENOVA = "Genova";

            // Act
            var portGenova = new Port(PORT_GENOVA);
            var portConnections = portGenova.GetPortConnections();

            // Assert
            portConnections.Should().NotBeNull();
        }

        /// <summary>
        /// Check if list of connection is empty when new instance is created.
        /// </summary>
        [Fact]
        public void GetConnections_WhenCalledRightBeforeConstructor_ShouldReturnEmptyList()
        {
            // Arrange
            const string PORT_GENOVA = "Genova";

            // Act
            var portGenova = new Port(PORT_GENOVA);
            var portConnections = portGenova.GetPortConnections();

            // Assert
            portConnections.Should().BeEmpty();
        }
    }
}
