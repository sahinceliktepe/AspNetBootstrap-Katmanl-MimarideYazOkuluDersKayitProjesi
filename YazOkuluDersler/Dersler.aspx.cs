using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace YazOkuluDersler
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> entDers = BLLDers.BllListele();
                DropDownList1.DataSource = BLLDers.BllListele();
                DropDownList1.DataTextField = "dersAd";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BasOgrId = int.Parse(TextBox1.Text);
            ent.BasDersId = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);
        }
    }
}