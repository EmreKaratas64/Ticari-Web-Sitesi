using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class MusteriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
                var musteri = db.TBLMUSTERI.Find(id);
                TxtMusteriID.Text = id.ToString();
                TxtMusteriAd.Text = musteri.MUSTERIAD;
                TxtMusteriSoyad.Text = musteri.MUSTERISOYAD;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            var musteri = db.TBLMUSTERI.Find(id);
            musteri.MUSTERIAD = TxtMusteriAd.Text;
            musteri.MUSTERISOYAD = TxtMusteriSoyad.Text;
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");
        }
    }
}