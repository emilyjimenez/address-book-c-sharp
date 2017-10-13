using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Adrress
  {
    private string _street;
    private string _cityState;
    private string _zip;
    private int _id;
    private static List<Address> _instances = new List<Address> {};

    public Address (string street, string cityState, string zip, int id)
    {
      _street = street;
      _cityState = cityState;
      _zip = zip;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetStreet()
    {
      return _street;
    }

    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }

    public string GetCityState()
    {
      return _cityState;
    }

    public void SetCityState(string newcityState)
    {
      _cityState = newcityState;
    }

    public string GetZip()
    {
      return _zip;
    }

    public void SetZip(string newZip)
    {
      _zip = newZip;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Address> GetAll()
    {
      return _instances;
    }

    public static Address Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
