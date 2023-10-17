namespace Neo4j
{
    partial class frmTruyVanHD
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
            txtName = new TextBox();
            dgvDS = new DataGridView();
            btnTim = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(324, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(352, 23);
            txtName.TabIndex = 0;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 167);
            dgvDS.Name = "dgvDS";
            dgvDS.RowTemplate.Height = 25;
            dgvDS.Size = new Size(999, 434);
            dgvDS.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(697, 89);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 26);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 92);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 3;
            label1.Text = "Nhập tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(364, 9);
            label2.Name = "label2";
            label2.Size = new Size(277, 50);
            label2.TabIndex = 4;
            label2.Text = "TÌM HÓA ĐƠN";
            // 
            // frmTruyVanHD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 613);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(dgvDS);
            Controls.Add(txtName);
            Name = "frmTruyVanHD";
            Text = "frmTruyVanHD";
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private DataGridView dgvDS;
        private Button btnTim;
        private Label label1;
        private Label label2;
    }
}