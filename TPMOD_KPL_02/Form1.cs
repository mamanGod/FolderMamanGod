namespace TPMOD_KPL_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            label1.Text = "Haloo " + inputText;
        }
    }
}