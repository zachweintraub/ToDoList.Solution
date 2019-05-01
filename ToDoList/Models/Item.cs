using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
      private string _description;
      private static List<Item> _instances = new List<Item>{};
      private int _id;

      public Item (string description)
      {
          _description = description;
          _instances.Add(this);
          _id = _instances.Count;
      }
      public string GetDescription()
      {
          return _description;
      }
      public static List<Item> GetAll()
      {
          return _instances;
      }
      public static void ClearAll()
      {
          _instances.Clear();
      }

      public static Item Find(int id)
      {
        return _instances[id-1];
      }

      public void SetDescription(string newDescription)
      {
        _description = newDescription;
      }

      public int GetId()
      {
        return _id;
      }
  }
}
