namespace Neo4j
{
    partial class frmTruyVanLichSu
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTim = new Button();
            dgvDS = new DataGridView();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 22);
            label2.Name = "label2";
            label2.Size = new Size(803, 50);
            label2.TabIndex = 10;
            label2.Text = "TÌM LỊCH SỬ MUA HÀNG CỦA KHÁCH HÀNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 119);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 9;
            label1.Text = "Nhập tên khách hàng:";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(697, 116);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 26);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 194);
            dgvDS.Name = "dgvDS";
            dgvDS.RowTemplate.Height = 25;
            dgvDS.Size = new Size(1005, 438);
            dgvDS.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(324, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(367, 23);
            txtName.TabIndex = 6;
            // 
            // frmTruyVanLichSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 644);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(dgvDS);
            Controls.Add(txtName);
            Name = "frmTruyVanLichSu";
            Text = "frmTruyVanLichSu";
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTim;
        private DataGridView dgvDS;
        private TextBox txtName;
    }
}