Drone alpha = new Drone("Alpha", 40, "Oslo Airport");
Drone beta = new Drone("Beta", 115, "Bergen Airport");
Drone gamma = new Drone("Gamma", 100, "Trondheim Airport");

Drone xml = new Drone("XML", 190, "Stavanger Airport");
Drone json = new Drone("JSON", 50, "Tromso Airport");

Drone[] drones = { alpha, beta, gamma, xml, json };

foreach (Drone drone in drones)
{
    Console.WriteLine(drone.Describe());
    Console.WriteLine($"Needs service: {drone.NeedsService()}");

}
