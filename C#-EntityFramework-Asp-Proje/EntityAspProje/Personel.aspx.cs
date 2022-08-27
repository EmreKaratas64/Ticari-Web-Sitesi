using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Personel : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var personeller = db.TBLPERSONEL.Where(x => x.DURUM == true).ToList();
            Repeater1.DataSource = personeller;
            Repeater1.DataBind();
        }
    }
}