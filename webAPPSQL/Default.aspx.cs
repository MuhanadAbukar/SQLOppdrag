using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace webAPPSQL
{
    public partial class Default : System.Web.UI.Page
    {

        static string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        static SqlConnection conn = new SqlConnection(connstr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                GridView1.DataSource = getAllPeople();
                GridView1.DataBind();
            }
        }
        public DataTable getAllPeople()
        {
            var d = new DataTable();
            conn.Open();
            var cmd = new SqlCommand("select * from person",conn);
            var reader = cmd.ExecuteReader();
            d.Load(reader);
            conn.Close();
            return d;
        }
        public void edit(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Response.Redirect($"Edit.aspx?pnr={btn.CommandName}");
        }
        public void delete(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var cmd = new SqlCommand($"delete from person where id={btn.CommandName}",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect(Request.RawUrl);
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length == 0)
            {
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    var rows = GridView1.Rows;
                    rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    var rows = GridView1.Rows;
                    if (!rows[i].Cells[1].Text.ToLower().Contains(TextBox1.Text.ToLower()))
                    {
                        rows[i].Visible = false;
                    }
                }
            }
              
        }
       

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = getAllPeople();
            GridView1.DataBind();
        }
    }
}