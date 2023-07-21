using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiersVendorApp.Models;
using System.Collections.Generic;
using System;

namespace PiersVendorApp.Tests;

        [TestClass]
public class CategoryTests
{
  [TestMethod]
  public void OrderRequestContructor_ReturnsInstanceOfOrderRequest_OrderRequest()
  {
      // Arrange
      string testOrderItem = "Test01";
      OrderRequest testOrder = new OrderRequest(testOrderItem);

      // Act
      string result = testOrder.OrderItem;

      // Assert
      Assert.AreEqual(testOrderItem, result);
  }
  [TestMethod]
  public void GetID_ReturnsOrderRequestId_Int()
  {

    //Arrange
    string name = "Test Order";
    OrderRequest newTestOrder = new OrderRequest(name);

    //Act
    int result = newTestOrder.Id;

    //Assert
    Assert.AreEqual(1, result);

  }
}