using Neo4j.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo4j
{
    public partial class frmSP : Form
    {
        public frmSP()
        {
            InitializeComponent();
            _ = loadComboboxAsync();
            _ = loadCboTypeAsync();
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
                    cboLienKet.Items.Add(result["n.name"].ToString());
                    cboLienKet.SelectedIndex = 0;
                }
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }

        [Obsolete]
        public async Task loadCboTypeAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));

            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            try
            {
                IResultCursor cursor = await session.RunAsync("MATCH (n:Type) RETURN n.name ");
                await foreach (var result in cursor)
                {
                    cboType.Items.Add(result["n.name"].ToString());
                    cboType.SelectedIndex = 0;
                }
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }

        [Obsolete]
        public async Task loadCboSPAsync()
        {
            cboSP.Items.Clear();
            cboSP.Text = string.Empty;
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product)-[r:SOLD_AT]->(s:Store) WHERE  s.name ='" + cboLienKet.SelectedItem + "'  RETURN p.name");
                await foreach (var result in cursor)
                {
                    cboSP.Items.Add(result["p.name"].ToString());
                    cboSP.SelectedIndex = 0;
                }
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }

        [Obsolete]
        public async Task checkLKAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH(p:Product{name:'" + cboSP.SelectedItem + "'}) RETURN  exists((p) - [:TYPE]->(: Type{ name: '" + cboType.SelectedItem + "'})) as kq");
                await foreach (var result in cursor)
                {
                    string kq = result["kq"].ToString();
                    if (kq == "True")
                    {
                        MessageBox.Show("Liên kết đã tồn tại!");
                        return;
                    }
                    else if (kq == "False")
                    {
                        IResultCursor cursor1 = await session.RunAsync(@"match(p:Product),(t:Type) where p.name='" + cboSP.SelectedItem + "' and t.name='" + cboType.SelectedItem + "' create (p)-[r:TYPE]->(t) return p,t;");
                        MessageBox.Show("Liên kết thành công!");
                        _ = loadLienKetSPAsync();
                        await cursor1.ConsumeAsync();
                    }
                }
                await cursor.ConsumeAsync();
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
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Ngày nhập");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Số lượng tồn");
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product)-[r:SOLD_AT]->(s:Store) WHERE  s.name = '" + cboLienKet.SelectedItem + "' RETURN p.id,p.name,p.import_date,p.price,p.quantity");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
                    row[3] = result[3].ToString();
                    row[4] = result[4].ToString();
                    dt.Rows.Add(row);
                }
                dgvSP.DataSource = dt;
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }

        [Obsolete]
        public async Task loadLienKetSPAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Thể loại");
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product)-[r:TYPE]->(t:Type) RETURN p.name,t.name");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    dt.Rows.Add(row);
                }
                dgvLienKet.DataSource = dt;
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }

        [Obsolete]
        public async Task inSertAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                IResultCursor cursor = await session.RunAsync(@"MERGE (p:Product {id: '" + txtId.Text + "', name: '" + txtName.Text + "', import_date: '" + txtDate.Text + "', price: '" + txtGia.Text + "', quantity: '" + txtSoLuong.Text + "'}) MERGE (s:Store {name: '" + cboLienKet.SelectedItem + "'}) MERGE(p) - [r:SOLD_AT]->(s) RETURN p");
                MessageBox.Show("Đã thêm " + txtName.Text + "vào chuỗi cửa hàng " + cboLienKet.SelectedItem + "");
                _ = loadDatataAsync();
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();

        }

        [Obsolete]
        public async Task deleteAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                txtName.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product{name:'" + txtName.Text + "'})-[r:SOLD_AT]->(s:Store{name:'" + cboLienKet.SelectedItem + "'}) DETACH delete p");
                MessageBox.Show("Đã xóa " + txtName.Text + " khỏi chuỗi cửa hàng " + cboLienKet.SelectedItem + "");
                _ = loadDatataAsync();
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();

        }


        [Obsolete]
        public async Task deleteLKAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                lblSP.Text = dgvLienKet.CurrentRow.Cells[0].Value.ToString();
                lblType.Text = dgvLienKet.CurrentRow.Cells[1].Value.ToString();
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product{name:'" + lblSP.Text + "'})-[r:TYPE]->(t:Type{name:'" + lblType.Text + "'}) DETACH DELETE r");
                MessageBox.Show("Đã xóa!");
                _ = loadLienKetSPAsync();
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();

        }

        private void cboLienKet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ = loadDatataAsync();
            _ = loadCboSPAsync();
            _ = loadLienKetSPAsync();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtDate.Enabled = true;
            txtGia.Enabled = true;
            txtSoLuong.Enabled = true;
            cboSP.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _ = inSertAsync();
            txtId.Text = null;
            txtName.Text = null;
            txtDate.Text = null;
            txtGia.Text = null;
            txtSoLuong.Text = null;
            cboSP.Text = null;
            btnThem.Enabled = true;

            btnLuu.Enabled = false;
        }

        private void btnTaoLienKet_Click(object sender, EventArgs e)
        {
            _ = checkLKAsync();
        }

        private void cboLienKet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Confirmation", MessageBoxButtons.YesNo);

            // Check the result of the message box.
            if (result == DialogResult.Yes)
            {
                _ = deleteAsync();
            }
            else
            {
                return;
            }
        }

        private void dgvSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSP.Rows.Count > 0)
            {
                txtId.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
                txtDate.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
                txtGia.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
                txtSoLuong.Text = dgvSP.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void xoaLK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Confirmation", MessageBoxButtons.YesNo);

            // Check the result of the message box.
            if (result == DialogResult.Yes)
            {
                _ = deleteLKAsync();
            }
            else
            {
                return;
            }
        }

        private void dgvLienKet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLienKet.Rows.Count > 0)
            {
                lblSP.Text = dgvLienKet.CurrentRow.Cells[0].Value.ToString();
                lblType.Text = dgvLienKet.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                return;
            }
        }
    }
}
