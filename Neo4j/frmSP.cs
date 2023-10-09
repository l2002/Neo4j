using Neo4j.Driver;
using System;
using System.Collections;
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
        public async Task taoLienKetAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            try
            {
                IResultCursor cursor = await session.RunAsync(@"match(p:Product),(t:Type) where p.name='" + cboSP.SelectedItem + "' and t.name='" + cboType.SelectedItem + "' create (p)-[r:TYPE]->(t) return p,t;");
                MessageBox.Show("Liên kết thành công!");
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
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Số lượng tồn");
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product)-[r:SOLD_AT]->(s:Store) WHERE  s.name = '" + cboLienKet.SelectedItem + "' RETURN p.id,p.name,p.price,p.quantity");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
                    row[3] = result[3].ToString();
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
        }

        private void btnTaoLienKet_Click(object sender, EventArgs e)
        {
            _ = taoLienKetAsync();
        }

        private void cboLienKet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
