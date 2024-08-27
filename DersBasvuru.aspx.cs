using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


public partial class DersBasvuru : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityDers> DersListesi = BLLDers.DersLısteleBLL();
        DropDownList1.DataSource = DersListesi;
        DropDownList1.DataTextField = "DERSAD";
        DropDownList1.DataValueField = "ID";
        DropDownList1.DataBind();

         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvuru entityBasvuru = new EntityBasvuru();
        entityBasvuru.BASOGRID = Convert.ToInt32(TextBox1.Text);
        entityBasvuru.BASDERSID = int.Parse(DropDownList1.SelectedValue);

        BLLDers.TalepEkleBLL(entityBasvuru);
    }
}