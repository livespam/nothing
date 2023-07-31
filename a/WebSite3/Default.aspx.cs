using System;
using System.Collections;
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
        ListBox1.Items.Add(Text1.Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ArrayList list = new ArrayList();
        foreach (var item in ListBox1.Items)
        {
            list.Add(item);
        }
        Session["list"] = list;
        Response.Redirect("~/DisplayBox.aspx");
    }
}