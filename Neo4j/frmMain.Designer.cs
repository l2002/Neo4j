namespace Neo4j
{
    partial class frmMain
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
            btnTruyVan1 = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(20, 102);
            label1.Name = "label1";
            label1.Size = new Size(1110, 30);
            label1.TabIndex = 5;
            label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH HÀNG VÀ ĐỊA CHỈ TƯƠNG ỨNG CỦA CHUỖI CỬA HÀNG THỰC PHẨM ORGANIC";
            // 
            // btnTruyVan1
            // 
            btnTruyVan1.BackColor = Color.FromArgb(255, 128, 128);
            btnTruyVan1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTruyVan1.ForeColor = Color.FromArgb(0, 0, 192);
            btnTruyVan1.Location = new Point(324, 291);
            btnTruyVan1.Name = "btnTruyVan1";
            btnTruyVan1.Size = new Size(533, 58);
            btnTruyVan1.TabIndex = 6;
            btnTruyVan1.Text = "Truy vấn danh sách khách hàng theo chuỗi cửa hàng";
            btnTruyVan1.UseVisualStyleBackColor = false;
            btnTruyVan1.Click += btnTruyVan1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(324, 176);
            button1.Name = "button1";
            button1.Size = new Size(533, 58);
            button1.TabIndex = 7;
            button1.Text = "Truy vấn danh sách khách hàng VIP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1153, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(60, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem
            // 
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Name = "danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem";
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Size = new Size(296, 22);
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Text = "Danh sách sản phẩm theo chuỗi cửa hàng";
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Click += danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1153, 632);
            Controls.Add(button1);
            Controls.Add(btnTruyVan1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTruyVan1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem;
    }
}