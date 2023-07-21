using System.Collections.Generic;

namespace PiersVendorApp.Models
{
  public class VendorAccount
  {
    public string AccountName { get; set; }
    private static List<VendorAccount> _orderInstances = new List<VendorAccount> {};
    public int Id { get; }
    
    public VendorAccount(string accountName)
    {
      AccountName = accountName;
      _orderInstances.Add(this);
      Id = _orderInstances.Count;
    }

     public static void ClearAll()
  {
    _orderInstances.Clear();
  }
  }
}