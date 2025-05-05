# Avogadro Challenge 2025
Avogadro 2025 - Exercise about OOP and Dijkstra algorithm  
  
Main branch contains the core solution that should be used as starting point.  
No one should push directly to main.  
The solution is partially covered with XUnit test, and is mandatory to have them all marked as Passed.

## Summary:
MSC needs to calculate the optimal minimum path that a Vessel has to follow in order to reach the port of **Taranto** starting from the port of **Genova**. Since there are many possibilities valuate, it has been decided to represent the connection between each port with a **graph**, and use the **Dijkstra algorithm** to determinate which is the best option between the possible routes.

To define the graph, it has been decided to use each available Port as a Node and, as a consequence, the **arcs** will be the distance between each Port and its neighbours Ports.

Every arch has its own weight, and will be a two-way connection (for example, if a node A is connected to node B with a weight of 5, also the weight that connect node B to A will have the same weight)

Moreover, the weight of an arch between two nodes is not representing a distance in nautical miles between them, but a value of “efficiency” calculated based on complex internal assessments.

At the bottom of the document, you can find two different graph: a StandardGraph suitable for standard vessels and a BigGraph, that is suitable for big vessels.

_**It’s also required to implement this solution following the fundamentals principals of OOP.**_

## Data Definition:
To proceed, please follow what is indicated in below data definition:
-	**Port:** A class that representative a port belonging to MSC.
  It must contain a Name.
 	The instance of Port will have to represents a node of the graph.
 	> **It’s mandatory to apply (at least) the fundamental principle of “_Encapsulation_”.**

-	**Arc:** It represents the distance between two ports, and the weight of their connection.
  There are many ways in which the implementation of arcs can be manged.
 	The candidate is left to decide how to manage it (for example, with a dedicated class, or adding to each port a list of adjacent port with their own weight).

-	**Vessel:** A class that cannot be directly instantiate, representing a cargo ship.
  It will contain the name assigned to it and a method GetDetails(), which base implementation have to return a string containing the type of the vessel and its name. The implementation of this method can be modified from the classes that will extend Vessel.
 	> **Within this class, it’s required to apply both “_Inheritance_” and “_Polymorphism_” principals.**

-	**StandardVessel:** A class that inherit from Vessel, and that add the necessity of specify the maximum number of container that con be embark on the ship.
  **GetDetails()** method should include this information in addition of the others details already retrieved.

-	**BigVessel:** A class that inherits from Vessel.
  Due to its dimensions, it cannot go through some specific ports.
 	In addition of reporting this information when **GetDetails()** is called (you don’t have to specify which port will be avoided), keep in mind that this vessel needs a dedicated graph.

-	**PathManager:** An utility class that will contain a list of Vessel that have been previously created. It will take care of recall/implement the **FindMinimumPath(…)** method.

-	**IDijkstra:** As can be seen from naming conventions, it’s an interface that have to contain the method **FindMinimumPath(…)** that, taking as input the name of starting node (Port) and the name of arrival node (Port), have to return the list of all the nodes (Ports) that the vessel have to go through to arrive at destination.
  This list must contain the entire route, that will also include both start and arrival port.
 	> **Throught interface, it’s necessary to explore what concern the fundamental principle of “_Anstractions_”**, leaving the candidate to choose between two options: Implement FindMinimumPath method directly into PathManager class or Create a dedicated class that will implement this interface, than instantiate/recall it inside PathManager.

## Graphs Definition:
**StandardGraph:**
-	Genova (Civitavecchia, 5) – (Napoli, 10)
-	Civitavecchia (Genova, 5) – (Napoli, 4) – (Taranto, 6)
-	Napoli (Genova, 10) – (Civitavecchia, 4) – (Palermo, 8) 
-	Palermo (Napoli, 8) – (Taranto, 7)
-	Taranto (Civitavecchia, 6) – (Palermo, 7)

**BigGraph:**
-	Genova (Napoli, 10)
-	Napoli (Genova, 10) – (Palermo, 6) – (Taranto, 15)
-	Palermo (Napoli, 6) – (Taranto, 7)
-	Taranto (Napoli, 15) – (Palermo, 7)

## Additional Point:
For the ones that want to deal with this exercise in a more challenging way, there is an additional point that can make things more interesting.
You can try to move everything that concern Dijkstra algorithm in a dedicated project (it’s also good to keep it in the same solution, but in a dedicated Class Library project) and make it GENERIC.
The meaning of this approach is not only the possibility to isolate and reuse the algorithm you have already implemented, but also to give the possibility of a generic usage of the algorithm, leaving the once who will implement it decide which type of object (class) should be considered as a Node, and that should not affect in any ways the implementation of the algorithm itself.

## Conclusion:
Hoping that all of this can be taken as a funny, enjoyable and interesting entertainment, I wish you a good work and a good continuation.
