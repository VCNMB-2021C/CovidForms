
namespace Shop
{
    partial class frmShop2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblShopName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudProductCount = new System.Windows.Forms.NumericUpDown();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddShop = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlItems.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 15);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Shops Total:";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 15;
            this.lbOutput.Location = new System.Drawing.Point(12, 45);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(259, 244);
            this.lbOutput.TabIndex = 0;
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.btnAdd);
            this.pnlItems.Controls.Add(this.label7);
            this.pnlItems.Controls.Add(this.label6);
            this.pnlItems.Controls.Add(this.txtPrice);
            this.pnlItems.Controls.Add(this.txtProductName);
            this.pnlItems.Controls.Add(this.label5);
            this.pnlItems.Location = new System.Drawing.Point(1, 204);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(284, 142);
            this.pnlItems.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(202, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Product Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product Name:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(121, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 23);
            this.txtPrice.TabIndex = 11;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(121, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(146, 23);
            this.txtProductName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(56, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add New Products";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(196, 312);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 3;
            this.btnGetReport.Text = "Refresh";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGetReport);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblShopName);
            this.panel3.Controls.Add(this.lbOutput);
            this.panel3.Location = new System.Drawing.Point(409, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 347);
            this.panel3.TabIndex = 4;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShopName.Location = new System.Drawing.Point(12, 14);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(123, 28);
            this.lblShopName.TabIndex = 1;
            this.lblShopName.Text = "Shops name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Add Shop";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudProductCount
            // 
            this.nudProductCount.Location = new System.Drawing.Point(122, 126);
            this.nudProductCount.Name = "nudProductCount";
            this.nudProductCount.Size = new System.Drawing.Size(146, 23);
            this.nudProductCount.TabIndex = 6;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(122, 90);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(146, 23);
            this.txtCell.TabIndex = 5;
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(122, 53);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(146, 23);
            this.txtShopName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "How many products:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shops Cell Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shop\'s Name:";
            // 
            // lblAddShop
            // 
            this.lblAddShop.AutoSize = true;
            this.lblAddShop.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddShop.Location = new System.Drawing.Point(57, 14);
            this.lblAddShop.Name = "lblAddShop";
            this.lblAddShop.Size = new System.Drawing.Size(141, 28);
            this.lblAddShop.TabIndex = 0;
            this.lblAddShop.Text = "Add New shop";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlItems);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.nudProductCount);
            this.panel1.Controls.Add(this.txtCell);
            this.panel1.Controls.Add(this.txtShopName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAddShop);
            this.panel1.Location = new System.Drawing.Point(106, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 347);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Shop Generator 2.0";
            // 
            // frmShop2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShop2";
            this.Text = "Shop Generation 2.0";
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudProductCount;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddShop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
    }
}