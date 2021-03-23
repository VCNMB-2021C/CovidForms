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
            lblShopName.Text= "Shops name:"+i.getShopName();
            lblTotal.Text = "The total is :"+i.getTotal();
            txtProductName.Focus();
            txtProductName.TabIndex = 0;
            txtPrice.TabIndex = 1;
            btnAdd.TabIndex = 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

               if(i.addToArray(txtProductName.Text, Convert.ToDouble(txtPrice.Text))==false)
                {
                    MessageBox.Show("Your product list is full");
                    pnlItems.Visible = false;
                }
                ItemsList();

            txtProductName.Clear();
            txtPrice.Clear();
            txtProductName.Focus();
            txtProductName.TabIndex=0;
            txtPrice.TabIndex = 1;
            btnAdd.TabIndex = 2;



        }

        private void ItemsList()
        {
            lbOutput.Items.Clear();
            string strTemp = String.Format("{0} ,\t{1}", "Product Name", "Price");
            lbOutput.Items.Add(strTemp);
            for (int x = 0; x < i.getcounter(); x++)
                {
                        strTemp= String.Format("{0} ,\t \t R{1}", i.getProduct(x), i.getPrice(x));
                        lbOutput.Items.Add(strTemp);
                }
                lblTotal.Text = "The total is :" + i.getTotal();

        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            ItemsList();
        }
    }
    }
