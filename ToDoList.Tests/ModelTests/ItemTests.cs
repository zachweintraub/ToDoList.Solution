using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("Test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.GetDescription();
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      int result = newItem.GetId();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);

      //Act
      Item result = Item.Find(2);

      //Assert
      Assert.AreEqual(newItem2, result);
    }
  }
}
