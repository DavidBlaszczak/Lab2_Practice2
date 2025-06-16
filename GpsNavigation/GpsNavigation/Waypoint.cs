namespace GpsNavigation;

public class Waypoint
{
    public string Name { get; }

    public (double Latitude, double Longitude) Coordinates { get; }

    public Waypoint(string name, double latitude, double longitude)
    {
        Name = name;
        Coordinates = (latitude, longitude);
    }

    public (double, double) GetCoordinates()
    {
        return (Coordinates.Latitude, Coordinates.Longitude);
    }

    public void Deconstruct(out double latitude, out double longitude)
    {
        latitude = Coordinates.Latitude;
        longitude = Coordinates.Longitude;
    }
}
