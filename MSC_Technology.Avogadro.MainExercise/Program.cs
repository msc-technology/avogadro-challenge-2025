using MSC_Technology.Avogadro.MainExcercise.VesselEntities;

namespace MSC_Technology.Avogadro.MainExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PORT_GENOVA = "Genova";
            const string PORT_TARANTO = "Taranto";

            Console.WriteLine("--- Exercise Demo ---\n");

            var myStandardVessel = new StandardVessel("MSC Standard", 500);
            var myBigVessel = new BigVessel("MSC Big");

            Console.WriteLine($"* Details for vessel {myStandardVessel.VesselName}" +
                $"\n{myStandardVessel.GetDetails()}");
            Console.WriteLine("\n");
            Console.WriteLine($"* Details for vessel {myBigVessel.VesselName}" +
                $"\n{myBigVessel.GetDetails()}");
            Console.WriteLine("\n");

            var pathManager = new PathManager();
            pathManager.AddVessel(myStandardVessel);
            pathManager.AddVessel(myBigVessel);

            List<Port> minimumPath = new();

            Console.WriteLine("\n--- DIJKSTRA EXECUTION ---\n");
            minimumPath = pathManager.FindMinimumPath(myStandardVessel.VesselName, PORT_GENOVA, PORT_TARANTO).ToList();
            PrintResult(minimumPath, myStandardVessel.VesselName, PORT_GENOVA, PORT_TARANTO);

            Console.WriteLine("\n--- DIJKSTRA EXECUTION ---\n");
            minimumPath = pathManager.FindMinimumPath(myStandardVessel.VesselName, PORT_GENOVA, PORT_GENOVA).ToList();
            PrintResult(minimumPath, myStandardVessel.VesselName, PORT_GENOVA, PORT_GENOVA);

            Console.WriteLine("\n--- DIJKSTRA EXECUTION ---\n");
            minimumPath = pathManager.FindMinimumPath(myBigVessel.VesselName, PORT_GENOVA, PORT_TARANTO).ToList();
            PrintResult(minimumPath, myBigVessel.VesselName, PORT_GENOVA, PORT_TARANTO);

            Console.ReadKey();
        }

        private static void PrintResult(IList<Port> minimumPath, string vesselName, string portNameFrom, string portNameTo)
        {

            if (minimumPath.Any())
            {
                Console.WriteLine($"Minimum path from {portNameFrom} to {portNameTo} for {vesselName} is:\n");

                foreach (var path in minimumPath)
                {
                    Console.WriteLine($"-- {path.GetName()}");
                }
            }
        }
    }
}