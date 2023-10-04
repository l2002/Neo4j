using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
