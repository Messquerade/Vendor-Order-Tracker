using Microsoft.AspNetCore.Mvc;
using VOT.Models;
using System;
using System.Collections.Generic;

namespace VOT.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{Id}/order")]
    public ActionResult Index(int vendorId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = currentVendor.Orders;
      return View(vendorOrders);
    }
  }
}