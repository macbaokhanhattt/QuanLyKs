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
    public partial class Form1 : Form
    {
        public string constr = @"Data Source=DESKTOPPC\SQLEXPRESS;Initial Catalog=QLPKS;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = "";
            string mk = ""; 
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TK = N'" + txtTK.Text + "' AND MK = N'"+txtMK.Text +"' " , cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            tk = (string)row["TK"] + "";
                            mk = (string)row["MK"] + "";
                        }
                    }

                }
            }

            if( tk == txtTK.Text && mk == txtMK.Text)
            {
                Main child = new Main();

                this.Hide();
                child.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Text = "";
                txtMK.Text = "";
            }

        }
    }
}
