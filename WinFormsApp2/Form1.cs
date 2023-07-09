using System.Threading.Tasks.Sources;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        
        //hesap makinesi yapma.05.07.2023
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc = 0;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label1.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            float sayi1, sayi2, sonuc = 0;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label1.Text = sonuc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            float sayi1, sayi2, sonuc = 0;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label1.Text = sonuc.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc = 0;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = sayi1 / sayi2;

            label1.Text = sonuc.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}