﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string fname = Request.QueryString["fname"];
        string lname = Request.QueryString["lname"];
        string date = Request.QueryString["date"];
        string email = Request.QueryString["email"];
        string gender = Request.QueryString["gender"];

        Label1.Text = fname;
        Label2.Text = lname;
        Label3.Text = date;
        Label4.Text = email;
        Label5.Text = gender;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}