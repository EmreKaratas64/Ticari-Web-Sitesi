using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["PERSONELID"]);
                var personel = db.TBLPERSONEL.Find(id);
                TxtPersonelID.Text = id.ToString();
                TxtPersonelAdSoyad.Text = personel.PERSONELADSOYAD;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["PERSONELID"]);
            var personel = db.TBLPERSONEL.Find(id);
            personel.PERSONELADSOYAD = TxtPersonelAdSoyad.Text;
            db.SaveChanges();
            Response.Redirect("Personel.aspx");
        }
    }
}