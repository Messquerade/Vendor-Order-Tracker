using Microsoft.AspNetCore.Mvc;
using VOT.Models;
using System;
using System.Collections.Generic;

namespace VOT.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{Id}/order/")]
    public ActionResult Index(int Id)
    {
      Vendor currentVendor = Vendor.Find(Id);
      // Dictionary<string, List<Order>> model = new Dictionary<Vendor, List<Order>> {{currentVendor.Name, currentVendor.Orders}}
      return View(currentVendor);
    }

    [HttpGet("/vendor/{Id}/order/new")]
    public ActionResult New(int Id)
    {
      Vendor currentVendor = Vendor.Find(Id);
      return View(currentVendor);
    }


  }
}