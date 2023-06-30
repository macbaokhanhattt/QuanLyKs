using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS_HAU_Nhom2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {

        }

        private void Phòng_Load(object sender, EventArgs e)
        {

        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.MdiParent = this;
            p.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.MdiParent = this;
            dv.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show(
                "Bạn có muốn chắn chắn thoát",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cc == DialogResult.Yes)
            {
                Close();
            }
            else if (cc == DialogResult.No)
            {
                MessageBox.Show("Mời tiếp tục dùng!");
            }

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MdiParent = this;
            hd.Show();
        }
    }
}
