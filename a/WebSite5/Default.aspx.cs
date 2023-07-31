using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string fname = Request.Form["fname"];
        string lname = Request.Form["lname"];
        string date = Request.Form["date"];
        string email = Request.Form["email"];
        string gender = Request.Form["gender"];

        Response.Redirect("Registration.aspx?fname=" + fname + "&lname=" + lname + "&date=" + date + "&email=" + email + "&gender=" + gender);
    }
}