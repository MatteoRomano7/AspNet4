using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concessionaria
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Concessionaria"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Auto", con);
                 var listaAuto = cmd.ExecuteReader();
                while (listaAuto.Read())
                {
                    if (!IsPostBack)
                    {
                        var menuItem = new ListItem();
                        menuItem.Text = listaAuto["Marca"] + " " + listaAuto["Modello"];
                        menuItem.Value = listaAuto["ID"].ToString();
                        dropdownAuto.Items.Add(menuItem);
                    }
                    
                    
                    if (dropdownAuto.SelectedValue == listaAuto["ID"].ToString())
                    {
                        carImg.Src = listaAuto["Foto"].ToString();
                        


                    }
                }                 
            }
            catch 
            {
                Response.Write("Errore");
            }
        }

        protected void dropdownAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}