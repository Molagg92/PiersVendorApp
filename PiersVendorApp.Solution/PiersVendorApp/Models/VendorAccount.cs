using System.Collections.Generic;

namespace PiersVendorApp.Models
{
  public class VendorAccount
  {
    public string AccountName { get; set; }
    private static List<VendorAccount> _instances = new List<VendorAccount> {};
    public int Id { get; }
    public List<OrderRequest> Order { get; set; }
    
    public VendorAccount(string accountName)
    {
      AccountName = accountName;
      _instances.Add(this);
      Id = _instances.Count;
      Order = new List<OrderRequest>{};
    }

     public static void ClearAll()
  {
    _instances.Clear();
  }
  }
}