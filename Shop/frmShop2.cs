using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop
{
    public partial class frmShop2 : Form
    {
        items i = new items();
        public frmShop2()
        {
            InitializeComponent();
            pnlItems.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            i.setShopName(txtShopName.Text);
            i.setCellNumber(txtCell.Text);
            i.setArray(Convert.ToInt32(nudProductCount.Value.ToString()));
            pnlItems.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i.getCanAddItem())
            {
                i.setProduct(txtProductName.Text);
                i.setPrice(Convert.ToDouble(txtPrice.Text));
            }
            else
            {
                pnlItems.Visible = false;
                MessageBox.Show("Your product list is full");
            }


        }
    }
}
