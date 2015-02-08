using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactDetails
/// </summary>
public class ContactDetails
{
    public static ContactDetails GetContactDetails()
    {
        var cart = HttpContext.Current.Session["Contact"] as ContactDetails;
        if (cart == null)
            HttpContext.Current.Session["Contact"] = new ContactDetails();
        return (ContactDetails)HttpContext.Current.Session["Contact"];
    }

}