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
    model.Add("order", vendorOrders);
    return View(model);
  }

  }
}