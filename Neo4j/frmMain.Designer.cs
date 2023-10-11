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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýChuỗiCửaHàngToolStripMenuItem = new ToolStripMenuItem();
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            truyVấnToolStripMenuItem = new ToolStripMenuItem();
            danhSáchKháchHàngVIPToolStripMenuItem = new ToolStripMenuItem();
            danhSáchKháchHàngTheoChuôToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 41);
            label1.Name = "label1";
            label1.Size = new Size(1134, 25);
            label1.TabIndex = 5;
            label1.Text = "PHẦN MỀM QUẢN LÝ KHÁCH HÀNG VÀ ĐỊA CHỈ TƯƠNG ỨNG CỦA CHUỖI CỬA HÀNG THỰC PHẨM ORGANIC";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, truyVấnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1135, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýChuỗiCửaHàngToolStripMenuItem, danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(69, 20);
            quảnLýToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýChuỗiCửaHàngToolStripMenuItem
            // 
            quảnLýChuỗiCửaHàngToolStripMenuItem.Name = "quảnLýChuỗiCửaHàngToolStripMenuItem";
            quảnLýChuỗiCửaHàngToolStripMenuItem.Size = new Size(200, 22);
            quảnLýChuỗiCửaHàngToolStripMenuItem.Text = "Quản lý chuỗi cửa hàng";
            quảnLýChuỗiCửaHàngToolStripMenuItem.Click += quảnLýChuỗiCửaHàngToolStripMenuItem_Click;
            // 
            // danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem
            // 
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Name = "danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem";
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Size = new Size(200, 22);
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Text = "Quản lý sản phẩm";
            danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem.Click += danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(200, 22);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // truyVấnToolStripMenuItem
            // 
            truyVấnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchKháchHàngVIPToolStripMenuItem, danhSáchKháchHàngTheoChuôToolStripMenuItem });
            truyVấnToolStripMenuItem.Name = "truyVấnToolStripMenuItem";
            truyVấnToolStripMenuItem.Size = new Size(64, 20);
            truyVấnToolStripMenuItem.Text = "Truy vấn";
            // 
            // danhSáchKháchHàngVIPToolStripMenuItem
            // 
            danhSáchKháchHàngVIPToolStripMenuItem.Name = "danhSáchKháchHàngVIPToolStripMenuItem";
            danhSáchKháchHàngVIPToolStripMenuItem.Size = new Size(306, 22);
            danhSáchKháchHàngVIPToolStripMenuItem.Text = "Danh sách khách hàng VIP";
            danhSáchKháchHàngVIPToolStripMenuItem.Click += danhSáchKháchHàngVIPToolStripMenuItem_Click;
            // 
            // danhSáchKháchHàngTheoChuôToolStripMenuItem
            // 
            danhSáchKháchHàngTheoChuôToolStripMenuItem.Name = "danhSáchKháchHàngTheoChuôToolStripMenuItem";
            danhSáchKháchHàngTheoChuôToolStripMenuItem.Size = new Size(306, 22);
            danhSáchKháchHàngTheoChuôToolStripMenuItem.Text = "Danh sách khách hàng theo chuỗi cửa hàng";
            danhSáchKháchHàngTheoChuôToolStripMenuItem.Click += danhSáchKháchHàngTheoChuôToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1135, 714);
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem truyVấnToolStripMenuItem;
        private ToolStripMenuItem danhSáchKháchHàngVIPToolStripMenuItem;
        private ToolStripMenuItem danhSáchKháchHàngTheoChuôToolStripMenuItem;
        private ToolStripMenuItem quảnLýChuỗiCửaHàngToolStripMenuItem;
    }
}