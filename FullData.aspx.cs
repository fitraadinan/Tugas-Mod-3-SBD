using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Tugas3_SBD34
{
    public partial class FullData : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-TRH3HJAN\\SQLEXPRESS ;Initial Catalog = TUGAS3_SBD; Integrated Security = True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "select ID_Pendataan, m.NIM as NIM, Nama_mhs as Nama, Nama_Club as Club, Nama_Lab as Laboratorium, hari as Pertemuan from Pendataan p inner join Mahasiswa m on p.NIM = m.NIM inner join (select club.ID_Club, club.hari, club.Nama_Club, lab.Nama_Lab from club inner join lab on club.ID_Lab = Lab.ID_Lab) as c on p.ID_Club = c.ID_Club";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
            con.Close();
        }
        protected void GridViewJoin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}