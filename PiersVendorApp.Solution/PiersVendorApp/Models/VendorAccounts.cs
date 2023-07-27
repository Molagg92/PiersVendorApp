using System.Collections.Generic;

namespace PiersVendorApp.Models
{
  public class VendorAccount
  {
    public string AccountName { get; set; }
    private static List<VendorAccount> _vendorList = new List<VendorAccount> { };
    public int Id { get; }
    public List<OrderRequest> Orders { get; set; }
    public VendorAccount(string accountName)
    {
      AccountName = accountName;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<OrderRequest> { };
    }
     public static void ClearAll()
    {
      _vendorList.Clear();
    }
     public static List<VendorAccount> GetAll()
    {
      return _vendorList;
    }
    public static VendorAccount Find(int searchId)
    {
      return _vendorList[searchId - 1];
    }
     public void AddOrder(OrderRequest order)
    {
      Orders.Add(order);
    }
  }
}