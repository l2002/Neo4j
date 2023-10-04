namespace Neo4j
{
    partial class frmTruyVanTheoChuoiCuaHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboLienKet = new ComboBox();
            txtKQ = new TextBox();
            btnTim = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cboLienKet
            // 
            cboLienKet.FormattingEnabled = true;
            cboLienKet.Location = new Point(155, 103);
            cboLienKet.Name = "cboLienKet";
            cboLienKet.Size = new Size(417, 23);
            cboLienKet.TabIndex = 1;
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKQ.Location = new Point(155, 196);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(536, 247);
            txtKQ.TabIndex = 2;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(602, 103);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 47);
            label1.Name = "label1";
            label1.Size = new Size(487, 25);
            label1.TabIndex = 4;
            label1.Text = "DANH SÁCH KHÁCH HÀNG THEO CHUỖI CỬA HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 103);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 5;
            label2.Text = "Chọn chuỗi cửa hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 166);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 6;
            label3.Text = "Danh sách khách hàng:";
            // 
            // frmTruyVanTheoChuoiCuaHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 531);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(txtKQ);
            Controls.Add(cboLienKet);
            Name = "frmTruyVanTheoChuoiCuaHang";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboLienKet;
        private TextBox txtKQ;
        private Button btnTim;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}