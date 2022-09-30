using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
namespace webAPPSQL
{
    public partial class Default : System.Web.UI.Page
    {
        static DBL dbl = new DBL();
        static SqlCommand cmd1 = new SqlCommand("select * from person", dbl.conn);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dbl.bindToGridView(dbl.getReader(cmd1), DataGridView);
            }
        }
        
        public void edit(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Response.Redirect($"Edit.aspx?pnr={btn.CommandName}");
        }
        public void delete(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var cmd = new SqlCommand($"delete from person where id={btn.CommandName}", dbl.conn);
            dbl.writeToDB(cmd);
            Response.Redirect(Request.RawUrl);

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(FornavnTextbox.Text.Length == 0 )
            {

                var cmd1 = new SqlCommand($"select * from person", dbl.conn);
                dbl.bindToGridView(dbl.getReader(cmd1), DataGridView);

            }
            else
            {

                var cmd = new SqlCommand($"select * from person where fornavn like '%{FornavnTextbox.Text}%'", dbl.conn);
                dbl.bindToGridView(dbl.getReader(cmd), DataGridView);
            }
        }


        protected void DataGridView_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            DataGridView.PageIndex = e.NewPageIndex; 
            dbl.bindToGridView(dbl.getReader(cmd1), DataGridView);

        }

        protected void IDSearch(object sender, EventArgs e)
        {
            if (IDTextbox.Text.Length == 0)
            {

                var cmd1 = new SqlCommand($"select * from person", dbl.conn);
                dbl.bindToGridView(dbl.getReader(cmd1), DataGridView);

            }
            else
            {

                var cmd = new SqlCommand($"select * from person where id = {IDTextbox.Text}", dbl.conn);
                dbl.bindToGridView(dbl.getReader(cmd), DataGridView);
            }
            
        }
    }
}