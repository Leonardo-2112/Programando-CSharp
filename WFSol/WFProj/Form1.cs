namespace WFProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você digitou o nome:  " + txtNome.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            txtAdicao.Text = (n1 + n2).ToString();
            txtSubtracao.Text = (n1 - n2).ToString();
            txtMultiplicacao.Text = (n1 * n2).ToString();
            txtDivisao.Text = (n1 / n2).ToString();
            if(n1 >= n2)
            {
                txtMaior.Text = n1.ToString();
                txtMenor.Text = n2.ToString();
            }
            else
            {
                txtMaior.Text = n2.ToString();
                txtMenor.Text = n1.ToString();
            }
        }
    }
}
