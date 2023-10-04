namespace Neo4j
{
    partial class frmVIP
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
            cboStore = new ComboBox();
            lbl1 = new Label();
            lbl2 = new Label();
            txtKQ = new TextBox();
            btnTim = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cboStore
            // 
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(219, 109);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(602, 23);
            cboStore.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(64, 112);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(124, 15);
            lbl1.TabIndex = 6;
            lbl1.Text = "Chọn chuỗi cửa hàng:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(64, 191);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(150, 15);
            lbl2.TabIndex = 8;
            lbl2.Text = "Danh sách khách hàng VIP:";
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKQ.Location = new Point(64, 229);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(907, 399);
            txtKQ.TabIndex = 7;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(858, 109);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(113, 26);
            btnTim.TabIndex = 9;
            btnTim.Text = "Truy Vấn";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 35);
            label1.Name = "label1";
            label1.Size = new Size(395, 25);
            label1.TabIndex = 10;
            label1.Text = "TRUY VẤN DANH SÁCH KHÁCH HÀNG VIP";
            // 
            // frmVIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 668);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(lbl2);
            Controls.Add(txtKQ);
            Controls.Add(lbl1);
            Controls.Add(cboStore);
            Name = "frmVIP";
            Text = "frmVIP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboStore;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtKQ;
        private Button btnTim;
        private Label label1;
    }
}