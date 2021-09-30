using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;

namespace MyBlogSystem
{
    public partial class DatabaseTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                //con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["NewTest"].ConnectionString;
                //string command = "select * from stu";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id,name,price from food";
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DropDownList1.DataSource = rdr;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "name";
                DropDownList1.DataBind();
                con.Close();
            }
        }
    }
}