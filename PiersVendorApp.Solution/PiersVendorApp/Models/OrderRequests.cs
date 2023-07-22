using System.Collections.Generic;

namespace PiersVendorApp.Models
{
  public class OrderRequest
  {
    public string Order { get; set; }
    public int Id { get; }
    private static List<OrderRequest> _instances = new List<OrderRequest> { };

    public OrderRequest(string order)
    {
      Order = order;
      // _instances.Add(this);
      // Id = _instances.Count;
      
    }

  }
}