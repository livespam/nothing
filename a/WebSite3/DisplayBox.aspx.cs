using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DisplayBox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["list"] != null)
            {
                ArrayList l = new ArrayList();
                l = (ArrayList)Session["list"];
                for (int i = 0; i < l.Count; i++)
                {
                    CheckBoxList1.Items.Add(l[i].ToString());
                }
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        ArrayList chk = new ArrayList();
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if (item.Selected)
            {
                chk.Add(item.Text);
            }
        }
        Session["hobby"] = chk;
        Response.Redirect("hobby.aspx");
    }
}