using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
namespace webAPPSQL
{
    public partial class Edit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dbl = new DBL();
                var id = Request.QueryString["pnr"];
                var cmd = new SqlCommand($"select * From person where id=@id", dbl.conn);
                dbl.createParam("@id", id, cmd);
                var reader = dbl.getReader(cmd);
                dbl.bindToGridView(reader, GridView1);
                if(GridView1.Rows.Count == 0)
                {
                    Response.Redirect("Default.aspx");
                    return;
                }
                Fornavn.Text = GridView1.Rows[0].Cells[1].Text;
                Etternavn.Text = GridView1.Rows[0].Cells[2].Text;
                Adresse.Text = GridView1.Rows[0].Cells[3].Text;
                Postnummer.Text = GridView1.Rows[0].Cells[4].Text;
                Poststed.Text = GridView1.Rows[0].Cells[5].Text;
                Alder.Text = GridView1.Rows[0].Cells[6].Text;
                Inntekt.Text = GridView1.Rows[0].Cells[7].Text;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var dbl = new DBL();
            var cmd = new SqlCommand();
            dbl.createParam("@fornavn", Fornavn.Text,cmd);
            dbl.createParam("@etternavn", Etternavn.Text, cmd);
            dbl.createParam("@adresse", Adresse.Text, cmd);
            dbl.createParam("@postnummer", Postnummer.Text, cmd);
            dbl.createParam("@poststed", Poststed.Text, cmd);
            dbl.createParam("@alder", Alder.Text, cmd);
            dbl.createParam("@inntekt", Inntekt.Text, cmd);
            cmd.Connection = dbl.conn;
            cmd.CommandText = $"update person set fornavn = @fornavn, etternavn=@etternavn, adresse=@adresse, postnummer=@postnummer,poststed=@poststed,alder=@alder,inntekt=@inntekt where id={Request.QueryString["pnr"]}";
            dbl.writeToDB(cmd);
        }
    }
}