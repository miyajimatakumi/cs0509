namespace cs0509
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //“¯Šúˆ—@Messegebox.Show‚Í“¯ŠúŠÖ”
            MessageBox.Show("Hello");

            buttonproperty.Text = "‰Ÿ‚³‚ê‚½";
            buttonproperty.Left = 0;
            buttonproperty.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Left = button1.Left - 10;
            button1.Top = button1.Top - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
        }
    }
}
