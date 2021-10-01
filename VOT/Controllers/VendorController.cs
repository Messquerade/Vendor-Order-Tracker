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

    [HttpPost("/vendor")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return Redirect("/");
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}