using System.Collections.Generic;

namespace Pierre.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    // public List<Order> Orders { get; set; } //Will add when Order class is created

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      // Orders = new List<Order>{}; //Will add when Order class is created
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}