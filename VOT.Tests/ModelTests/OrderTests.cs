using Microsoft.VisualStudio.TestTools.UnitTesting;
using VOT.Models;
using System.Collections.Generic;
using System;

namespace VOT.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CheckTypeOrder_Order()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  
  }
}