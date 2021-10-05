using Microsoft.AspNetCore.Mvc;
using VOT.Models;
using System;
using System.Collections.Generic;

namespace VOT.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/order/")]
    public ActionResult Index(int vendorId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      return View(currentVendor);
    }

    [HttpGet("/vendor/{Id}/order/new")]
    public ActionResult New(int Id)
    {
      Vendor currentVendor = Vendor.Find(Id);
      return View(currentVendor);
    }

    [HttpGet("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>
      {
        {"vendor", vendor},
        {"order", order}
      };
      return View(model);
    }
   
  }
}