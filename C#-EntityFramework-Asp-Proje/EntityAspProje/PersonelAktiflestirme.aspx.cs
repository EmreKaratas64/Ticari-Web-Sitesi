using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class PersonelAktiflestirme : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtPersonelID.Text);
            var personel = db.TBLPERSONEL.Find(id);
            personel.DURUM = true;
            db.SaveChanges();
            Response.Redirect("Personel.aspx");
        }
    }
}