﻿using System;
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
        if (Session["ContactDetails"] == null)
        {
            return;
        }
        this._contactDetails = (ContactDetails) Session["ContactDetails"];
        this.DisplayReservation();

        var count = Convert.ToInt32(Session["count"]);
        this.lblMessage.Text = "It took you " + count + " clicks on Submit<br/> Thank you for your" +
                               " request.<br/>We will get back to you within 24 hours.";
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

    /// <summary>
    /// Handles the Click event of the btnConfirm control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        var firstNameCookie = new HttpCookie("FirstName", this.lblFirstName.Text);
        firstNameCookie.Expires = DateTime.Now.AddMinutes(10);

        Response.Cookies.Add(firstNameCookie);

        var lastNameCookie = new HttpCookie("LastName", this.lblLastName.Text);
        lastNameCookie.Expires = DateTime.Now.AddMinutes(10);

        Response.Cookies.Add(lastNameCookie);
    }
}