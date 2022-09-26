using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace webAPPSQL
{
    public partial class Edit : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                var connstr2 = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                var conn2 = new SqlConnection(connstr2);
                var id = Request.QueryString["pnr"];
                conn2.Close();
                conn2.Open();
                var cmd = new SqlCommand($"select * From person where id={id}",conn2);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn2.Close();
                GridView1.DataSource = dt;
                GridView1.DataBind();
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
            var fornavn = new SqlParameter();
            fornavn.ParameterName = "@fornavn";
            fornavn.Value = Fornavn.Text;

            var etternavn = new SqlParameter();
            etternavn.ParameterName = "@etternavn";
            etternavn.Value = Etternavn.Text;

            var adresse = new SqlParameter();
            adresse.ParameterName = "@adresse";
            adresse.Value = Adresse.Text;

            var postnummer = new SqlParameter();
            postnummer.ParameterName = "@postnummer";
            postnummer.Value = Postnummer.Text;

            var poststed = new SqlParameter();
            poststed.ParameterName = "@poststed";
            poststed.Value = Poststed.Text;

            var alder = new SqlParameter();
            alder.ParameterName = "@alder";
            alder.Value = Alder.Text;

            var inntekt = new SqlParameter();
            inntekt.ParameterName = "@inntekt";
            inntekt.Value = Inntekt.Text;

            var connstr2 = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            var conn2 = new SqlConnection(connstr2);
            var cmd = new SqlCommand();

            cmd.Parameters.Add(fornavn);
            cmd.Parameters.Add(etternavn);
            cmd.Parameters.Add(adresse);
            cmd.Parameters.Add(postnummer);
            cmd.Parameters.Add(poststed);
            cmd.Parameters.Add(alder);
            cmd.Parameters.Add(inntekt);

            cmd.Connection = conn2;
            cmd.CommandText = $"update person set fornavn = @fornavn, etternavn=@etternavn, adresse=@adresse, postnummer=@postnummer,poststed=@poststed,alder=@alder,inntekt=@inntekt where id={Request.QueryString["pnr"]}";

            conn2.Open();
            cmd.ExecuteNonQuery();
            Button1.Text = "Updated";
            conn2.Close();
        }
    }
}