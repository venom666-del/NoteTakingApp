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
            if (Session["userID"] == null)
            {
                Response.Redirect("wfLogin.aspx");
            }
            if (!IsPostBack)
            {
                Populate();
            }
        }
        public void Populate()
        {
            string selectQuery = "select topic, description, date from tNotes where userID='" + Session["userID"].ToString() + "' order by date desc";
            DataTable notes = MyAdoHelper.ExecuteDataTable("NoteTaking.mdf", selectQuery);

            foreach(DataRow row in notes.Rows)
            {
                publicNotes += "<div class=\"singleNoteWrapper\">";
                publicNotes += "<div class=\"noteTopic\">";
                publicNotes += row["topic"];
                publicNotes += "<div class=\"noteDescription\">";
                publicNotes += row["description"];
                publicNotes += "</div>";
                publicNotes += "<div class=\"noteDate\">";
                publicNotes += row["date"];
                publicNotes += "</div>";
                publicNotes += "</div>";
                publicNotes += "</div>";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string note = tbxNoteValue.Text;
            DateTime now = DateTime.Now;
            
            string insertNonQuery = "insert into tNotes(topic, description, date, userID) values(N'"+note+"', '"+ tbxNoteDescription.Text+ "', '"+ now.ToString("g") + "', '"+Session["userID"]+"')";
            int rows = MyAdoHelper.RowsAffected("NoteTaking", insertNonQuery);

            tbxNoteValue.Text = "";
            tbxNoteDescription.Text = "";
            Populate();
        }
    }
}