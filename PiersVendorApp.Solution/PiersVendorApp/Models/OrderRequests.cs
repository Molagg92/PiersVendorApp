using System.Collections.Generic;

namespace PiersVendorApp.Models
{
  public class OrderRequest
  {
    public string Order { get; set; }

    public OrderRequest(string order)
    {
      // Order = order;
    }

  }
}