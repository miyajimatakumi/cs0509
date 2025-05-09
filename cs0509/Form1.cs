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
    }
}
