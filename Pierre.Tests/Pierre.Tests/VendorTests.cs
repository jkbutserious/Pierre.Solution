using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      string description = "Test Vendor";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;
      
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Suzie's Cafe";
      string description = "Test Vendor";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Suzie's Cafe";
      string description = "Test Vendor";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name01 = "Suzie's Cafe";
      string name02 = "Joey's Diner";
      string description01 = "Test Vendor 1";
      string description02 = "Test Vendor 2";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      List<Vendor> vendorList = new List<Vendor> {newVendor01, newVendor02};

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(vendorList, result);
    }
  }
}