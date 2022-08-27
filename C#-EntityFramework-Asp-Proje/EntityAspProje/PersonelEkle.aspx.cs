using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class PersonelEkle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            TBLPERSONEL p = new TBLPERSONEL();
            p.PERSONELADSOYAD = TxtAdSoyad.Text;
            p.DURUM = true;
            db.TBLPERSONEL.Add(p);
            db.SaveChanges();
            Response.Redirect("Personel.aspx");
        }
    }
}