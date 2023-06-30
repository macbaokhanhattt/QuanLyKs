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
    public partial class Phong : Form
    {
        public string constr = @"Data Source=DESKTOPPC\SQLEXPRESS;Initial Catalog=QLPKS;Integrated Security=True"; 
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TenPhong FROM tblLoaiPhong ", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbLoaiPhong.ValueMember = "TenPhong";
                        cbLoaiPhong.DataSource = dt;
                    }

                }
            }
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

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Ten_DV FROM tblDichVu", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbDV.ValueMember = "Ten_DV";  
                        cbDV.DataSource = dt;
                    }

                }
            }

            LoadData(); 

        }

        public void LoadData()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT SoPhong AS 'Phòng Số' , TenPhong AS 'Tên Phòng' , GiaPhong AS 'Giá Phòng' , SoNguoi AS 'Số Người'   " +
                    "FROM tblPhong AS P  , tblLoaiPhong AS LP  WHERE P.Ma_LoaiPhong = LP.ID AND P.TrangThai = 0 ;", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dgvTrong.DataSource = dt;
                    }
                }
                //ThemNgaySinh();
            }
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT SoPhong AS 'Phòng Số' , TenPhong AS 'Tên Phòng' , GiaPhong AS 'Giá Phòng' , SoNguoi AS 'Số Người'   " +
                    "FROM tblPhong AS P  , tblLoaiPhong AS LP  WHERE P.Ma_LoaiPhong = LP.ID AND P.TrangThai = 1 ;", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dgvSD.DataSource = dt;
                    }
                }
                //ThemNgaySinh();
            }
        }


        private void dgvTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnThemPhong_Click(object sender, EventArgs e)
        {
           
            string a = ""; 
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID FROM tblLoaiPhong WHERE TenPhong = N'" + cbLoaiPhong.Text + "'", cnn)) 
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        /*
                        DataRow row = dt.Rows[0];
                        a = (string)row["ID"];
                        */
                        foreach (DataRow row in dt.Rows)
                        {
                            a = (int)row["ID"] + "";
                        }
                        /*
                        DataRow row = dataTable.NewRow();
                        row["Id] = 101;
                        row["Name"] = "Freetuts";
                        row["Email"] = "Freetuts.net";
                        */

                    }
                }
                
            }

            /*
            string idPhong = "";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID FROM tblPhong WHERE SoPhong = " + dgvTrong.CurrentRow.Cells["Phòng Số"].Value.ToString() + "", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            idPhong = (int)row["ID"] + "";
                        }
                    }
                }

            }
            */ 
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                   
                    cmd.CommandText = "INSERT INTO tblPhong VALUES( " + txtSoPhong.Text + " , 0 , " +  a + ")" ;
                    cmd.ExecuteNonQuery();
                }
                
                cnn.Close();
            }

            LoadData(); 
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            string idPhong = "";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID FROM tblPhong WHERE SoPhong = " + dgvTrong.CurrentRow.Cells["Phòng Số"].Value.ToString() + "", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            idPhong = (int)row["ID"] + "";
                        }
                    }
                }

            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM tblHoaDon WHERE ID IN ( SELECT ID FROM tblHoaDon_Phong WHERE Ma_Phong = " + idPhong + " ) ";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM tblHoaDon_Phong WHERE Ma_Phong = " + idPhong + "";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM tblPhong WHERE ID = '" + idPhong + "'";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM tblPhong WHERE ID = '" + idPhong +"'" ;
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadData(); 
        }














        private string getIDKH( string tenKH)
        {
            string idKH = ""; 
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID FROM tblKhachHang WHERE Ten_KH = N'" + tenKH + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        /*
                        DataRow row = dt.Rows[0];
                        a = (string)row["ID"];
                        */
                        foreach (DataRow row in dt.Rows)
                        {
                            idKH = (int)row["ID"] + "";
                        }
                        /*
                        DataRow row = dataTable.NewRow();
                        row["Id] = 101;
                        row["Name"] = "Freetuts";
                        row["Email"] = "Freetuts.net";
                        */

                    }
                }
            }

            return idKH; 


        }


        private string getIDHD_Phong( string idPhong)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO tblHoaDon_Phong VALUES(" + idPhong + " , " + txtSoNgay.Text + " )";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }


            string idHD_Phong = "";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID FROM tblHoaDon_Phong WHERE Ma_Phong = " + idPhong + "", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        /*
                        DataRow row = dt.Rows[0];
                        a = (string)row["ID"];
                        */
                        foreach (DataRow row in dt.Rows)
                        {
                            idHD_Phong = (int)row["ID"] + "";
                        }
                        /*
                        DataRow row = dataTable.NewRow();
                        row["Id] = 101;
                        row["Name"] = "Freetuts";
                        row["Email"] = "Freetuts.net";
                        */

                    }
                }
            }
            return idHD_Phong;
        }


        private double tongGiaDV(string tenDV, int soLuong)
        {
            // Tong Gia dich vu 
            string idDV = "";
            double giaDV = 0;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID , Gia_DV FROM tblDichVu WHERE Ten_DV = N'" + tenDV + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            idDV = (int)row["ID"] + "";
                            giaDV = (double)row["Gia_DV"];
                        }


                    }
                }
            }


            double tongGia = giaDV * soLuong;
            return tongGia;
        }
        
        private string getIDHD_DV( string tenDV , int soLuong  )
        {
            string idDV = "";
            double giaDV = 0;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID , Gia_DV FROM tblDichVu WHERE Ten_DV = N'" + tenDV + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            idDV = (int)row["ID"] + "";
                            giaDV = (double)row["Gia_DV"];
                        }


                    }
                }
            }

            double tongGia = tongGiaDV( tenDV , soLuong ); 

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO tblHoaDon_DV VALUES(" + idDV + " , " + soLuong + " ," + tongGia + " )";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }










            string idHDDV = "";
            
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID  FROM tblHoaDon_DV WHERE Ma_DV = " + idDV + " AND SoLuong = " + soLuong+"", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        
                        foreach (DataRow row in dt.Rows)
                        {
                            idHDDV = (int)row["ID"] + ""; 
                        }
                        

                    }
                }
            }

            return idHDDV;


        }

        private string tongGia(string tenDV , int soLuong)
        {

            // Tong Gia Phong
            double Gia = tongGiaDV( tenDV , soLuong );

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT  SoNgay*GiaPhong AS 'Gia' FROM tblPhong AS P , tblLoaiPhong AS LP , tblHoaDon_Phong AS HD_P" +
                    " WHERE P.Ma_Loaiphong = LP.ID AND P.ID = HD_P.Ma_Phong AND LP.TenPhong = N'" + dgvTrong.CurrentRow.Cells["Tên Phòng"].Value.ToString() + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            Gia += (double)row["Gia"];
                        }


                    }
                }
            }
            return Gia+""; 
        }



        private void btnDatPhong_Click(object sender, EventArgs e)
        {

            string idKH = getIDKH( cbKH.Text )  ;

            string idPhong = dgvTrong.CurrentRow.Cells["Phòng Số"].Value.ToString();

            string idHD_Phong = getIDHD_Phong(idPhong);

            int soLuong = int.Parse(txtSoLuong.Text);
            string idHDDV = getIDHD_DV(cbDV.Text, soLuong);

            string Gia = tongGia( cbDV.Text , soLuong); 
            //string idPhong = dgvTrong.CurrentRow.Cells["Phòng Số"].Value.ToString();
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO tblHoaDon VALUES(" + idKH + " , "+ idHD_Phong +" , "+ idHDDV +" ,"+ Gia + " )";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "UPDATE tblPhong SET TrangThai = 1   WHERE ID = " + dgvTrong.CurrentRow.Cells["Phòng Số"].Value.ToString() + ""; 
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cmd.CommandText = "UPDATE tblPhong SET TrangThai = 0   WHERE ID = " + dgvSD.CurrentRow.Cells["Phòng Số"].Value.ToString() + "";
                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
            }
            LoadData();
        }
    }
}
