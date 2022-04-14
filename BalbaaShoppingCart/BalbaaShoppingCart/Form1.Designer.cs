namespace BalbaaShoppingCart
{
    partial class frmShoppingCart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOrderForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderAdress = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMailingLabel = new System.Windows.Forms.TextBox();
            this.tabOrderForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrderForm
            // 
            this.tabOrderForm.Controls.Add(this.tabPage1);
            this.tabOrderForm.Controls.Add(this.tabPage2);
            this.tabOrderForm.Controls.Add(this.tabPage3);
            this.tabOrderForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabOrderForm.Location = new System.Drawing.Point(6, 7);
            this.tabOrderForm.Name = "tabOrderForm";
            this.tabOrderForm.SelectedIndex = 2;
            this.tabOrderForm.Size = new System.Drawing.Size(391, 303);
            this.tabOrderForm.TabIndex = 0;
            this.tabOrderForm.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.dudProducts);
            this.tabPage1.Controls.Add(this.lblItemsOrdered);
            this.tabPage1.Controls.Add(this.btnAddToOrder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtOrderAdress);
            this.tabPage1.Controls.Add(this.btnNewOrder);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Form";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dudProducts
            // 
            this.dudProducts.Location = new System.Drawing.Point(120, 116);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(120, 25);
            this.dudProducts.TabIndex = 7;
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsOrdered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsOrdered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemsOrdered.Location = new System.Drawing.Point(120, 189);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(120, 20);
            this.lblItemsOrdered.TabIndex = 4;
            this.lblItemsOrdered.Text = "Items Ordered: 0";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(129, 147);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(105, 23);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Adress";
            // 
            // txtOrderAdress
            // 
            this.txtOrderAdress.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrderAdress.Location = new System.Drawing.Point(23, 37);
            this.txtOrderAdress.Multiline = true;
            this.txtOrderAdress.Name = "txtOrderAdress";
            this.txtOrderAdress.Size = new System.Drawing.Size(331, 62);
            this.txtOrderAdress.TabIndex = 0;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(140, 219);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(82, 23);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.lblTotalCost);
            this.tabPage2.Controls.Add(this.lstProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Cart";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.Gold;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCost.Location = new System.Drawing.Point(41, 168);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(150, 26);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Cost";
            this.lblTotalCost.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 17;
            this.lstProducts.Location = new System.Drawing.Point(41, 14);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(307, 123);
            this.lstProducts.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtMailingLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(383, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailing Adress";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMailingLabel
            // 
            this.txtMailingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtMailingLabel.Enabled = false;
            this.txtMailingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMailingLabel.Location = new System.Drawing.Point(30, 31);
            this.txtMailingLabel.Multiline = true;
            this.txtMailingLabel.Name = "txtMailingLabel";
            this.txtMailingLabel.Size = new System.Drawing.Size(313, 188);
            this.txtMailingLabel.TabIndex = 0;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 322);
            this.Controls.Add(this.tabOrderForm);
            this.Name = "frmShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOrderForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrderForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderAdress;
        private System.Windows.Forms.DomainUpDown dudProducts;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtMailingLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewOrder;
    }
}

