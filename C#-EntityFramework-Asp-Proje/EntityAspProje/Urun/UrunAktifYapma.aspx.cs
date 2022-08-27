using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunAktifYapma : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(TxtUrunID.Text);
            var urun = db.TBLURUNLER.Find(id);
            urun.DURUM = true;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}