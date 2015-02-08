
using System.Diagnostics;
using System.Web;

/// <summary>
/// Gets and sets the values of all of the contact information.
/// </summary>
/// <author>Kathryn Browning</author>
/// <version>February 8, 2015</version>
public class ContactDetails
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phone;
    private string _preferredMethod;

    /// <summary>
    /// Gets the contact details.
    /// </summary>
    /// <returns></returns>
    public static ContactDetails GetContactDetails()
    {
        var cart = HttpContext.Current.Session["Contact"] as ContactDetails;
        if (cart == null)
            HttpContext.Current.Session["Contact"] = new ContactDetails();
        return (ContactDetails) HttpContext.Current.Session["Contact"];
    }

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    /// <value>
    /// The first name.
    /// </value>
    public string FirstName
    {
        get { return this._firstName; }
        set
        {
            Trace.Assert(value != null, "Invalid First Name");
            this._firstName = value;
        }
    }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    /// <value>
    /// The last name.
    /// </value>
    public string LastName
    {
        get { return this._lastName; }
        set
        {
            Trace.Assert(value != null, "Invalid Last Name");
            this._lastName = value;
        }
    }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    public string Email
    {
        get { return this._email; }
        set
        {
            Trace.Assert(value != null, "Invalid Email");
            this._email = value;
        }
    }

    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    /// <value>
    /// The phone.
    /// </value>
    public string Phone
    {
        get { return this._phone; }
        set
        {
            Trace.Assert(value != null, "Invalid Phone Number");
            this._phone = value;
        }
    }

    /// <summary>
    /// Gets or sets the preferred method.
    /// </summary>
    /// <value>
    /// The preferred method.
    /// </value>
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