using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Neo4j
{
    public partial class frmQLKH : Form
    {
        public frmQLKH()
        {
            InitializeComponent();
            _ = loadComboboxAsync();
        }

        [Obsolete]
        public async Task loadComboboxAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));

            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            try
            {
                IResultCursor cursor = await session.RunAsync("MATCH (n:Store) RETURN n.name");
                await foreach (var result in cursor)
                {
                    cboStore.Items.Add(result["n.name"].ToString());
                    cboStore.SelectedIndex = 0;
                }
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }
        [Obsolete]
        public async Task loadDatataAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên khách");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Email");
            dt.Columns.Add("SĐT");
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (c:Customer)-[VISITED]->(s:Store) WHERE s.name='" + cboStore.SelectedItem + "' RETURN c.id,c.name,c.address,c.gender,c.birthday,c.email,c.phone");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
                    row[3] = result[3].ToString();
                    row[4] = result[4].ToString();
                    row[5] = result[5].ToString();
                    row[6] = result[6].ToString();
                    dt.Rows.Add(row);
                }
                dgvKH.DataSource = dt;
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = loadDatataAsync();
        }

        private void btnVIP_Click_1(object sender, EventArgs e)
        {
            string data = cboStore.SelectedItem.ToString();

            // Truyền dữ liệu cho form thứ hai
            frmKHVip form2 = new frmKHVip();
            form2.Data = data;
            form2.Show();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKH.Rows.Count > 0)
            {
                txtId.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();

                if
                    (dgvKH.CurrentRow.Cells[3].Value.ToString() == "Nam")
                    cboGender.SelectedIndex = 0;
                else
                    cboGender.SelectedIndex = 1;

                txtNgaySinh.Text = dgvKH.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvKH.CurrentRow.Cells[5].Value.ToString();
                txtSĐT.Text = dgvKH.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                return;
            }
        }

        [Obsolete]
        public async Task inSertKHAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                IResultCursor cursor = await session.RunAsync(@"MERGE (c:Customer {id: '" + txtId.Text + "', name: '" + txtName.Text + "', address: '" + txtDiaChi.Text + "', gender: '" + cboGender.SelectedItem + "', birthday: '" + txtNgaySinh.Text + "', email: '" + txtEmail.Text + "', phone: '" + txtSĐT.Text + "'}) MERGE (s:Store {name: '" + cboStore.SelectedItem + "'}) MERGE(c) - [r:VISITED]->(s) RETURN c");
                MessageBox.Show("Đã thêm " + txtName.Text + "vào chuỗi cửa hàng " + cboStore.SelectedItem + "");
                await cursor.ConsumeAsync();
                _ = loadDatataAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtSĐT.Enabled = true;
            cboGender.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtId.Text.Equals("")|| txtName.Text.Equals("") || txtDiaChi.Text.Equals("") || txtNgaySinh.Text.Equals("") || txtEmail.Text.Equals("") || txtSĐT.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                _ = inSertKHAsync();
                txtId.Text = null;
                txtName.Text = null;
                txtDiaChi.Text = null;
                txtNgaySinh.Text = null;
                txtEmail.Text = null;
                txtSĐT.Text = null;
                cboGender.Text = null;

                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }

        }


        [Obsolete]
        public async Task taoVIPAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            try
            {
                txtName.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
                IResultCursor cursor = await session.RunAsync(@"MATCH(s:Store{name:'" + cboStore.SelectedItem + "'}) RETURN  exists((s) - [:hasVIP]->(: Customer{ name: '" + txtName.Text + "'})) as kq");
                await foreach (var result in cursor)
                {
                    string kq = result["kq"].ToString();
                    if (kq == "True")
                    {
                        MessageBox.Show(txtName.Text + " hiện đã là VIP!");
                        return;
                    }
                    else
                    {
                        IResultCursor cursor1 = await session.RunAsync(@"match(s:Store),(c:Customer) where s.name='" + cboStore.SelectedItem + "' and c.name='" + txtName.Text + "' create (s)-[r:hasVIP]->(c) return s,c;");
                        MessageBox.Show("Đã thêm " + txtName.Text + "vào danh sách khach hàng VIP của cửa hàng!");
                        await cursor1.ConsumeAsync();

                    }
                    await cursor.ConsumeAsync();
                }
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }
        private void btnTaoLKVip_Click(object sender, EventArgs e)
        {
            _ = taoVIPAsync();
        }

        private void btnTraCuuHD_Click(object sender, EventArgs e)
        {
            frmTruyVanHD frm = new frmTruyVanHD();
            frm.Show();
        }

        private void btnTraCuuLS_Click(object sender, EventArgs e)
        {
            frmTruyVanLichSu frm = new frmTruyVanLichSu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTruyVanTheoTG frm = new frmTruyVanTheoTG();
            frm.Show();
        }
    }
}
