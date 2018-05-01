using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookDetails
/// </summary>
public class BookDetails
{
    private String title;
    private String author;
    private String description;
    private double price;
    private String fullImageAddress;
    public BookDetails(String t, String a, String d, double p, String fIA)
    {
        title = t;
        author = a;
        description = d;
        price = p;
        fullImageAddress = fIA;
    }

    public String getTitle()
    {
        return title;
    }

    public String getAuthor()
    {
        return author;
    }

    public String getDescription()
    {
        return description;
    }

    public double getPrice()
    {
        return price;
    }
    public String getFullAddress()
    {
        return fullImageAddress;
    }
}