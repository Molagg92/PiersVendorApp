using Microsoft.AspNetCore.Mvc;
using PiersVendorApp.Models;
using System.Collections.Generic;

namespace PiersVendorApp.Controllers
{
  public class OrderRequestsController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      OrderRequest order = OrderRequest.Find(orderId);
      VendorAccount vendor = VendorAccount.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      VendorAccount vendor = VendorAccount.Find(vendorId);
      return View(vendor);
    }

  }
}