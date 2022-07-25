using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("description", "string price", "string date", "string title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";

      //Act
      Order newOrder = new Order(description, price, date, title);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";

      //Act
      Order newOrder = new Order(description, price, date, title);
      string result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";

      //Act
      Order newOrder = new Order(description, price, date, title);
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }  

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";

      //Act
      Order newOrder = new Order(description, price, date, title);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    } 

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";
      Order newOrder = new Order(description, price, date, title);

      //Act
      string updatedDescription = "Update this description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_OrderList()
    // {
    //   // Arrange
    //   List<Order> newList = new List<Order> { };

    //   // Act
    //   List<Order> result = Order.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsOrders_OrderList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Order newOrder1 = new Order(description01);
    //   Order newOrder2 = new Order(description02);
    //   List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //   //Act
    //   List<Order> result = Order.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}