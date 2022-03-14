namespace TipCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculateTip
        }//endtextBox1_TextChanged

        private void btnCalculateTip_Click(object sender, EventArgs e)
        {
            calculateTip();
        }//btnCalculateTip_Click

        private void butClear_Click(object sender, EventArgs e)
        {
            txtTotalAmount.Text = "";
            txtTipPercentage.Text = "";
            lblTipAmount.Text = "Tip Amount";
        }//end btnClear_Click

        private void calculateTip()
        {
            //MessageBox.Show("I was clicked");
            float totalAmount = float.Parse(txtTotalAmount.Text);
            float tipPercentage = float.Parse(txtTipPercentage.Text) / 100;

            float tip = totalAmount * tipPercentage;

            lblTipAmount.Text = tip.ToString("C");
        }//end calculateTip


    }//end class
}//end namespace