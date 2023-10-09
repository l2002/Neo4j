namespace Neo4j
{
    partial class frmQLKH
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
            label1 = new Label();
            label2 = new Label();
            cboStore = new ComboBox();
            dgvKH = new DataGridView();
            label3 = new Label();
            btnVIP = new Button();
            btnLuu = new Button();
            txtDiaChi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label8 = new Label();
            txtNgaySinh = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnThem = new Button();
            label5 = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            txtSĐT = new TextBox();
            cboGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(563, 45);
            label1.Name = "label1";
            label1.Size = new Size(574, 25);
            label1.TabIndex = 13;
            label1.Text = "QUẢN LÝ DANH SÁCH KHÁCH HÀNG THEO CHUỖI CỬA HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 105);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 12;
            label2.Text = "Chọn chuỗi cửa hàng:";
            // 
            // cboStore
            // 
            cboStore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(141, 97);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(693, 29);
            cboStore.TabIndex = 11;
            cboStore.SelectedIndexChanged += cboStore_SelectedIndexChanged;
            // 
            // dgvKH
            // 
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(12, 177);
            dgvKH.Name = "dgvKH";
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(822, 450);
            dgvKH.TabIndex = 10;
            dgvKH.CellContentClick += dgvKH_CellContentClick;
            dgvKH.SelectionChanged += dgvKH_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 14;
            label3.Text = "Danh sách khách hàng:";
            // 
            // btnVIP
            // 
            btnVIP.BackColor = Color.FromArgb(255, 128, 128);
            btnVIP.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVIP.ForeColor = Color.FromArgb(0, 0, 192);
            btnVIP.Location = new Point(11, 642);
            btnVIP.Name = "btnVIP";
            btnVIP.Size = new Size(327, 58);
            btnVIP.TabIndex = 15;
            btnVIP.Text = "Xem danh sách khách hàng VIP";
            btnVIP.UseVisualStyleBackColor = false;
            btnVIP.Click += btnVIP_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 128, 128);
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.FromArgb(0, 0, 192);
            btnLuu.Location = new Point(1091, 578);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(147, 58);
            btnLuu.TabIndex = 39;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Enabled = false;
            txtDiaChi.Location = new Point(973, 283);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(265, 23);
            txtDiaChi.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(890, 398);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 37;
            label7.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(890, 343);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 36;
            label6.Text = "Phái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(890, 230);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 34;
            label4.Text = "Tên KH:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(890, 177);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 33;
            label8.Text = "ID:";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Enabled = false;
            txtNgaySinh.Location = new Point(973, 395);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(265, 23);
            txtNgaySinh.TabIndex = 32;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(973, 227);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 30;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(973, 174);
            txtId.Name = "txtId";
            txtId.Size = new Size(265, 23);
            txtId.TabIndex = 29;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 128, 128);
            btnThem.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.FromArgb(0, 0, 192);
            btnThem.Location = new Point(890, 578);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(147, 58);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(890, 286);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 35;
            label5.Text = "Địa chỉ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(890, 459);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 41;
            label9.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(973, 456);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(890, 514);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 43;
            label10.Text = "SĐT:";
            // 
            // txtSĐT
            // 
            txtSĐT.Enabled = false;
            txtSĐT.Location = new Point(973, 511);
            txtSĐT.Name = "txtSĐT";
            txtSĐT.Size = new Size(265, 23);
            txtSĐT.TabIndex = 42;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(973, 341);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(265, 23);
            cboGender.TabIndex = 44;
            // 
            // frmQLKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 712);
            Controls.Add(cboGender);
            Controls.Add(label10);
            Controls.Add(txtSĐT);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(btnLuu);
            Controls.Add(txtDiaChi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnThem);
            Controls.Add(btnVIP);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cboStore);
            Controls.Add(dgvKH);
            Name = "frmQLKH";
            Text = "frmQLKH";
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboStore;
        private ComboBox cboPhai;
        private DataGridView dgvKH;
        private Label label3;
        private Button btnVIP;
        private Button btnLuu;
        private TextBox txtDiaChi;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label8;
        private TextBox txtNgaySinh;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnThem;
        private Label label5;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
        private TextBox txtSĐT;
        private ComboBox cboGender;
    }
}