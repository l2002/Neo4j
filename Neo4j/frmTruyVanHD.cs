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
    public partial class frmTruyVanHD : Form
    {
        public frmTruyVanHD()
        {
            InitializeComponent();
        }

        [Obsolete]
        public async Task loadDatataAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên khách");
            dt.Columns.Add("Ngày đặt");
            dt.Columns.Add("Ngày giao");
            dt.Columns.Add("Địa chỉ giao hàng");
            dt.Columns.Add("Trạng thái");
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (o:Order)-[r:CREATED_BY]->(c:Customer{name:'"+txtName.Text+"'}) RETURN o.id,o.customer,o.placed_date,o.shipped_date,o.shipping_address,o.status");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
                    row[3] = result[3].ToString();
                    row[4] = result[4].ToString();
                    row[5] = result[5].ToString();
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
