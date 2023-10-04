using Neo4j.Driver;

namespace Neo4j
{
    public partial class frmTruyVanTheoChuoiCuaHang : Form
    {




        [Obsolete]
        public frmTruyVanTheoChuoiCuaHang()
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
        public async Task timAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            if (txtKQ.Text == "")
            {
                try
                {
                    IResultCursor cursor = await session.RunAsync(@"MATCH (c:Customer)-[r:VISITED]->(s:Store) WHERE s.name = '" + cboLienKet.SelectedItem + "' RETURN c.name");
                    await foreach (var result in cursor)
                    {
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