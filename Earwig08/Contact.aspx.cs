using System;

/// <summary>
/// This is the code-behind file for the Contact page
/// </summary>
/// <author>
/// Replace this text with your first and last name
/// </author>
/// <version>
/// Replace this text with today's date
/// </version>
public partial class Request : System.Web.UI.Page
{

    private ContactDetails _contactDetails;

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;


        if (Session["ContactDetails"] != null)
        {
            this._contactDetails = (ContactDetails) Session["ContactDetails"];
            this.DisplayReservation();
        }
        else if (Request.Cookies["FirstName"] != null && Request.Cookies["LastName"] != null)
        {
            this.txtFirstName.Text = Request.Cookies["FirstName"].Value;
            this.txtLastName.Text = Request.Cookies["LastName"].Value;
        }
    }

    /// <summary>
    /// Displays the reservation.
    /// </summary>
    private void DisplayReservation()
    {

        this.txtFirstName.Text = this._contactDetails.FirstName;
        this.txtLastName.Text = this._contactDetails.LastName;
        this.txtEmail.Text = this._contactDetails.Email;
        this.txtPhone.Text = this._contactDetails.Phone;
        this.ddlPreferredMethod.Text = this._contactDetails.PreferredMethod;
    }

    /// <summary>
    /// Handles the Click event of the btnClear control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtFirstName.Text = "";
        this.txtLastName.Text = "";
        this.txtEmail.Text = "";
        this.txtPhone.Text = "";
        this.ddlPreferredMethod.SelectedIndex = 0;
        this.lblMessage.Text = "";
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }

        var newDetails = new ContactDetails()
        {
            FirstName = this.txtFirstName.Text,
            LastName = this.txtLastName.Text,
            Phone = this.txtPhone.Text,
            Email = this.txtEmail.Text,
            PreferredMethod = this.ddlPreferredMethod.SelectedValue,
        };
        Session["ContactDetails"] = newDetails;

        var count = 0;
        if(Session["count"] == null)
        {
            count = Convert.ToInt32(Session["Count"]);
        }
        count++;
        Session["count"] = count;

        Response.Redirect("Confirm.aspx");

        count = Convert.ToInt32(Session["count"]);
        this.lblMessage.Text = "It took you " + count + " clicks on Submit<br/> Thank you for your" +
                               "request.<br/>We will get back to you within 24 hours.";
    }
}