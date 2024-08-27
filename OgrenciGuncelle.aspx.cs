using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["OGRID"]);
        Txtid.Text = id.ToString();


        if (Page.IsPostBack==false)
        {
            List<EntityOgrenci> OgrBilgi = BLLOgrenci.BLLOgrenciDetay(id);

            TxtAd.Text = OgrBilgi[0].AD.ToString();
            TxtSoyad.Text = OgrBilgi[0].SOYAD.ToString();
            TxtNumara.Text = OgrBilgi[0].NUMARA.ToString();
            TxtFoto.Text = OgrBilgi[0].FOTOGRAF.ToString();
            TxtSıfre.Text= OgrBilgi[0].SIFRE.ToString();

        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci entityOgrenci = new EntityOgrenci();
        
        entityOgrenci.AD=TxtAd.Text;
        entityOgrenci.SOYAD=TxtSoyad.Text;
        entityOgrenci.NUMARA=TxtNumara.Text;
        entityOgrenci.FOTOGRAF=TxtFoto.Text;
        entityOgrenci.SIFRE=TxtSıfre.Text;
        entityOgrenci.ID = Convert.ToInt32(Txtid.Text);


        BLLOgrenci.OgrenciGuncelleBLL(entityOgrenci);
        Response.Redirect("OgrenciListesi.aspx");
    }
}