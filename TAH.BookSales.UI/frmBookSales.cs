namespace TAH.BookSales.UI
{
    public partial class frmBookSales : Form
    {
        public frmBookSales()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Checks if the text boxes are empty
            if (string.IsNullOrWhiteSpace(txtTotalSale.Text) || string.IsNullOrWhiteSpace(txtDiscountApplied.Text))
            {
                MessageBox.Show("Please enter values for both of the fields.");
                return;
            }

            //Checks if both the text bpxes contain valid numeric values
            if (!float.TryParse(txtTotalSale.Text, out float totalSale) || !float.TryParse(txtDiscountApplied.Text, out float discountApplied))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            //Checks if the discount percentage is between 0 and 100
            if (discountApplied < 0 || discountApplied > 100)
            {
                MessageBox.Show("Please enter a percentage between 0 and 100.");
                return;
            }

            //Checks if the sale amount is 0 or less
            if (totalSale <= 0)
            {
                MessageBox.Show("Please enter a sale amount greater than 0.");
                return;
            }

            //Makes variables from the text in the text boxes
            totalSale = float.Parse(txtTotalSale.Text);
            discountApplied = float.Parse(txtDiscountApplied.Text);

            //Converts the numbers in the text boxes to 2 decimals
            txtTotalSale.Text = totalSale.ToString("F2");
            txtDiscountApplied.Text = discountApplied.ToString("F2");

            //Calculates the final sale amount and displays it on the label
            float finalSaleAmount = totalSale * (1 - (discountApplied / 100));
            lblFinalSaleAmt.Text = finalSaleAmount.ToString("C2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears text boxes and the label
            txtDiscountApplied.Text = "";
            txtTotalSale.Text = "";
            lblFinalSaleAmt.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void txtTotalSale_TextChanged(object sender, EventArgs e)
        {
            //Clears the label
            lblFinalSaleAmt.Text = "";
        }

        private void txtDiscountApplied_TextChanged(object sender, EventArgs e)
        {
            //Clears the label
            lblFinalSaleAmt.Text = "";
        }
    }
}
