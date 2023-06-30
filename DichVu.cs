using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS_HAU_Nhom2
{
    public partial class DichVu : Form
    {
        public string constr = @"Data Source=DESKTOPPC\SQLEXPRESS;Initial Catalog=QLPKS;Integrated Security=True"; 
        public DichVu()
        {
            InitializeComponent();
        }

        private void LoadDataPDV()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblLoaiPhong", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvPhong.DataSource = dt;

                    }
                }
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblDichVu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvDV.DataSource = dt;

                    }
                }
            }



        }


        private void DichVu_Load(object sender, EventArgs e)
        {
            LoadDataPDV(); 
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO tblLoaiPhong VALUES( N'" + txtTenPhong.Text + "' ,"+ txtSoNguoi.Text + " , " + txtGiaPhong.Text + ")";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadDataPDV(); 
        }

        private void lblMaPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO tblDichVu VALUES( N'" + txtTenDV.Text + "' ," + txtGiaDV.Text + ")";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadDataPDV();
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "UPDATE tblLoaiPhong SET TenPhong = N'" + txtTenPhong.Text + "' , SoNguoi = " + txtSoNguoi.Text + " , GiaPhong = " + txtGiaPhong.Text + " " +
                        "WHERE ID = "+ dgvPhong.CurrentRow.Cells["ID"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadDataPDV();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "UPDATE tblDichVu SET Ten_DV = N'" + txtTenDV.Text + "' , Gia_DV = " + txtGiaDV.Text + " " +
                        "WHERE ID = " + dgvDV.CurrentRow.Cells["ID"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadDataPDV();
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM tblLoaiphong WHERE ID = " + dgvPhong.CurrentRow.Cells["ID"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadDataPDV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM tblDichVu WHERE ID = " + dgvDV.CurrentRow.Cells["ID"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadDataPDV();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenPhong.Text = dgvPhong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtSoNguoi.Text = dgvPhong.CurrentRow.Cells["SoNguoi"].Value.ToString();
            txtGiaPhong.Text = dgvPhong.CurrentRow.Cells["GiaPhong"].Value.ToString();
        }

        private void dgvDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDV.Text = dgvDV.CurrentRow.Cells["Ten_DV"].Value.ToString();
            txtGiaDV.Text = dgvDV.CurrentRow.Cells["Gia_DV"].Value.ToString();
        }
    }
}
