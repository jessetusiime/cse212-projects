public class FeatureCollection
{
    public List<EarthquakeFeature> Features { get; set; } = new List<EarthquakeFeature>();
}

public class EarthquakeFeature
{
    public EarthquakeProperties Properties { get; set; } = new EarthquakeProperties();
}

public class EarthquakeProperties
{
    public double Mag { get; set; }
    public string Place { get; set; } = string.Empty;
    public long Time { get; set; }
}