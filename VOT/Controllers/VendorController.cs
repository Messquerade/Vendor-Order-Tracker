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

    [HttpPost("/vendor/{vendorId}/order/")]
    public ActionResult Create(int vendorId, string title, string description, double price, string date)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, date);
      currentVendor.AddOrder(newOrder);
      return RedirectToAction("Index");
    }
  }
}