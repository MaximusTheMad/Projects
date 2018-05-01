using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Address
{
    private String street;
    private String city;
    private String state;
    private String ZIP;
    public Address(String st, String ct, String sta, String zip)
    {
        street = st;
        city = ct;
        state = sta;
        ZIP = zip;
    }

    public String getStreet()
    {
        return street;
    }
    public String getCity()
    {
        return city;
    }
    public String getState()
    {
        return state;
    }
    public String getZIP()
    {
        return ZIP;
    }

}