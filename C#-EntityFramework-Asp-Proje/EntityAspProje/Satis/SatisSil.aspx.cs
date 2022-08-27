using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class SatisSil : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["SATISID"]);
            var satis = db.TBLSATIS.Find(id);
            satis.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}