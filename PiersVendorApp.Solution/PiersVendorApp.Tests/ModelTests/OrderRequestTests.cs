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
    VendorAccount.ClearAll();
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
    string testOrderItem = "Test01";
    OrderRequest TestOrder = new OrderRequest(testOrderItem);

    // Act
    int result = TestOrder.Id;

    // Assert
    Assert.AreEqual(1, result);

  }

}