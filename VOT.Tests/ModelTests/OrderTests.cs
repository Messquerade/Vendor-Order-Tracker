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

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Assert.AreEqual("Order 1", newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Assert.AreEqual("20 loaves of bread, 50 pastries", newOrder.Description);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Double()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Assert.AreEqual(154.00, newOrder.Price);
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Assert.AreEqual("2021-09-25", newOrder.Date);
    }

    [TestMethod]
    public void GetId_ReturnId_Integer()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Assert.AreEqual(1, newOrder.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrdersList()
    {
      Order newOrder = new Order("Order 1", "20 loaves of bread, 50 pastries", 154.00, "2021-09-25");
      Order anotherOrder = new Order("Order 2", "30 loaves of bread, 30 pastries", 150.00, "2021-10-01");
      List<Order> allOrders = new List<Order> {newOrder, anotherOrder};
      CollectionAssert.AreEqual(allOrders, Order.GetAll());
    }
  
  }
}