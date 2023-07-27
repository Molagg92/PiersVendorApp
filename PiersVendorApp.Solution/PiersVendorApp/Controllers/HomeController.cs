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
  }
}
