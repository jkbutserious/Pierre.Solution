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

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string title = "Croissants";
      string description = "Test Order";
      int price = 200;
      string date = "2020-07-24";
      Order newOrder = new Order(title, description, price, date);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      string title = "Croissants";
      string description = "Test Order";
      int price = 200;
      string date = "2020-07-24";
      Order newOrder = new Order(title, description, price, date);

      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string title = "Croissants";
      string description = "Test Order";
      int price = 200;
      string date = "2020-07-24";
      Order newOrder = new Order(title, description, price, date);

      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      string title01 = "Croissants";
      string title02 = "Baguettes";
      string description01 = "Test Order 1";
      string description02 = "Test Order 2";
      int price01 = 200;
      int price02 = 180;
      string date01 = "2020-07-24";
      string date02 = "2020-07-23";

      Order newOrder01 = new Order(title01, description01, price01, date01);
      Order newOrder02 = new Order(title02, description02, price02, date02);
      List<Order> orderList = new List<Order> {newOrder01, newOrder02};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(orderList, result);
    }
  }
}