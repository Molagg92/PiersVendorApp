using Microsoft.VisualStudio.TestTools.UnitTesting;
using PiersVendorApp.Models;
using System.Collections.Generic;
using System;

namespace PiersVendorApp.Tests;

        [TestClass]
public class CategoryTests : IDisposable
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
  // [TestMethod]
  // public void GetAll_ReturnAllVendorAccountObjects_VendorAccountList()
  // {
  //   //Arrange
  //   string testName01 = "Learn C#";
  //   string testName02 = "Conquer The Earth";
  //   VendorAccount newTestOrder01 = new VendorAccount(testName01);
  //   VendorAccount newTestOrder02 = new VendorAccount(testName02);
    

  //   //Act

  //   //Assert

  //}
}