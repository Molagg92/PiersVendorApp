using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PiersVendorApp.Models;

namespace PiersVendorApp.Controllers
{
    public class HomeController : Controller
    {

    [HttpGet("/")]
    public ActionResult Index()
    {
     
      return View();
    }



    //---- Dont know what I did to the code below, but stopped working.
    //--- I need to Back up, and amake sure things work from Teh beginning.
   




    //   [HttpPost("/vendors")]
    // public ActionResult Create(string accountName)
    // {
    //   VendorAccount newVendor = new VendorAccount("Vender number 1");
    //   List<VendorAccount> allVendors = VendorAccount.GetAll();
    //   return RedirectToAction("index", allVendors);
    // }







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
