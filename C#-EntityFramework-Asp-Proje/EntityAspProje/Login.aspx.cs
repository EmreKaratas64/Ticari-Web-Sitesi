using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Login : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICI == TxtKullaniciAd.Text && x.SIFRE == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Kategoriler.aspx");
            }
            else
            {
                Response.Write("Hatalı bilgi girişi");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SifremiUnuttum.aspx");
        }
    }
}