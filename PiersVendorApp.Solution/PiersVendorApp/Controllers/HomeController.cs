using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PiersVendorApp.Models;

namespace PiersVendorApp.Controllers
{
    public class VendorAccountController : Controller
    {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<VendorAccount> allVendors = VendorAccount.GetAll();
      return View();
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

    // --Code below need to be refactored to work with OrdersController--
    // [HttpGet("/categories/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   VendorAccount selectedVendor = VendorAccount.Find(id);
    //   List<OrderRequest> vendorOrder = selectedVendor.Orders;
    //   model.Add("testvendor", selectedVendor);
    //   model.Add("testorder", vendorOrder);
    //   return View(model);
    // }

    }
}
