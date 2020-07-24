using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;

namespace Pierre.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    // [HttpPost("/vendors/{vendorId}/orders")]
    // public ActionResult Create(int vendorId, string title, string description, int price, string date)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Vendor foundVendor = Vendor.Find(vendorId);
    //   Order newOrder = new Order(title, description, price, date);
    //   foundVendor.AddOrder(newOrder);
    //   List<Order> vendorOrders = foundVendor.Orders;
    //   model.Add("orders", vendorOrders);
    //   model.Add("vendor", foundVendor);
    //   return RedirectToAction("Index");
    // }

    [HttpGet("/categories/{categoryId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}