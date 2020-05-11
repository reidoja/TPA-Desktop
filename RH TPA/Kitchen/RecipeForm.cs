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
    public partial class RecipeForm : Form
    {
        RecipeController rc = new RecipeController();

        string dishName = "";
        string foodName = "";

        public RecipeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = rc.loadDishRecipe(dishName);
            dataGridView2.DataSource = rc.loadFoodRecipe(foodName);
            dishNameCombo.DataSource = rc.loadDishName();
            foodNameCombo.DataSource = rc.loadFoodName();
            ingredientCombo.DataSource = rc.loadIngredient();
            ingredientCombo1.DataSource = rc.loadIngredient();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dishNameCombo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ingredientCombo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dishQuantityTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodNameCombo.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ingredientCombo1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            foodQuantityTxt.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dishName = dishNameCombo.Text;
            string ingredientName = ingredientCombo.Text;
            int quantity = int.Parse(dishQuantityTxt.Text);
            rc.addDishRecipe(dishName, ingredientName, quantity);
            dataGridView1.DataSource = rc.loadDishRecipe(dishName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dishName = dishNameCombo.Text;
            string ingredientName = ingredientCombo.Text;
            int quantity = int.Parse(dishQuantityTxt.Text);
            rc.updateDishRecipe(dishName, ingredientName, quantity);
            dataGridView1.DataSource = rc.loadDishRecipe(dishName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dishName = dishNameCombo.Text;
            string ingredientName = ingredientCombo.Text;
            rc.deleteDishRecipe(dishName, ingredientName);
            dataGridView1.DataSource = rc.loadDishRecipe(dishName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string foodName = foodNameCombo.Text;
            string ingredientName = ingredientCombo1.Text;
            int quantity = int.Parse(foodQuantityTxt.Text);
            rc.addFoodRecipe(foodName, ingredientName, quantity);
            dataGridView2.DataSource = rc.loadFoodRecipe(foodName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string foodName = foodNameCombo.Text;
            string ingredientName = ingredientCombo1.Text;
            int quantity = int.Parse(foodQuantityTxt.Text);
            rc.updateFoodRecipe(foodName, ingredientName, quantity);
            dataGridView2.DataSource = rc.loadFoodRecipe(foodName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string foodName = foodNameCombo.Text;
            string ingredientName = ingredientCombo1.Text;
            rc.deleteFoodRecipe(foodName, ingredientName);
            dataGridView2.DataSource = rc.loadFoodRecipe(foodName);
        }

        private void dishNameCombo_TextChanged(object sender, EventArgs e)
        {
            dishName = dishNameCombo.Text;
        }

        private void foodNameCombo_TextChanged(object sender, EventArgs e)
        {
            foodName = foodNameCombo.Text;
        }
    }
}
