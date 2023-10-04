namespace Neo4j
{
    partial class frmSP
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
            dgvSP = new DataGridView();
            label2 = new Label();
            cboLienKet = new ComboBox();
            label1 = new Label();
            btnThem = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            cboSP = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnTaoLienKet = new Button();
            txtDate = new TextBox();
            btnLuu = new Button();
            label10 = new Label();
            cboType = new ComboBox();
            dgvLienKet = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLienKet).BeginInit();
            SuspendLayout();
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(12, 164);
            dgvSP.Name = "dgvSP";
            dgvSP.RowTemplate.Height = 25;
            dgvSP.Size = new Size(563, 424);
            dgvSP.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Chọn chuỗi cửa hàng:";
            // 
            // cboLienKet
            // 
            cboLienKet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboLienKet.FormattingEnabled = true;
            cboLienKet.Location = new Point(148, 84);
            cboLienKet.Name = "cboLienKet";
            cboLienKet.Size = new Size(427, 29);
            cboLienKet.TabIndex = 6;
            cboLienKet.SelectionChangeCommitted += cboLienKet_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(460, 23);
            label1.Name = "label1";
            label1.Size = new Size(547, 25);
            label1.TabIndex = 9;
            label1.Text = "QUẢN LÝ DANH SÁCH SẢN PHẨM THEO CHUỖI CỬA HÀNG";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 128, 128);
            btnThem.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.FromArgb(0, 0, 192);
            btnThem.Location = new Point(654, 434);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(147, 58);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(783, 164);
            txtId.Name = "txtId";
            txtId.Size = new Size(265, 23);
            txtId.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(783, 217);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 14;
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Location = new Point(783, 330);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(265, 23);
            txtGia.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Enabled = false;
            txtSoLuong.Location = new Point(783, 385);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(265, 23);
            txtSoLuong.TabIndex = 17;
            // 
            // cboSP
            // 
            cboSP.FormattingEnabled = true;
            cboSP.Location = new Point(1225, 89);
            cboSP.Name = "cboSP";
            cboSP.Size = new Size(265, 23);
            cboSP.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(654, 164);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 19;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 217);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 20;
            label4.Text = "Tên sản phẩm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(654, 273);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 21;
            label5.Text = "Ngày nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(654, 330);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 22;
            label6.Text = "Giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(654, 385);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 23;
            label7.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1096, 89);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 24;
            label8.Text = "Sản phẩm:";
            // 
            // btnTaoLienKet
            // 
            btnTaoLienKet.BackColor = Color.FromArgb(255, 128, 128);
            btnTaoLienKet.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoLienKet.ForeColor = Color.FromArgb(0, 0, 192);
            btnTaoLienKet.Location = new Point(1225, 182);
            btnTaoLienKet.Name = "btnTaoLienKet";
            btnTaoLienKet.Size = new Size(147, 58);
            btnTaoLienKet.TabIndex = 25;
            btnTaoLienKet.Text = "Tạo liên kết";
            btnTaoLienKet.UseVisualStyleBackColor = false;
            btnTaoLienKet.Click += btnTaoLienKet_Click;
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Location = new Point(783, 273);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(265, 23);
            txtDate.TabIndex = 26;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 128, 128);
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.FromArgb(0, 0, 192);
            btnLuu.Location = new Point(901, 434);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(147, 58);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1096, 142);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 31;
            label10.Text = "Thể loại:";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(1225, 142);
            cboType.Name = "cboType";
            cboType.Size = new Size(265, 23);
            cboType.TabIndex = 30;
            // 
            // dgvLienKet
            // 
            dgvLienKet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLienKet.Location = new Point(1116, 264);
            dgvLienKet.Name = "dgvLienKet";
            dgvLienKet.RowTemplate.Height = 25;
            dgvLienKet.Size = new Size(449, 323);
            dgvLienKet.TabIndex = 32;
            // 
            // frmSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1595, 675);
            Controls.Add(dgvLienKet);
            Controls.Add(label10);
            Controls.Add(cboType);
            Controls.Add(btnLuu);
            Controls.Add(txtDate);
            Controls.Add(btnTaoLienKet);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboSP);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cboLienKet);
            Controls.Add(dgvSP);
            Name = "frmSP";
            Text = "frmSP";
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLienKet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSP;
        private Label label2;
        private ComboBox cboLienKet;
        private Label label1;
        private Button btnThem;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private ComboBox cboSP;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnTaoLienKet;
        private TextBox txtDate;
        private Button btnLuu;
        private Label label10;
        private ComboBox cboType;
        private DataGridView dgvLienKet;
    }
}