using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactDetails
/// </summary>
public class ContactDetails
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phone;
    private string _preferredMethod;

    public static ContactDetails GetContactDetails()
    {
        var cart = HttpContext.Current.Session["Contact"] as ContactDetails;
        if (cart == null)
            HttpContext.Current.Session["Contact"] = new ContactDetails();
        return (ContactDetails) HttpContext.Current.Session["Contact"];
    }

    public string FirstName
    {
        get { return this._firstName; }
        set
        {
            Trace.Assert(value != null, "Invalid First Name");
            this._firstName = value;
        }
    }

    public string LastName
    {
        get { return this._lastName; }
        set
        {
            Trace.Assert(value != null, "Invalid Last Name");
            this._lastName = value;
        }
    }

    public string Email
    {
        get { return this._email; }
        set
        {
            Trace.Assert(value != null, "Invalid Email");
            this._email = value;
        }
    }

    public string Phone
    {
        get { return this._phone; }
        set
        {
            Trace.Assert(value != null, "Invalid Phone Number");
            this._phone = value;
        }
    }

    public string PreferredMethod
    {
        get { return this._preferredMethod; }
        set
        {
            Trace.Assert(value != null, "Invalid Preferred Method");
            this._preferredMethod = value;
        }        
    }

}