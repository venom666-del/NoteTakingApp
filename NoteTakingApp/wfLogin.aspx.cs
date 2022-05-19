using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NoteTakingApp
{
    public partial class wfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void accept_Click(object sender, EventArgs e)
        { 
            try
            {
                string selectQuery = "SELECT userID, name, auth FROM tUsers WHERE emailAddress='" + tbxEmailAdress.Text + "' AND password='" + tbxPassword.Text + "'";
                DataTable user = MyAdoHelper.ExecuteDataTable("SAF.mdf", selectQuery);
                int rows = user.Rows.Count;
                if (rows == 1)
                {
                    Session["userID"] = user.Rows[0]["userID"].ToString();
                    if (user.Rows[0]["auth"].ToString() == "1")
                    {
                        Session["name"] = user.Rows[0]["name"].ToString();
                        Session["userAuth"] = true;
                        Response.Redirect("wfHomePage.aspx");
                    }
                    if (user.Rows[0]["auth"].ToString() == "2")
                    {
                        Session["name"] = user.Rows[0]["name"].ToString();
                        Session["adminAuth"] = true;
                        Response.Redirect("wfHomePage.aspx");
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}