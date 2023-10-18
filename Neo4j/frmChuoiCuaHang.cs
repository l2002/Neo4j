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
    public partial class frmChuoiCuaHang : Form
    {
        public frmChuoiCuaHang()
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
                IResultCursor cursor = await session.RunAsync("MATCH (n:Store) RETURN DISTINCT n.address");
                await foreach (var result in cursor)
                {
                    cboAddress.Items.Add(result["n.address"].ToString());
                    cboAddress.SelectedIndex = 0;
                }
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();
        }
    

   
        public async Task loadDatataAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tên cửa hàng");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("SĐT");
            
            try
            {
                IResultCursor cursor = await session.RunAsync(@"MATCH (s:Store) WHERE s.address='" + cboAddress.SelectedItem + "' RETURN s.id,s.name,s.address,s.phone");
                await foreach (var result in cursor)
                {
                    var row = dt.NewRow();
                    row[0] = result[0].ToString();
                    row[1] = result[1].ToString();
                    row[2] = result[2].ToString();
                    row[3] = result[3].ToString();
                    dt.Rows.Add(row);
                }
                dgvDS.DataSource = dt;
                await cursor.ConsumeAsync();
            }

            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                await session.CloseAsync();
            }

            await driver.CloseAsync();
        }

        [Obsolete]
        public async Task inSertCHAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                IResultCursor cursor = await session.RunAsync(@"CREATE (s:Store {id:'" + txtId.Text + "',name: '" + txtName.Text + "',address:'" + txtDiaChi.Text + "',phone:'" + txtSĐT.Text + "'})");
                MessageBox.Show("Đã thêm!");
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
        public async Task xoaCHAsync()
        {
            IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "123456789"));
            IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                txtName.Text = dgvDS.CurrentRow.Cells[1].Value.ToString();
                IResultCursor cursor = await session.RunAsync(@"MATCH (n:Store{name:'" + txtName.Text + "'}) DETACH DELETE n");
                MessageBox.Show("Xóa thành công!");
                _ = loadDatataAsync();
                await cursor.ConsumeAsync();
            }
            finally
            {
                await session.CloseAsync();
            }
            await driver.CloseAsync();

        }
        private void frmChuoiCuaHang_Load(object sender, EventArgs e)
        {
        }

        private void cboAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = loadDatataAsync();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtName.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSĐT.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                _ = inSertCHAsync();
                txtId.Text = null;
                txtName.Text = null;
                txtDiaChi.Text = null;
                txtSĐT.Text = null;

                txtId.Enabled = false;
                txtName.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSĐT.Enabled = false;

                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSĐT.Enabled = true;

            cboAddress.SelectedIndex = 0;

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            cboAddress.Items.Clear();
            _ = loadComboboxAsync();
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Confirmation", MessageBoxButtons.YesNo);

            // Check the result of the message box.
            if (result == DialogResult.Yes)
            {
                _ = xoaCHAsync();
            }
            else
            {
                return;
            }
        }

        private void dgvDS_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDS.Rows.Count > 0)
            {
                txtId.Text = dgvDS.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvDS.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDS.CurrentRow.Cells[2].Value.ToString();
                txtSĐT.Text = dgvDS.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                return;
            }
        }
    }
}
