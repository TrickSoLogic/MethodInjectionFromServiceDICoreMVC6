using ServiceContracts;

namespace Services
{
  public class CitiesService : ICitiesService
  {
    private List<string> _cities;

    public CitiesService()
    {
      _cities = new List<string>() { 
        "Hubli",
        "Dharwad",
        "New Delhi",
        "Mumbai",
        "Pune"
      };
    }

    public List<string> GetCities()
    {
      return _cities;
    }
  }
}
