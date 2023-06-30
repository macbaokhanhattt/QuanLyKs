namespace QuanLyKS_HAU_Nhom2
{
    partial class Phong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTrong = new System.Windows.Forms.DataGridView();
            this.dgvSD = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.lblPhongSD = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblSoNg = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.cbDV = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrong
            // 
            this.dgvTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrong.Location = new System.Drawing.Point(12, 49);
            this.dgvTrong.Name = "dgvTrong";
            this.dgvTrong.RowHeadersWidth = 51;
            this.dgvTrong.RowTemplate.Height = 24;
            this.dgvTrong.Size = new System.Drawing.Size(601, 209);
            this.dgvTrong.TabIndex = 0;
            this.dgvTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrong_CellContentClick);
            // 
            // dgvSD
            // 
            this.dgvSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSD.Location = new System.Drawing.Point(12, 427);
            this.dgvSD.Name = "dgvSD";
            this.dgvSD.RowHeadersWidth = 51;
            this.dgvSD.RowTemplate.Height = 24;
            this.dgvSD.Size = new System.Drawing.Size(601, 191);
            this.dgvSD.TabIndex = 1;
            this.dgvSD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSD_CellContentClick);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhong.Location = new System.Drawing.Point(307, 319);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(136, 58);
            this.btnThemPhong.TabIndex = 5;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Location = new System.Drawing.Point(747, 264);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(136, 58);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhong.Location = new System.Drawing.Point(477, 317);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(136, 62);
            this.btnXoaPhong.TabIndex = 7;
            this.btnXoaPhong.Text = "Xóa Phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.Black;
            this.btnTraPhong.Location = new System.Drawing.Point(747, 427);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(136, 58);
            this.btnTraPhong.TabIndex = 8;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // lblPhongTrong
            // 
            this.lblPhongTrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPhongTrong.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPhongTrong.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongTrong.ForeColor = System.Drawing.Color.Black;
            this.lblPhongTrong.Location = new System.Drawing.Point(16, 9);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(200, 37);
            this.lblPhongTrong.TabIndex = 10;
            this.lblPhongTrong.Text = "Phòng Trống";
            this.lblPhongTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhongTrong.UseCompatibleTextRendering = true;
            // 
            // lblPhongSD
            // 
            this.lblPhongSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPhongSD.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPhongSD.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongSD.ForeColor = System.Drawing.Color.Black;
            this.lblPhongSD.Location = new System.Drawing.Point(12, 387);
            this.lblPhongSD.Name = "lblPhongSD";
            this.lblPhongSD.Size = new System.Drawing.Size(193, 37);
            this.lblPhongSD.TabIndex = 11;
            this.lblPhongSD.Text = "Phòng Sử Dụng";
            this.lblPhongSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhongSD.UseCompatibleTextRendering = true;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(132, 275);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(136, 22);
            this.txtSoPhong.TabIndex = 12;
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Location = new System.Drawing.Point(12, 275);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(89, 20);
            this.lblSoPhong.TabIndex = 16;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(303, 275);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(115, 20);
            this.lblLoaiPhong.TabIndex = 17;
            this.lblLoaiPhong.Text = "Loại Phòng: ";
            // 
            // lblSoNg
            // 
            this.lblSoNg.AutoSize = true;
            this.lblSoNg.Location = new System.Drawing.Point(677, 46);
            this.lblSoNg.Name = "lblSoNg";
            this.lblSoNg.Size = new System.Drawing.Size(0, 16);
            this.lblSoNg.TabIndex = 20;
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(619, 54);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(123, 20);
            this.lblKH.TabIndex = 23;
            this.lblKH.Text = "Khách Hàng: ";
            // 
            // cbKH
            // 
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(747, 54);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(207, 24);
            this.cbKH.TabIndex = 24;
            this.cbKH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(445, 275);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(168, 24);
            this.cbLoaiPhong.TabIndex = 25;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(747, 102);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(100, 22);
            this.txtSoNgay.TabIndex = 26;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgay.Location = new System.Drawing.Point(619, 102);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(85, 20);
            this.lblSoNgay.TabIndex = 27;
            this.lblSoNgay.Text = "Số Ngày ";
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.Location = new System.Drawing.Point(619, 154);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(76, 20);
            this.lblDichVu.TabIndex = 28;
            this.lblDichVu.Text = "Dịch Vụ";
            // 
            // cbDV
            // 
            this.cbDV.FormattingEnabled = true;
            this.cbDV.Location = new System.Drawing.Point(746, 156);
            this.cbDV.Name = "cbDV";
            this.cbDV.Size = new System.Drawing.Size(207, 24);
            this.cbDV.TabIndex = 29;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(619, 215);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(88, 20);
            this.lblSoLuong.TabIndex = 30;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(747, 215);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 31;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(965, 630);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cbDV);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.cbKH);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.lblSoNg);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.lblPhongSD);
            this.Controls.Add(this.lblPhongTrong);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.dgvSD);
            this.Controls.Add(this.dgvTrong);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrong;
        private System.Windows.Forms.DataGridView dgvSD;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Label lblPhongSD;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSoNg;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.ComboBox cbDV;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}