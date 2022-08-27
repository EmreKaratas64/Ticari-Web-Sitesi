using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(TxtAdminID.Text);
            var admin = db.TBLADMIN.Find(id);
            if(admin.KULLANICI==TxtKullaniciAd.Text && TxtSifre1.Text == TxtSifre2.Text)
            {
                admin.SIFRE = TxtSifre1.Text;
                db.SaveChanges();
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("Hatalı giriş yaptınız kontrol edip tekrar deneyiniz !");
            }
        }
    }
}