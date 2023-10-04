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
            dgvSP.Rows.Clear();
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Số lượng tồn");
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (p:Product)-[r:SOLD_AT]->(s:Store) WHERE  s.name = '" + cboLienKet.SelectedItem + "' RETURN p.name,p.price,p.quantity");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
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
        private void btnXem_Click(object sender, EventArgs e)
        {
            _ = loadDatataAsync();
        }
    }
}
