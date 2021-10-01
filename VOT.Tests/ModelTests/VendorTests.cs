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

  }
}