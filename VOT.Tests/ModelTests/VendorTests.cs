using Microsoft.VisualStudio.TestTools.UnitTesting;
using VOT.Models;
using System.Collections.Generic;
using System;

namespace VOT.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_TypeIsVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Larry's Cafe", "A small cafe with weekly orders.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Vendor newVendor = new Vendor("Larry's Cafe", "A small cafe with weekly orders.");
      Assert.AreEqual("Larry's Cafe", newVendor.Name);
    }

    [TestMethod]
    public void SetName_ReturnsUpdatedName_String()
    {
      Vendor newVendor = new Vendor("Larry's Cafe", "A small cafe with weekly orders.");
      newVendor.Name = "Greg and Larry's Cafe";
      Assert.AreEqual("Greg and Larry's Cafe", newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Vendor newVendor = new Vendor("Greg and Larry's Cafe", "A small cafe with weekly orders.");
      Assert.AreEqual("A small cafe with weekly orders.", newVendor.Description);
    }

    [TestMethod]
    public void SetDescription_ReturnsUpdatedDescription_String()
    {
      Vendor newVendor = new Vendor("Greg and Larry's Cafe", "A small cafe with weekly orders.");
      newVendor.Description = "A small LGBTQ+ friendly cafe with weekly orders.";
      Assert.AreEqual("A small LGBTQ+ friendly cafe with weekly orders.", newVendor.Description);
    }
    
    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor = new Vendor("Greg and Larry's Cafe", "A small cafe with weekly orders.");
      Vendor anotherVendor = new Vendor("Jurassic Fork", "A dino themed restaurant with biweekly orders.");
      List<Vendor> vendorList = new List<Vendor> {newVendor, anotherVendor};
      CollectionAssert.AreEqual(vendorList, Vendor.GetAll());
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor("Greg and Larry's Cafe", "A small cafe with weekly orders.");
      Vendor anotherVendor = new Vendor("Jurassic Fork", "A dino themed restaurant with biweekly orders.");
      Assert.AreEqual(2, anotherVendor.Id);
    }

    [TestMethod]
    public void Find_ReturnsSpecificVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Greg and Larry's Cafe", "A small cafe with weekly orders.");
      Vendor anotherVendor = new Vendor("Jurassic Fork", "A dino themed restaurant with biweekly orders.");
      Assert.AreEqual(anotherVendor, Vendor.Find(2));
    }

    [TestMethod]
    public void AddOrder_AddOrderToSpecificVendor_OrderList()
    {
      Vendor newVendor = new Vendor("Greg and Larry's Cafe", "A small cafe with weekly orders.");
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      List<Order> vendorOrders = new List<Order> {newOrder};
      newVendor.AddOrder(newOrder);
      CollectionAssert.AreEqual(vendorOrders, newVendor.Orders);
    }



  }
}