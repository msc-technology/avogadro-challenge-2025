using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Technology.Avogadro.MainExcercise.Tests
{
    public class PathManagerTests
    {
        #region Private Methods

        private static PathManager CreatePathManager() => new PathManager();

        private static VesselEntities.StandardVessel CreateStandardVessel()
        {
            string vesselName = "MSC Standard";
            int totalContainerNumber = 600;

            return new VesselEntities.StandardVessel(vesselName, totalContainerNumber);
        }

        #endregion

        /// <summary>
        /// Check if vessel is properly added to inner list
        /// </summary>
        [Fact]
        public void AddVessel_WhenCalledWithNewVessel_ShouldAddNewVessel()
        {
            // Arrange
            var pathManger = CreatePathManager();
            var vessel = CreateStandardVessel();

            // Act
            pathManger.AddVessel(vessel);
            var allVessels = pathManger.GetVessels();

            // Asset
            allVessels.Should().Contain(vessel);
        }

        /// <summary>
        /// Check if vessel is not duplicated after trying to add n already existing vessel on inner list
        /// </summary>
        [Fact]
        public void AddVessel_WhenCalledWithDuplicatedVessel_ShouldNotDuplicateVessel()
        {
            // Arrange
            var pathManger = CreatePathManager();
            var vesselA = CreateStandardVessel();
            var vesselB = CreateStandardVessel();

            // Act
            pathManger.AddVessel(vesselA);
            pathManger.AddVessel(vesselB);

            var allVessels = pathManger.GetVessels();
            int numberOfVesselWithStandardName = allVessels.Where(vessel => vessel.VesselName == "MSC Standard").Count();

            // Assert
            numberOfVesselWithStandardName.Should().Be(1);
        }

        [Fact]
        public void GetVessel_WhenCalled_ShouldReturnNotNullList()
        {
            // Arrange 
            var pathManager = CreatePathManager();

            // Act
            var allVessels = pathManager.GetVessels();

            // Assert
            allVessels.Should().NotBeNull();
        }
    }
}
