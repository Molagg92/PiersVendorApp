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

  }
}