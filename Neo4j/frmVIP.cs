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

namespace Neo4j
{
    public partial class frmVIP : Form
    {
        public frmVIP()
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
                await cursor.ConsumeAsync();
            }
            finally
            {

                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }
        [Obsolete]
        public async Task timAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            if (txtKQ.Text == "")
            {
                try
                {
                    IResultCursor cursor = await session.RunAsync(@"MATCH (s:Store)-[v:hasVIP]->(c:Customer) WHERE  s.name = '" + cboStore.SelectedItem + "' RETURN c.name");
                    await foreach (var result in cursor)
                    {
                        lbl2.Text = "Danh sách khách hàng VIP tại chuỗi " + cboStore.SelectedItem;
                        txtKQ.Text += result["c.name"].ToString() + ", ";
                    }

                    await cursor.ConsumeAsync();
                }
                finally
                {

                    await session.CloseAsync();
                }
                await driver.CloseAsync();
            }
            else
            {
                txtKQ.Text = "";
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            _ = timAsync();
        }
    }
}