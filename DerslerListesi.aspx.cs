using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

public partial class DerslerListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityDers> DerslerListesi = BLLDers.DersLısteleBLL();
        Repeater1.DataSource = DerslerListesi;
        Repeater1.DataBind();
    }
}