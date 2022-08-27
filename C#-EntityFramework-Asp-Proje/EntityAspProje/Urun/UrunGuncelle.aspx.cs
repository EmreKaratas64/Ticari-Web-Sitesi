using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;


namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var p = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = p;
                DropDownList1.DataBind();

                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var urun = db.TBLURUNLER.Find(id);
                TxtUrunAd.Text = urun.URUNAD;
                TxtMarka.Text = urun.URUNMARKA;
                TxtFiyat.Text = urun.URUNFIYAT.ToString();
                TxtStok.Text = urun.URUNSTOK.ToString();
                DropDownList1.SelectedValue = urun.URUNKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun = db.TBLURUNLER.Find(id);
            urun.URUNAD = TxtUrunAd.Text;
            urun.URUNMARKA = TxtMarka.Text;
            urun.URUNFIYAT = decimal.Parse(TxtFiyat.Text);
            urun.URUNSTOK = short.Parse(TxtStok.Text);
            urun.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
            
        }
    }
}