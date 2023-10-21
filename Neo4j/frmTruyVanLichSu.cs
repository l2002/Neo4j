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
    public partial class frmTruyVanLichSu : Form
    {
        public frmTruyVanLichSu()
        {
            InitializeComponent();
        }

        [Obsolete]
        public async Task loadDatataAsync()
        {
            string spmua="";
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            List<object> myList = new List<object>();
            dt.Columns.Add("Mã HĐ");
            dt.Columns.Add("Tên khách");
            dt.Columns.Add("Sản phẩm");
            dt.Columns.Add("Ngày mua");
            dt.Columns.Add("Tổng tiền");

            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (c:Customer{name:'"+txtName.Text+"'})-[r:PURCHASED]->(h:History) RETURN h.order_id,h.customer,h.product_list,h.purchase_date,h.total_value");
                await foreach (var result in cursor)
                {
                    List<object> productList = (List<object>)result[2];
                             
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    foreach (string item in productList)
                    {
                        if(spmua == "")
                        {
                            spmua = item;
                        }    
                        else
                        {
                            spmua = spmua + "," + item;
                        }    
                        
                    }
                    row[2] = spmua;
                    row[3] = result[3].ToString();                  
                    row[4] = result[4].ToString();
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
