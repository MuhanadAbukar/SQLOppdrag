using DatabaseLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace webAPPSQL
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Create(object sender, EventArgs e)
        {

            var dbl = new DBL();
            var cmd = new SqlCommand("insert into person values(@id,@fornavn,@etternavn,@adresse, @postnummer,@poststed,@alder,@inntekt)",dbl.conn);
            dbl.createParam("@fornavn", Fornavn.Text, cmd);
            dbl.createParam("@etternavn", Etternavn.Text, cmd);
            dbl.createParam("@adresse", Adresse.Text, cmd);
            dbl.createParam("@postnummer", Postnummer.Text, cmd);
            dbl.createParam("@poststed", Poststed.Text, cmd);
            dbl.createParam("@alder", Alder.Text, cmd);
            dbl.createParam("@inntekt", Inntekt.Text, cmd);
            var x = new SqlCommand("select top(1)id from person order by id desc", dbl.conn);
            var dt = dbl.getReader(x);
            dbl.bindToGridView(dt, GridView1);
            var id = int.Parse(GridView1.Rows[0].Cells[0].Text) + 1;
            dbl.createParam("@id",id.ToString(),cmd);
            dbl.writeToDB(cmd);
            Button1.Text = "Updated";


        }
    }
}