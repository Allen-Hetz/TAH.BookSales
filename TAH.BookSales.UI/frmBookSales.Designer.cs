namespace TAH.BookSales.UI
{
    partial class frmBookSales
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
            txtTotalSale = new TextBox();
            txtDiscountApplied = new TextBox();
            lblFinalSaleAmt = new Label();
            lblTotalSale = new Label();
            lblDiscountApplied = new Label();
            lblFinalSaleLable = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtTotalSale
            // 
            txtTotalSale.BackColor = Color.White;
            txtTotalSale.Font = new Font("Segoe UI", 18F);
            txtTotalSale.Location = new Point(296, 73);
            txtTotalSale.Name = "txtTotalSale";
            txtTotalSale.Size = new Size(229, 39);
            txtTotalSale.TabIndex = 0;
            txtTotalSale.TextChanged += txtTotalSale_TextChanged;
            // 
            // txtDiscountApplied
            // 
            txtDiscountApplied.BackColor = Color.White;
            txtDiscountApplied.Font = new Font("Segoe UI", 18F);
            txtDiscountApplied.Location = new Point(296, 162);
            txtDiscountApplied.Name = "txtDiscountApplied";
            txtDiscountApplied.Size = new Size(229, 39);
            txtDiscountApplied.TabIndex = 1;
            txtDiscountApplied.TextChanged += txtDiscountApplied_TextChanged;
            // 
            // lblFinalSaleAmt
            // 
            lblFinalSaleAmt.BackColor = Color.White;
            lblFinalSaleAmt.BorderStyle = BorderStyle.Fixed3D;
            lblFinalSaleAmt.FlatStyle = FlatStyle.Popup;
            lblFinalSaleAmt.Font = new Font("Segoe UI", 18F);
            lblFinalSaleAmt.Location = new Point(296, 256);
            lblFinalSaleAmt.Name = "lblFinalSaleAmt";
            lblFinalSaleAmt.Size = new Size(229, 39);
            lblFinalSaleAmt.TabIndex = 2;
            lblFinalSaleAmt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalSale
            // 
            lblTotalSale.AutoSize = true;
            lblTotalSale.Font = new Font("Segoe UI", 18F);
            lblTotalSale.Location = new Point(47, 76);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(243, 32);
            lblTotalSale.TabIndex = 3;
            lblTotalSale.Text = "Total Sale Amount ($)";
            // 
            // lblDiscountApplied
            // 
            lblDiscountApplied.AutoSize = true;
            lblDiscountApplied.Font = new Font("Segoe UI", 18F);
            lblDiscountApplied.Location = new Point(52, 165);
            lblDiscountApplied.Name = "lblDiscountApplied";
            lblDiscountApplied.Size = new Size(238, 32);
            lblDiscountApplied.TabIndex = 4;
            lblDiscountApplied.Text = "Discount Applied (%)";
            // 
            // lblFinalSaleLable
            // 
            lblFinalSaleLable.AutoSize = true;
            lblFinalSaleLable.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalSaleLable.Location = new Point(69, 259);
            lblFinalSaleLable.Name = "lblFinalSaleLable";
            lblFinalSaleLable.Size = new Size(221, 32);
            lblFinalSaleLable.TabIndex = 5;
            lblFinalSaleLable.Text = "Final Sale Amount";
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.White;
            btnCalc.FlatStyle = FlatStyle.Popup;
            btnCalc.Font = new Font("Segoe UI", 18F);
            btnCalc.Location = new Point(207, 343);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(143, 47);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(444, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 47);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(645, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 47);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmBookSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lblFinalSaleLable);
            Controls.Add(lblDiscountApplied);
            Controls.Add(lblTotalSale);
            Controls.Add(lblFinalSaleAmt);
            Controls.Add(txtDiscountApplied);
            Controls.Add(txtTotalSale);
            Name = "frmBookSales";
            Text = "FVTC Book Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotalSale;
        private TextBox txtDiscountApplied;
        private Label lblFinalSaleAmt;
        private Label lblTotalSale;
        private Label lblDiscountApplied;
        private Label lblFinalSaleLable;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
    }
}
