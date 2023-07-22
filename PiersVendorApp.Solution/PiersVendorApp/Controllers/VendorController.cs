using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PiersVendorApp.Models;

namespace PiersVendorApp.Controllers
{
    public class VendorAccountController : Controller
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
