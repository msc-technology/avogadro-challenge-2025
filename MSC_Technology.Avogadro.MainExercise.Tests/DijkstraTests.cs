using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise.Tests
{
    public class DijkstraTests
    {
        #region Private Methods

        private static PathManager CreatePathManager() => new PathManager();

        private static VesselEntities.StandardVessel CreateStandardVessel()
        {
            string vesselName = "MSC Standard";
            int totalContainerNumber = 600;

            return new VesselEntities.StandardVessel(vesselName, totalContainerNumber);
        }

        private static VesselEntities.BigVessel CreateBigVessel()
        {
            string vesselName = "MSC Big";

            return new VesselEntities.BigVessel(vesselName);
        }

        private static IList<Port> GetExpectedPathForStandardVessels()
        {
            return new List<Port>
            {
                new Port("Genova"),
                new Port("Civitavecchia"),
                new Port("Taranto")
            };
        }

        private static IList<Port> GetExpectedPathForBigVessels()
        {
            return new List<Port>
            {
                new Port("Genova"),
                new Port("Napoli"),
                new Port("Taranto")
            };
        }

        #endregion
        
        /// <summary>
        /// Check if algorithm return correct minimum path for Standard Vessels
        /// </summary>
        [Fact]
        public void FindMinimumPath_WhenCalledForStandardVessels_ShouldReturnDedicatedPath()
        {
            // Arrange
            var pathManager = CreatePathManager();
            var standardVessel = CreateStandardVessel();
            var expectedResult = GetExpectedPathForStandardVessels();

            // Act
            pathManager.AddVessel(standardVessel);
            var minimumPath = pathManager.FindMinimumPath("MSC Standard", "Genova", "Taranto");

            // Assert
            minimumPath.Should().BeEquivalentTo(expectedResult);
        }

        /// <summary>
        /// Check if algorithm return correct minimum path for Big Vessels
        /// </summary>
        [Fact]
        public void FindMinimumPath_WhenCalledForBigVessels_ShouldReturnDedicatedPath()
        {
            // Arrange
            var pathManager = CreatePathManager();
            var bigVessel = CreateBigVessel();
            var expectedResult = GetExpectedPathForBigVessels();

            // Act
            pathManager.AddVessel(bigVessel);
            var minimumPath = pathManager.FindMinimumPath("MSC Big", "Genova", "Taranto");

            // Assert
            minimumPath.Should().BeEquivalentTo(expectedResult);
        }
    }
}
