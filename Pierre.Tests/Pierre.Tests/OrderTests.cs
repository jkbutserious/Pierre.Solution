using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Croissants", "Test Order", 200, "2020-07-24");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Croissants";
      string description = "Test Order";
      int price = 200;
      string date = "2020-07-24";
      Order newOrder = new Order(title, description, price, date);

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }
  }
}