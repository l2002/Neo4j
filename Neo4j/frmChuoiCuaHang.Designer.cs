namespace Neo4j
{
    partial class frmChuoiCuaHang
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
            dgvDS = new DataGridView();
            label1 = new Label();
            cboAddress = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label10 = new Label();
            txtSĐT = new TextBox();
            btnLuu = new Button();
            txtDiaChi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            btnThem = new Button();
            btnTaiLai = new Button();
            bnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 225);
            dgvDS.Name = "dgvDS";
            dgvDS.RowTemplate.Height = 25;
            dgvDS.Size = new Size(672, 462);
            dgvDS.TabIndex = 0;
            dgvDS.CellContentClick += dgvDS_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(320, 27);
            label1.Name = "label1";
            label1.Size = new Size(477, 25);
            label1.TabIndex = 6;
            label1.Text = "QUẢN LÝ CHUỖI CỬA HÀNG THEO ĐỊA ĐIỂM";
            // 
            // cboAddress
            // 
            cboAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboAddress.FormattingEnabled = true;
            cboAddress.Location = new Point(115, 99);
            cboAddress.Name = "cboAddress";
            cboAddress.Size = new Size(441, 29);
            cboAddress.TabIndex = 7;
            cboAddress.SelectedIndexChanged += cboAddress_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Chọn địa điểm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(244, 15);
            label3.TabIndex = 9;
            label3.Text = "Danh sách cửa hàng tương ứng với địa điểm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(719, 393);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 59;
            label10.Text = "SĐT:";
            // 
            // txtSĐT
            // 
            txtSĐT.Enabled = false;
            txtSĐT.Location = new Point(802, 390);
            txtSĐT.Name = "txtSĐT";
            txtSĐT.Size = new Size(265, 23);
            txtSĐT.TabIndex = 58;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 128, 128);
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.FromArgb(0, 0, 192);
            btnLuu.Location = new Point(802, 519);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(147, 58);
            btnLuu.TabIndex = 55;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Enabled = false;
            txtDiaChi.Location = new Point(802, 334);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(265, 23);
            txtDiaChi.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(719, 337);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 51;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(719, 281);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 50;
            label4.Text = "Tên CH:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(719, 228);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 49;
            label8.Text = "ID:";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(802, 278);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 47;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(802, 225);
            txtId.Name = "txtId";
            txtId.Size = new Size(265, 23);
            txtId.TabIndex = 46;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 128, 128);
            btnThem.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.FromArgb(0, 0, 192);
            btnThem.Location = new Point(719, 437);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(147, 58);
            btnThem.TabIndex = 45;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.FromArgb(255, 128, 128);
            btnTaiLai.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaiLai.ForeColor = Color.FromArgb(0, 0, 192);
            btnTaiLai.Location = new Point(562, 92);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(122, 39);
            btnTaiLai.TabIndex = 60;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // bnXoa
            // 
            bnXoa.BackColor = Color.FromArgb(255, 128, 128);
            bnXoa.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bnXoa.ForeColor = Color.FromArgb(0, 0, 192);
            bnXoa.Location = new Point(920, 437);
            bnXoa.Name = "bnXoa";
            bnXoa.Size = new Size(147, 58);
            bnXoa.TabIndex = 61;
            bnXoa.Text = "Xóa";
            bnXoa.UseVisualStyleBackColor = false;
            bnXoa.Click += bnXoa_Click;
            // 
            // frmChuoiCuaHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 718);
            Controls.Add(bnXoa);
            Controls.Add(btnTaiLai);
            Controls.Add(label10);
            Controls.Add(txtSĐT);
            Controls.Add(btnLuu);
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboAddress);
            Controls.Add(label1);
            Controls.Add(dgvDS);
            Name = "frmChuoiCuaHang";
            Text = "frmChuoiCuaHang";
            Load += frmChuoiCuaHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDS;
        private Label label1;
        private ComboBox cboAddress;
        private Label label2;
        private Label label3;
        private Label label10;
        private TextBox txtSĐT;
        private Button btnLuu;
        private TextBox txtDiaChi;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnThem;
        private Button btnTaiLai;
        private Button bnXoa;
    }
}