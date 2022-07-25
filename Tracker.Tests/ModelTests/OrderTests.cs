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

    [TestMethod]
    public void SetPrice_SetPrice_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";
      Order newOrder = new Order(description, price, date, title);

      //Act
      string updatedPrice = "Update this price";
      newOrder.Price = updatedPrice;
      string result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";
      Order newOrder = new Order(description, price, date, title);

      //Act
      string updatedDate = "Update this date";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string description = "test description";
      string price = "test price";
      string date = "test date";
      string title = "test title";
      Order newOrder = new Order(description, price, date, title);

      //Act
      string updatedTitle = "Update this title";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description1 = "test description 1";
      string price1 = "test price 1";
      string date1 = "test date 1";
      string title1 = "test title 1";
      Order newOrder1 = new Order(description1, price1, date1, title1);
      string description2 = "test description 2";
      string price2 = "test price 2";
      string date2 = "test date 2";
      string title2 = "test title 2";
      Order newOrder2 = new Order(description2, price2, date2, title2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}