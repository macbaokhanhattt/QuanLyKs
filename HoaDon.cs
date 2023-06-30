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
    public partial class HoaDon : Form
    {
        public string constr = @"Data Source=DESKTOPPC\SQLEXPRESS;Initial Catalog=QLPKS;Integrated Security=True";
        public HoaDon()
        {
            InitializeComponent();

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Ten_KH FROM tblKhachHang", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbKH.ValueMember = "Ten_KH";
                        cbKH.DataSource = dt;
                    }

                }
            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataHD()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT P.SoPhong AS 'Phòng Số', LP.TenPhong AS 'Tên Phòng' , KH.Ten_KH AS 'Khách Hàng'  ,  HD_P.SoNgay AS 'Số Ngày' , DV.Ten_DV AS 'Dịch Vụ', HD_DV.SoLuong AS 'Số Lượng' , HD.TongTien AS 'Tổng Tiền' FROM  tblLoaiPhong AS LP , tblPhong AS P , tblHoaDon_Phong AS HD_P , tblHoaDon AS HD , tblKhachHang AS KH , tblHoaDon_DV AS HD_DV , tblDichVu AS DV " +
                    "WHERE P.Ma_Loaiphong = LP.ID AND P.ID = HD_P.Ma_Phong AND HD_P.ID = HD.Ma_HD_P AND HD.Ma_HD_DV = HD_DV.ID AND HD_DV.Ma_DV = DV.ID AND HD.Ma_KH = KH.ID", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvHD.DataSource = dt;

                    }
                }
            }



        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHD(); 
        }

        private void lblKH_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT P.SoPhong AS 'Phòng Số', LP.TenPhong AS 'Tên Phòng' , KH.Ten_KH AS 'Khách Hàng'  ,  HD_P.SoNgay AS 'Số Ngày' , DV.Ten_DV AS 'Dịch Vụ', HD_DV.SoLuong AS 'Số Lượng' , HD.TongTien AS 'Tổng Tiền' FROM  tblLoaiPhong AS LP , tblPhong AS P , tblHoaDon_Phong AS HD_P , tblHoaDon AS HD , tblKhachHang AS KH , tblHoaDon_DV AS HD_DV , tblDichVu AS DV " +
                    "WHERE P.Ma_Loaiphong = LP.ID AND P.ID = HD_P.Ma_Phong " +
                    "AND HD_P.ID = HD.Ma_HD_P AND HD.Ma_HD_DV = HD_DV.ID " +
                    "AND HD_DV.Ma_DV = DV.ID " +
                    "AND HD.Ma_KH = KH.ID  AND KH.Ten_KH = N'" + cbKH.Text + "' " , cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvHD.DataSource = dt;

                    }
                }
            }



        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadDataHD(); 
        }
    }
}
