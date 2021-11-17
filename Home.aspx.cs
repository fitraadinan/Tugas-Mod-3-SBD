using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Tugas3_SBD34
{
    public partial class Home : System.Web.UI.Page
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
                DataShow1();
                DataShow2();
                DataShow3();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT a.NIM, a.nama_mhs as Nama FROM Mahasiswa a WHERE is_delete = 0 ORDER BY NIM ASC";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
            con.Close();
        }
        public void DataShow1()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT a.ID_Club, a.nama_club as Club, a.Hari as Pertemuan FROM Club a WHERE is_delete = 0 ORDER BY ID_Club ASC";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
        public void DataShow2()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT a.ID_Lab, a.nama_lab as Laboratorium FROM Lab a WHERE is_delete = 0 ORDER BY ID_Lab ASC";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }
        public void DataShow3()
        {
            ds = new DataSet();
            cmd.CommandText = "select ID_Pendataan, Nama_mhs as Nama, Nama_Club as Club from Pendataan p inner join Mahasiswa m on p.NIM = m.NIM inner join (select club.ID_Club, club.hari, club.Nama_Club, lab.Nama_Lab from club inner join lab on club.ID_Lab = Lab.ID_Lab) as c on p.ID_Club = c.ID_Club";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            GridView3.DataSource = ds;
            GridView3.DataBind();
            con.Close();
        }
       
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Mahasiswa(NIM, Nama_mhs)values('" + txtnim.Text.ToString() + "', '" + txtnama_mhs.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "UPDATE Mahasiswa SET nim = '" + txtnim.Text.ToString() + "', nama_mhs= '" + txtnama_mhs.Text.ToString() + "' WHERE nim = '" + txtnim.Text.ToString() + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "UPDATE Mahasiswa SET is_delete = 1 WHERE NIM = '" + txtnim.Text + "'";
            cmd.Connection = con; cmd.ExecuteNonQuery(); DataShow();
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtnim.Text = null;
            txtnama_mhs.Text = null;
        }

        protected void btnAdd_Click3(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "INSERT INTO Pendataan(NIM, ID_Club) VALUES('" + txtnimmhs.Text.ToString() + "', '" + txtid_clubmhs.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow3();
        }

        protected void btnDelete_Click4(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete From Pendataan WHERE ID_Pendataan = '" + txtiddata.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow3();
        }

        protected void btnClear_Click3(object sender, EventArgs e)
        {
            txtnimmhs.Text = null;
            txtid_clubmhs.Text = null;
        }
    }
}