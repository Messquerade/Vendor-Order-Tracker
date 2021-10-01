using Microsoft.AspNetCore.Mvc;
using VOT.Models;
using System;
using System.Collections.Generic;

namespace VOT.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> currentVendors = Vendor.GetAll();
      return View(currentVendors);
    }
  }
}