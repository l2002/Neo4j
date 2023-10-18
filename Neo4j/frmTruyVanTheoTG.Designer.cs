namespace Neo4j
{
    partial class frmTruyVanTheoTG
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
            label2 = new Label();
            label1 = new Label();
            btnTim = new Button();
            dgvDS = new DataGridView();
            txtStart = new TextBox();
            label3 = new Label();
            txtEnd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(1212, 47);
            label2.TabIndex = 9;
            label2.Text = "TRUY VẤN DANH SÁCH KHÁCH HÀNG MUA THEO THỜI GIAN ĐỊNH KỲ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 124);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 8;
            label1.Text = "Từ ngày:";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(1102, 122);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 29);
            btnTim.TabIndex = 7;
            btnTim.Text = "Tuy vấn";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 198);
            dgvDS.Name = "dgvDS";
            dgvDS.RowTemplate.Height = 25;
            dgvDS.Size = new Size(1208, 446);
            dgvDS.TabIndex = 6;
            // 
            // txtStart
            // 
            txtStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStart.Location = new Point(165, 122);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(352, 29);
            txtStart.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(623, 124);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 11;
            label3.Text = "Đến ngày:";
            // 
            // txtEnd
            // 
            txtEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnd.Location = new Point(708, 122);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(352, 29);
            txtEnd.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(165, 99);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 12;
            label4.Text = "Năm-Thàng-Ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(708, 99);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 13;
            label5.Text = "Năm-Thàng-Ngày";
            // 
            // frmTruyVanTheoTG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 656);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEnd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(dgvDS);
            Controls.Add(txtStart);
            Name = "frmTruyVanTheoTG";
            Text = "frmTruyVanTheoTG";
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnTim;
        private DataGridView dgvDS;
        private TextBox txtStart;
        private Label label3;
        private TextBox txtEnd;
        private Label label4;
        private Label label5;
    }
}