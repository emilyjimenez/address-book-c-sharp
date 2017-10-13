using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Name
  {
    private static List<Name> _instances = new List<Name> {};
    private string _name;
    private int _id;
    private List<Name> _names;

    public Name (string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _names = new List<Name> {};
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Name> GetAll()
    {
      return _instances;
    }

    public static Name Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<Name> GetNames()
    {
      return _names;
    }

    public void AddName(Name name)
    {
      _names.Add(name);
    }
  }
}
