using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddressBook
/// </summary>
public class AddressBook
{
    public List<Address> addresses;
    public AddressBook(List<Address> ads)
    {
        addresses = ads;
    }
    public AddressBook()
    {
        addresses = new List<Address>();
    }
    public List<Address> getAddresses()
    {
        addresses = new List<Address>();
        addresses.Add(new Address("1340 Baymax Street", "Alman", "WA", "99520"));
        addresses.Add(new Address("2034 Amans Street", "Alman", "WA", "99520"));
        addresses.Add(new Address("1843 Lamae Avenue", "Alman", "WA", "99520"));
        addresses.Add(new Address("1283 Nanama Place", "Alman", "WA", "99520"));
        return addresses;
    }
}