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
            btnXem = new Button();
            cboLienKet = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            SuspendLayout();
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(12, 197);
            dgvSP.Name = "dgvSP";
            dgvSP.RowTemplate.Height = 25;
            dgvSP.Size = new Size(1007, 424);
            dgvSP.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 99);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Chọn chuỗi cửa hàng:";
            // 
            // btnXem
            // 
            btnXem.Location = new Point(767, 99);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(75, 23);
            btnXem.TabIndex = 7;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // cboLienKet
            // 
            cboLienKet.FormattingEnabled = true;
            cboLienKet.Location = new Point(320, 99);
            cboLienKet.Name = "cboLienKet";
            cboLienKet.Size = new Size(417, 23);
            cboLienKet.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(247, 26);
            label1.Name = "label1";
            label1.Size = new Size(547, 25);
            label1.TabIndex = 9;
            label1.Text = "QUẢN LÝ DANH SÁCH SẢN PHẨM THEO CHUỖI CỬA HÀNG";
            // 
            // frmSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 645);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnXem);
            Controls.Add(cboLienKet);
            Controls.Add(dgvSP);
            Name = "frmSP";
            Text = "frmSP";
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSP;
        private Label label2;
        private Button btnXem;
        private ComboBox cboLienKet;
        private Label label1;
    }
}