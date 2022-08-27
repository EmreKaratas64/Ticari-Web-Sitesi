using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class MusteriAktiflestir : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(TxtMusteriID.Text);
            var musteri = db.TBLMUSTERI.Find(id);
            musteri.DURUM = true;
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");
        }
    }
}