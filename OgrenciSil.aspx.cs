using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.ServiceModel.Channels;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        EntityOgrenci Ogrenci = new EntityOgrenci();
        int id = Convert.ToInt32(Request.QueryString["OGRID"]);
        Ogrenci.ID = id;
        BLLOgrenci.OgrenciSilBLL(Ogrenci.ID);
        Response.Redirect("OgrenciListesi.aspx");
        
    }
}