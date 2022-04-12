namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(Sayi1.Text);
            double sayi2 = Convert.ToDouble(Sayi2.Text);

            double sonuc = sayi1 + sayi2;

            txtSonuc.Text = sonuc.ToString();  
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(Sayi1.Text);
            double sayi2 = Convert.ToDouble (Sayi2.Text);  

            double sonuc = sayi1 - sayi2;

            txtSonuc.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(Sayi1.Text);
            double sayi2 = Convert.ToDouble(Sayi2.Text);

            double sonuc = sayi1 * sayi2;

            txtSonuc.Text = sonuc.ToString();
        }

        private void btnBöl_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(Sayi1.Text);
            double sayi2 = Convert.ToDouble(Sayi2.Text);

            if (sayi2 != 0)
            {
                double sonuc = sayi1 / sayi2;
                txtSonuc.Text = sonuc.ToString();
            }

            else 
            {
                MessageBox.Show("Sýfýra bölmek imkansýzdýr");
            }
        }
    }
}