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
            //���������@Messegebox.Show�͓����֐�
            MessageBox.Show("Hello");

            buttonproperty.Text = "�����ꂽ";
            buttonproperty.Left = 0;
            buttonproperty.Visible = true;
        }
    }
}
