using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class MainForm : Form
    {
        ProductDal _productDal = new ProductDal();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetProducts();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txtInsertName.Text,
                CategoryId = Convert.ToInt16(cmbInsertCategory.SelectedIndex),
                UnitPrice = Convert.ToDecimal(txtInsertPrice.Text),
                StockAmount = Convert.ToInt16(txtInsertStock.Text),
                Status = Convert.ToBoolean(chbInsertStatus.Checked),
                RegisterDate = DateTime.Now
            });

            LoadProducts();
            MessageBox.Show("Product Added. :)");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtUpdateName.Text,
                CategoryId = Convert.ToInt16(cmbUpdateCategory.SelectedIndex),
                UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text),
                StockAmount = Convert.ToInt16(txtUpdateStock.Text),
                Status = Convert.ToBoolean(chbUpdateStatus.Checked),
                RegisterDate = DateTime.Now
            });
            LoadProducts();
            MessageBox.Show("Product Updated!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Product Deleted!!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            cmbUpdateCategory.SelectedIndex = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value);
            txtUpdatePrice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtUpdateStock.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            chbUpdateStatus.Checked = Convert.ToBoolean(dgwProducts.CurrentRow.Cells[5].Value);
        }
        /*********************************************************************************\
         * //Form Nesne Eventleri\\
        \*********************************************************************************/
        private void txtInsertPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtInsertStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtInsertName_MouseClick(object sender, MouseEventArgs e)
        {
            txtInsertName.Text = "";
        }

        private void txtInsertPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtInsertPrice.Text = "";
        }

        private void txtInsertStock_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtInsertStock.Text = "";
        }

        private void txtUpdatePrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdatePrice.Text = "";
        }
        
        private void txtUpdatePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUpdateStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUpdateStock_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdateStock.Text = "";
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetProducts(txtSearch.Text);
        }
        
    }
}
