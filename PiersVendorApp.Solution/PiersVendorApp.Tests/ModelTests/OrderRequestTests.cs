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
    string result = test.OrderItem;

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
  [TestMethod]
  public void Find_ReturnsCorrectOrderRequest_OrderRequest()
  {
      //Arrange
    string orderTest = "30 loafs of Bread";
    string orderTest2 = "20 Pastries";
    OrderRequest breadOrder = new OrderRequest(orderTest);
    OrderRequest pastryOrder = new OrderRequest(orderTest2);

    //Act
    OrderRequest result = OrderRequest.Find(2);

    //Assert
    Assert.AreEqual(pastryOrder, result);
  }

}