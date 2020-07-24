using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;

namespace Pierre.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order newOrder = new Order(title, description, price, date);
      return RedirectToAction("/vendors/{id}");
    }
  }
}