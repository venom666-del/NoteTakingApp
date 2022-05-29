using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NoteTakingApp
{
    public partial class wfRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void accept_Click(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT userID, name, auth FROM tUsers WHERE emailAddress='" + tbxEmailAdress.Text + "' or password='" + tbxPassword.Text + "'";
                DataTable user = MyAdoHelper.ExecuteDataTable("SAF.mdf", selectQuery);
                int rows = user.Rows.Count;
                if (rows == 1)
                {
                    lblResult.Text = "a user with this account has already registered!";
                    return;
                }
                if(rows == 0)
                {
                    string insertNonQuery = "INSERT INTO tUsers(name, emailAddress, password, auth) values('"+tbxUserNAme.Text+"', '"+tbxEmailAdress+"', '"+tbxPassword.Text+"', 1) ";
                    int result = MyAdoHelper.RowsAffected("NoteTaking.aspx", insertNonQuery);
                    if(result == 1)
                    {
                        Response.Redirect("wfSuccess.aspx");
                    }
                    if(result > 1)
                    {
                        lblResult.Text = "an unexpected problem has occurred, please speak to the manager.";
                    }
                    if(result == 0)
                    {
                        lblResult.Text = "user isn't registered.";
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