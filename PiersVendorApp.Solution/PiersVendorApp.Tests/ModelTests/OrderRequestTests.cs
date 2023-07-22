using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiersVendorApp.Models;
using System.Collections.Generic;
using System;

namespace PiersVendorApp.Tests;

[TestClass]

public class OrderRequestTests
{
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

}