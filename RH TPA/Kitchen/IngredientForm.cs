using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.Kitchen
{
    public partial class IngredientForm : Form
    {
        IngredientController ic = new IngredientController();
        public IngredientForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ic.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ingredientIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ingredientNameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ingredientStockTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ingredientMinimumStockTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ingredientPriceTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string ingredientName = ingredientNameTxt.Text;
            int ingredientStock = int.Parse(ingredientStockTxt.Text);
            int minimumStock = int.Parse(ingredientMinimumStockTxt.Text);
            int price = int.Parse(ingredientPriceTxt.Text);
            ic.addData(ingredientName, ingredientStock, minimumStock, price);
            dataGridView1.DataSource = ic.loadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int ingredientId = int.Parse(ingredientIdLbl.Text);
            string ingredientName = ingredientNameTxt.Text;
            int ingredientStock = int.Parse(ingredientStockTxt.Text);
            int minimumStock = int.Parse(ingredientMinimumStockTxt.Text);
            int price = int.Parse(ingredientPriceTxt.Text);
            ic.updateData(ingredientId, ingredientName, ingredientStock, minimumStock, price);
            if(ingredientStock <= minimumStock)
            {
                MessageBox.Show(ingredientName +" reached minimum stock");
            }
            dataGridView1.DataSource = ic.loadData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int ingredientId = int.Parse(ingredientIdLbl.Text);
            ic.deleteData(ingredientId);
            dataGridView1.DataSource = ic.loadData();
        }
    }
}
