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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Neo4j
{
    public partial class frmKHVip : Form
    {
        public string Data { get; set; }
        public frmKHVip()
        {
            InitializeComponent();
            _ = loadDatataAsync();
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
                lblStore.Text = Data;
                IResultCursor cursor = await session.RunAsync(@"MATCH (s:Store)-[v:isVIP]->(c:Customer) WHERE  s.name = '" + lblStore.Text + "' RETURN c.id,c.name,c.address,c.gender,c.birthday,c.email,c.phone");
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

        private void frmKHVip_Load(object sender, EventArgs e)
        {
            _=loadDatataAsync();
        }
    }
}
