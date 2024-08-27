using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer; 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci Ogrenci = new EntityOgrenci();
        Ogrenci.AD = TxtAd.Text;
        Ogrenci.SOYAD= TxtSoyad.Text;
        Ogrenci.NUMARA = TxtNumara.Text;
        Ogrenci.SIFRE = TxtSıfre.Text;
        Ogrenci.FOTOGRAF = TxtFoto.Text;

        BLLOgrenci.OgrenciEkleBLL(Ogrenci);
    }
}