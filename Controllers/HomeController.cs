using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/names")]
    public ActionResult Names()
    {
      List<Name> allNames = Name.GetAll();
      return View(allNames);
    }

    [HttpGet("/artists/new")]
    public ActionResult NameForm()
    {
      return View();
    }

    [HttpPost("/names")]
    public ActionResult AddName()
    {
      Name newName = new Name(Request.Form["contact-name"]);
      List<Name> allNames = Name.GetAll();
      return View("Names", allNames);
    }

    [HttpGet("/names/{id}")]
    public ActionResult NameDetail(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Name selectedName = Name.Find(id);
      List<Address> nameAddresses = selectedName.GetNames();
      model.Add("name", selectedName);
      model.Add("addresses", nameAddresses);
      return View(model);
    }

    [HttpGet("/names/{id}/addresses/new")]
    public ActionResult NameAddressForm(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Name selectedName = Name.Find(id);
      List<Address> nameAddresses = selectedName.GetNames();
      model.Add("name", selectedName);
      model.Add("addresses", nameAddresses);
      return View(model);
    }

    [HttpPost("/cds")]
    public ActionResult AddAddress()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Name selectedName = Name.Find(Int32.Parse(Request.Form["name-id"]));
      List<Address> nameAddresses = selectedName.GetNames();
      string addressStreet = Request.Form["address-street"];
      string addressCityState = Request.Form["address-city-state"];
      string addressZip = Request.Form["address-zip"];
      Address newAddress = new Address(addressStreet, addressCityState, addressZip);
      nameAddresses.Add(newAddress);
      model.Add("name", selectedName);
      model.Add("addresses", nameAddresses);
      return View("NameDetail", model);
    }

    [HttpGet("/addresses/{id}")]
    public ActionResult NameDetail(int id)
    {
      Address address = Address.Find(id);
      return View(address);
    }
  }
}
