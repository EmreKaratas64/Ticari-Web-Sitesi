using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class SatisGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.TBLURUNLER select new { x.URUNID, x.URUNAD }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var musteri = (from x in db.TBLMUSTERI
                               select new
                               {
                                   x.MUSTERIID,
                                   ADSOYAD = x.MUSTERIAD + " " + x.MUSTERISOYAD
                               }).ToList();
                DropDownList2.DataTextField = "ADSOYAD";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = musteri;
                DropDownList2.DataBind();

                var personel = (from x in db.TBLPERSONEL select new { x.PERSONELID, x.PERSONELADSOYAD }).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = personel;
                DropDownList3.DataBind();


                int id = Convert.ToInt32(Request.QueryString["SATISID"]);
                var satis = db.TBLSATIS.Find(id);
                DropDownList1.SelectedValue = satis.URUN.ToString();
                DropDownList2.SelectedValue = satis.MUSTERI.ToString();
                DropDownList3.SelectedValue = satis.PERSONEL.ToString();
                TxtFiyat.Text = satis.FIYAT.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["SATISID"]);
            var satis = db.TBLSATIS.Find(id);
            satis.URUN = int.Parse(DropDownList1.SelectedValue);
            satis.MUSTERI = int.Parse(DropDownList2.SelectedValue);
            satis.PERSONEL = byte.Parse(DropDownList3.SelectedValue);
            satis.FIYAT = decimal.Parse(TxtFiyat.Text);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}