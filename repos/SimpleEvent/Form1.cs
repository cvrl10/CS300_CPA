namespace SimpleEvent
{
    public partial class SimpleEvent : Form
    {
        public SimpleEvent()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}