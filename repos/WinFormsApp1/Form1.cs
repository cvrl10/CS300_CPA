namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String data = cboPresident.GetItemText(cboPresident.SelectedItem);
            //richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font("Arial", 18);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = data+"\n";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (rdoSmall.Checked)
                MessageBox.Show("You choose a small");
            else if (rdoMedium.Checked)
                MessageBox.Show("You choose a medium");
            else if (rdoLarge.Checked)
                MessageBox.Show("You choose a large");
            */
            richTextBox1.SelectionBullet = true;
            if (ckbDesignBack.Checked)
                richTextBox1.SelectedText = "Logo on Front\n";
            if (ckbPrintedTee.Checked)
                richTextBox1.Text += "Logo on Front\n";
            if (ckbDesignBack.Checked)
                richTextBox1.Text += "Design on Back\n";
            richTextBox1.SelectionBullet = false;

        }

        private void ckbPrintedTee_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbPrintedTee.Checked)
                MessageBox.Show("You are removing the logo from the shirt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copySelected();
        }

        private void copySelected()
        {
            MessageBox.Show("You choose to copy an item");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                copySelected();
            }
            if (e.Control && e.KeyCode == Keys.V)
                pasteSelected();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void pasteSelected()
        {
            MessageBox.Show("You choose to paste an item");
        }
    }
}