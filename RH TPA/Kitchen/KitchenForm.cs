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
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
        }

        private void cRUDRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CookRequestForm crf = new CookRequestForm();
            crf.MdiParent = this;
            crf.Show();

        }

        private void cRUDIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngredientForm igf = new IngredientForm();
            igf.MdiParent = this;
            igf.Show();
        }

        private void cRUDRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecipeForm rf = new RecipeForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void sendPurchaseRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseRequestForm prf = new PurchaseRequestForm();
            prf.MdiParent = this;
            prf.Show();
        }
    }
}
