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
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(321, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 23);
            txtName.TabIndex = 0;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(12, 158);
            dgvDS.Name = "dgvDS";
            dgvDS.RowTemplate.Height = 25;
            dgvDS.Size = new Size(999, 443);
            dgvDS.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(694, 76);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 26);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // frmTruyVanHD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 613);
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
    }
}