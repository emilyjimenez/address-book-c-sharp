using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Name
  {
    private static List<Name> _instances = new List<Name> {};
    private string _name;
    private int _id;
    private List<Address> _addresses;

    public Name (string contactName)
    {
      _name = contactName;
      _instances.Add(this);
      _id = _instances.Count;
      _addresses = new List<Address> {};
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

    public List<Address> GetAddresses()
    {
      return _addresses;
    }

    public void AddAddress(Address address)
    {
      _addresses.Add(address);
    }
  }
}
