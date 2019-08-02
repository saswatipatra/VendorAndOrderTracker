using System.Collections.Generic;

namespace Customer.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string Date{ get; set; }
    public int Price{get; set;}
    public bool Deliver{get; set;}
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description, int price, string date, bool deliver)
    {
      Description = description;
      Date= date;
      Price= price;
      Deliver= deliver;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}
