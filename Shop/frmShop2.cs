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
    }
}
