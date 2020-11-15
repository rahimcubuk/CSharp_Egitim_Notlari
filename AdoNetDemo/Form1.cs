using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class ProductManager : Form
    {
        ProductDal _productDal = new ProductDal();
        public ProductManager()
        {
            InitializeComponent();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txtInsertName.Text,
                CategoryId = cmbInsertCategory.SelectedIndex,
                UnitPrice = Convert.ToDecimal(txtInsertPrice.Text),
                StockAmount = Convert.ToInt32(txtInsertStock.Text),
                Status = chbInsertStatus.Checked,
                RegisterDate = DateTime.Now
            });

            LoadProducts();
            MessageBox.Show("Product Added!");
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            cmbUpdateCategory.SelectedIndex = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value);
            txtUpdatePrice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtUpdateStock.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            chbUpdateStatus.Checked = Convert.ToBoolean(dgwProducts.CurrentRow.Cells[5].Value);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtUpdateName.Text,
                CategoryId = Convert.ToInt32(cmbUpdateCategory.SelectedIndex),
                UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text),
                StockAmount = Convert.ToInt32(txtUpdateStock.Text),
                Status = Convert.ToBoolean(chbUpdateStatus.Checked),
                RegisterDate = DateTime.Now
            });
            LoadProducts();
            MessageBox.Show("Product Updated!!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Product Deleted!!");
        }
        //TEXT BOX EVENTS
        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUnitPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtInsertPrice.Text = "";
        }

        private void txtStock_MouseClick(object sender, MouseEventArgs e)
        {
            txtInsertStock.Text = "";
        }

        private void txtProductName_MouseClick(object sender, MouseEventArgs e)
        {
            txtInsertName.Text = "";
        }
    }
}
