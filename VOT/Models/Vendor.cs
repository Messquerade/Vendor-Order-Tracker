using System.Collections.Generic;

namespace VOT.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    private static List<Vendor> _instances = new List<Vendor> {};
    public int Id {get;}
    public List<Order> Orders {get; set;}


    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};

    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int id)
    {
      return _instances[id - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}