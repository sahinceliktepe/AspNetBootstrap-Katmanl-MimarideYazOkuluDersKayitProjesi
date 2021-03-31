using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrId"].ToString());
            txtId.Text = x.ToString();
            txtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> ogrList = BLLOgrenci.BllDetay(x);
                txtAd.Text = ogrList[0].Ad.ToString();
                txtSoyad.Text = ogrList[0].Soyad.ToString();
                txtNumara.Text = ogrList[0].Numara.ToString();
                txtFoto.Text = ogrList[0].Fotograf.ToString();
                txtSifre.Text = ogrList[0].Sifre.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sifre = txtSifre.Text;
            ent.Numara = txtNumara.Text;
            ent.Fotograf = txtFoto.Text;
            ent.Id = Convert.ToInt32(txtId.Text);
            BLLOgrenci.OgrenciGuncelle(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}