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

    }
}
