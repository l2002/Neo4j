namespace Neo4j
{
    partial class frmKHVip
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
            label1 = new Label();
            dgvKH = new DataGridView();
            lblStore = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 70);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 19;
            label3.Text = "Danh sách khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 25);
            label1.TabIndex = 18;
            label1.Text = "DANH SÁCH KHÁCH HÀNG VIP TẠI";
            // 
            // dgvKH
            // 
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(46, 99);
            dgvKH.Name = "dgvKH";
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(918, 467);
            dgvKH.TabIndex = 15;
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStore.ForeColor = Color.Red;
            lblStore.Location = new Point(509, 9);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(34, 25);
            lblStore.TabIndex = 18;
            lblStore.Text = "lbl";
            // 
            // frmKHVip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 593);
            Controls.Add(label3);
            Controls.Add(lblStore);
            Controls.Add(label1);
            Controls.Add(dgvKH);
            Name = "frmKHVip";
            Text = "frmKHVip";
            Load += frmKHVip_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private DataGridView dgvKH;
        private Label lblStore;
    }
}