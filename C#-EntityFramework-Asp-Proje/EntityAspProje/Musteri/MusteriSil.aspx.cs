using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class MusteriSil : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            var musteri = db.TBLMUSTERI.Find(id);
            musteri.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");

        }
    }
}