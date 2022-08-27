using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var musteriler = db.TBLMUSTERI.Where(x => x.DURUM == true).ToList();
            Repeater1.DataSource = musteriler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLMUSTERI m = new TBLMUSTERI();
            m.MUSTERIAD = TextBox1.Text;
            m.MUSTERISOYAD = TextBox2.Text;
            m.DURUM = true;
            db.TBLMUSTERI.Add(m);
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");
        }
    }
}