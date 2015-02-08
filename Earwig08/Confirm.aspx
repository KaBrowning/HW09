<%@ Page Language="C#" MasterPageFile = "~/Earwig.master" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="Confirm" %>

    <asp:Content ID="headContent" ContentPlaceHolderID="headerPlaceHolder" runat="server">
        <link href="Styles/Main.css" rel="stylesheet" />
        <link href="Styles/Confirm.css" rel="stylesheet" />
        </asp:Content>

    <asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
            <h1>Request Confirmation</h1>
            <h2>Please confirm your reservation request</h2>
            <label>First name</label>
            <asp:Label ID="lblFirstName" runat="server" CssClass="entry"></asp:Label><br />
            <label>Last name</label>
            <asp:Label ID="lblLastName" runat="server" CssClass="entry"></asp:Label><br />
            <label>Email</label>
            <asp:Label ID="lblEmail" runat="server" CssClass="entry"></asp:Label><br />
            <label>Phone</label>
            <asp:Label ID="lblPhone" runat="server"></asp:Label><br />
            <label>Preferred method</label>
            <asp:Label ID="lblPreferredMethod" runat="server"></asp:Label><br />
            <br />
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" CssClass="button" OnClick="btnConfirm_Click" />
            <asp:Button ID="btnModify" runat="server" Text="Modify" CssClass="button" PostBackUrl="~/Contact.aspx" /><br />
            <p id="message">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
      </asp:Content>
