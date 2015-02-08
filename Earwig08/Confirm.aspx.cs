using System;
using System.Web;

/// <summary>
/// This is the code-behind file for the Confirmation page
/// </summary>
/// <author>
/// Replace this text with your first and last name
/// </author>
/// <version>
/// Replace this text with today's date
/// </version>
public partial class Confirm : System.Web.UI.Page
{
    private ContactDetails _contactDetails;

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ContactDetails"] != null)
        {
            this._contactDetails = (ContactDetails) Session["ContactDetails"];
            this.DisplayReservation();
        }
    }

    /// <summary>
    /// Displays the reservation.
    /// </summary>
    private void DisplayReservation()
    {
        this.lblFirstName.Text = this._contactDetails.FirstName;
        this.lblLastName.Text = this._contactDetails.LastName;
        this.lblEmail.Text = this._contactDetails.Email;
        this.lblPhone.Text = this._contactDetails.Phone;
        this.lblPreferredMethod.Text = this._contactDetails.PreferredMethod;
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        HttpCookie firstNameCookie = new HttpCookie("FirstName", this.lblFirstName.Text);
        firstNameCookie.Expires = DateTime.Now.AddMinutes(10);

        Response.Cookies.Add(firstNameCookie);

        HttpCookie lastNameCookie = new HttpCookie("LastName", this.lblLastName.Text);
        lastNameCookie.Expires = DateTime.Now.AddMinutes(10);

        Response.Cookies.Add(lastNameCookie);
    }
}