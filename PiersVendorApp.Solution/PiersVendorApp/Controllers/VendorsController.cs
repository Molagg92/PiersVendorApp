using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PiersVendorApp.Models;

namespace PiersVendorApp.Controllers
{
    public class VendorAccountsController : Controller
    {



    [HttpGet("/vendors")]
    public ActionResult Index()
    {
        List<VendorAccount> allVendors = VendorAccount.GetAll();
        return View(allVendors);
    }

   [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      VendorAccount newAccount = new VendorAccount(vendorName);
      return RedirectToAction("Index");
    }

  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    VendorAccount selectedVendor = VendorAccount.Find(id);
    List<OrderRequest> vendorOrders = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("orders", vendorOrders);
    return View(model);
  }

  [HttpPost("/vendors/{vendorId}/orders")]
  public ActionResult Create(int vendorId, string orderDescription)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    VendorAccount foundVendorAccount = VendorAccount.Find(vendorId);
    OrderRequest newOrder = new OrderRequest(orderDescription);
    foundVendorAccount.AddOrder(newOrder);
    List<OrderRequest> vendorOrders = foundVendorAccount.Orders;
    model.Add("orders", vendorOrders);
    model.Add("vendor", foundVendorAccount);
    return View("Show", model);
  }

  }
}