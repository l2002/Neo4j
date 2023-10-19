using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTruyVan1_Click(object sender, EventArgs e)
        {
            frmTruyVanTheoChuoiCuaHang frm = new frmTruyVanTheoChuoiCuaHang();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVIP frm = new frmVIP();
            frm.Show();
        }

        private void danhSáchSảnPhẩmTheoChuỗiCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSP frm = new frmSP();
            frm.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
            frm.Show();
        }

        private void danhSáchKháchHàngVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVIP frm = new frmVIP();
            frm.Show();
        }

        private void danhSáchKháchHàngTheoChuôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTruyVanTheoChuoiCuaHang frm = new frmTruyVanTheoChuoiCuaHang();
            frm.Show();
        }

        private void quảnLýChuỗiCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuoiCuaHang frm = new frmChuoiCuaHang();
            frm.Show();
        }



        private void nhậpDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string directory = fileInfo.DirectoryName;
                    string strCmdLine = "/c cd C:\\Users\\ASUS\\.Neo4jDesktop\\relate-data\\dbmss\\dbms-682e0307-4d89-469f-b8bb-b02e9499b932\\bin&neo4j-admin database load --from-path=" + directory + " neo4j --overwrite-destination=true";
                    System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                    MessageBox.Show("Nhập dữ liệu thành công!");
                }
                catch (IOException)
                {
                }
            }
        }

        private void xuấtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = -1;
            SaveFileDialog oSaveFileDialog1 = new SaveFileDialog();
            DialogResult result = oSaveFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = oSaveFileDialog1.FileName;
                FileInfo fileInfo = new FileInfo(file);
                string directory = fileInfo.DirectoryName;
                string strCmdLine = "/c cd C:\\Users\\ASUS\\.Neo4jDesktop\\relate-data\\dbmss\\dbms-682e0307-4d89-469f-b8bb-b02e9499b932\\bin&neo4j-admin database dump --to-path="+directory+" neo4j";
                System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                MessageBox.Show("Xuất dữ liệu thành công!");
            }
        }
    }
}
