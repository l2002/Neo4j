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
using System.Xml.Linq;

namespace Neo4j
{
    public partial class frmTruyVanTheoTG : Form
    {
        public frmTruyVanTheoTG()
        {
            InitializeComponent();
        }

        public async Task loadDatataAsync()
        {
            string spmua = "";
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đơn hàng");
            dt.Columns.Add("Tên khách");
            dt.Columns.Add("Ngày mua");

            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (o:Order)-[:CREATED_BY]->(c:Customer) WHERE o.placed_date >= '" + txtStart.Text + "' AND o.placed_date <= '" + txtEnd.Text + "' RETURN o.id,c.name, o.placed_date");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
                    dt.Rows.Add(row);
                }
                dgvDS.DataSource = dt;
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            _ = loadDatataAsync();
        }
    }
}
