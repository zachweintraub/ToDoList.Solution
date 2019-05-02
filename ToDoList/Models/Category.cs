
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Item> _items;

    public Category(string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _items = new List<Item>{};
    }

    public void AddItem(Item item)
    {
      _items.Add(item);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Category> GetAll()
    {
      return _instances;
    }

    public List<Item> GetItems()
    {
      return _items;
    }

    public static Category Find(int id)
    {
      return _instances[id-1];
    }
  }
}
