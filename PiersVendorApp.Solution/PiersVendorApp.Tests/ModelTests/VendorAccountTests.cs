using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiersVendorApp.Models;
using System.Collections.Generic;
using System;

namespace PiersVendorApp.Tests;

[TestClass]
public class VendorAccountTests : IDisposable
{
   public void Dispose()
    {
      VendorAccount.ClearAll();
    }
  [TestMethod]
  public void VendorAccountContructor_ReturnsInstanceOfVendorAccount_VendorAccount()
  {
      // Arrange
      string testOrderItem = "Test01";
      VendorAccount test = new VendorAccount(testOrderItem);

      // Act
      string result = test.AccountName;

      // Assert
      Assert.AreEqual(testOrderItem, result);
  }
  [TestMethod]
  public void GetID_ReturnsVendorAccountId_Int()
  {

    //Arrange
    string testOrderItem = "Test01";
    VendorAccount TestOrder = new VendorAccount(testOrderItem);

    //Act
    int result = TestOrder.Id;

    //Assert
    Assert.AreEqual(1, result);

  }
  [TestMethod]
  public void GetAll_ReturnAllVendorAccountObjects_VendorAccountList()
  {
    //Arrange
    string test01 = "Darth Vader";
    string test02 = "Scooby-Doo";
    VendorAccount newTestVender01 = new VendorAccount(test01);
    VendorAccount newTestVender02 = new VendorAccount(test02);
    List<VendorAccount> newList = new List<VendorAccount> { newTestVender01, newTestVender02};

    //Act
    List<VendorAccount> result = VendorAccount.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }
  
  [TestMethod]
  public void Find_ReturnsCorrectVendorAccount_VendorAccount()
  {
    //Arrange
    string test03 = "Ms.Piggy";
    string test04 = "Thor, Son of Odin.";
    VendorAccount newVendor03 = new VendorAccount(test03);
    VendorAccount newVendor04 = new VendorAccount(test04);

    //Act
    VendorAccount result = VendorAccount.Find(2);

    //Assert
    Assert.AreEqual(newVendor04, result);
  }

  // [TestMethod]
  // public void AddOrder_AssociatesOrderWithVerndor_OrderList()
  // {
  //   //Arrange
  //   string test05 = "30 Pastries";
  //   OrderRequest testOrder = new OrderRequest(test05);


  //   //Act

  //   //Assert

  // }

}