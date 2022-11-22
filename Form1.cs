namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var amount = textBox1.Text;
            label3.Text = Logic.ConvertCost(amount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sentence = textBox2.Text;
            label4.Text = Logic.PercentWordInSentece(sentence);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}