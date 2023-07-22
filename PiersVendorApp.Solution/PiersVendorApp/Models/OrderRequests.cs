using System.Collections.Generic;

namespace PiersVendorApp.Models
{
  public class OrderRequest
  {
    public string OrderItem  { get; set; }
    public int Id { get; }
    private static List<OrderRequest> _orderInstances = new List<OrderRequest> { };

    public OrderRequest(string orderItem)
    {
      OrderItem = orderItem ;
      _orderInstances.Add(this);
      Id = _orderInstances.Count;
      
    }

    
    public static List<OrderRequest> GetAll()
    {
      return _orderInstances;
    }

    public static void ClearAll()
    {
      _orderInstances.Clear();
    }
    public static OrderRequest Find(int searchId)
    {
      return _orderInstances[searchId-1];
    }

  }
}