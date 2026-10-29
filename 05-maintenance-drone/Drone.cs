public class Drone
{
    public string Name { get; set; }
    public int FlightHours { get; set; }

    public string Flyplassen { get; set; } = "";

    public Drone(string name, int flightHours, string flyplassen = "")
    {
        Name = name;
        FlightHours = flightHours;
        Flyplassen = flyplassen;
    }

    public string Describe()
    {

        // TODO

        return Name + " has flown for " + FlightHours + " hours and is stationed at " + Flyplassen;
    }

    public bool NeedsService()
    {
        if (FlightHours >= 100)
        {

            return true;
        }
        else
        {
            return false;
        }


        // TODO

    }
}
