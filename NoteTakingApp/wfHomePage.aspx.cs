using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NoteTakingApp
{
    public partial class wfHomePage : System.Web.UI.Page
    {
        public string publicNotes;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Session["userAuth"] == null)
            //{
            //    Response.Redirect("wfLogin.aspx");
            //}
        }
        public void Populate()
        {
            string selectQuery = "select value, date from tNotes";
            DataTable notes = MyAdoHelper.ExecuteDataTable("NoteTaking.mdf", selectQuery);

            foreach(DataRow row in notes.Rows)
            {
                publicNotes += "<div>";
                publicNotes += row["value"];
                publicNotes += "<div>";
                publicNotes += row["date"];
                publicNotes += "</div>";
                publicNotes += "</div>";
            }
        }
    }
}