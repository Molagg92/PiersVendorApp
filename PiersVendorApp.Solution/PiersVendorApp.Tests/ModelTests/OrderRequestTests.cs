using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiersVendorApp.Models;
using System.Collections.Generic;
using System;

namespace PiersVendorApp.Tests;

[TestClass]
public class OrderRequestTests : IDisposable
{
  public void Dispose()
  {
    OrderRequest.ClearAll();
  }
  [TestMethod]
  public void OrderRequestConstructor_ReturnsInstanceOfOrderRequest_OrderRest()
  {
    // Arrange
    string testOrderItem = "Test01";
    OrderRequest test = new OrderRequest(testOrderItem);

    // Act
    string result = test.Order;

    // Assert
    Assert.AreEqual(testOrderItem, result);

  }
  [TestMethod]
  public void GetId_ReturnsIdOfOrderRequest_int()
  {
    // Arrange
    string testOrder = "Test01";
    OrderRequest Testr = new OrderRequest(testOrder);
    Console.WriteLine(Testr);
    // Act
    int result = Testr.Id;

    // Assert
    Assert.AreEqual(1, result);

  }

}