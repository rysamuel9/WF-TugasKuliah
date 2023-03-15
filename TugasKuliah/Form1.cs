namespace TugasKuliah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Ini buat inputan angkanya / jari jarinya (textbox)
        private void inputJariJari(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Masukkan angka saja.");
                textBox2.Text = "";
            }
        }

        // ini button untuk hitung luasnya
        private void btnHitungLuasLingkaran(object sender, EventArgs e)
        {
            double radius, area;

            if (textBox2.Text == "")
            {
                MessageBox.Show("Masukkan nilai jari-jari terlebih dahulu.");
                return;
            }

            radius = Double.Parse(textBox2.Text);

            area = Math.PI * radius * radius;

            MessageBox.Show("Luas lingkaran adalah: " + area.ToString(), "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ini button untuk reset textboxnya
        private void btnResetLuasLingkaran(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void inputPanjang(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Masukkan angka saja.");
                textBox3.Text = "";
            }
        }

        private void inputLebar(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Masukkan angka saja.");
                textBox4.Text = "";
            }
        }

        private void inputTinggi(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Masukkan angka saja.");
                textBox1.Text = "";
            }
        }

        private void btnHitungLuasPersegiPanjang(object sender, EventArgs e)
        {
            double length, width, height, area;

            if (textBox3.Text == "" || textBox4.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Masukkan nilai panjang, lebar, dan tinggi terlebih dahulu.");
                return;
            }

            length = Double.Parse(textBox3.Text);
            width = Double.Parse(textBox4.Text);
            height = Double.Parse(textBox1.Text);

            area = length * width * height;

            MessageBox.Show("Luas persegi panjang adalah: " + area.ToString(), "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnResetInputanPersegiPanjang(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
        }

        private void btnTutupAplikasi(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}