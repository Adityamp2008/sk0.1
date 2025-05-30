namespace pk03
{
    public partial class Form1 : Form
    {
        int nomorNota = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            jm.Items.Add("minuman");
            jm.Items.Add("makanan");
            jm.Items.Add("sate");
        }
        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void jm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jm.Text == "minuman")
            {
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("kopi hitam");
                nm.Items.Add("susu putih");
                nm.Items.Add("teh hangat");
            }

            else if (jm.Text == "makanan")
            {
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("nasi goreng");
                nm.Items.Add("ayam goreng");
                nm.Items.Add("ayam bakar");
            }

            else if (jm.Text == "sate")
            {
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("sate kambing");
                nm.Items.Add("sate telur");
                nm.Items.Add("sate usus");
            }
        }

        private void nm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nm.Text)
            {
                case "kopi hitam":
                case "susu putih":
                    harga.Text = "5000";
                    break;

                case "teh hangat":
                    harga.Text = "4000";
                    break;

                case "nasi goreng":
                    harga.Text = "13000";
                    break;

                case "ayam bakar":
                    harga.Text = "15000";
                    break;

                case "sate kambing":
                    harga.Text = "3000";
                    break;

                case "sate telur":
                case "sate usus":
                    harga.Text = "2000";
                    break;

            }
        }

        private void hitung_Click(object sender, EventArgs e)
        {
            nota.Text = "pelangan" + nomorNota.ToString("D3");
            nomorNota++;

            double hargaval = double.Parse(harga.Text);
            double jumlahval = double.Parse(jumlah.Text);

            double totalharga = hargaval * jumlahval;
            th.Text = totalharga.ToString();

            if (totalharga > 500000)
            {
                diskon.Text = "50000";
            }
            else
            {
                diskon.Text = "0";
            }

            double diskonVal = double.Parse(diskon.Text);
            double bayar = totalharga - diskonVal;
            tb.Text = bayar.ToString();
        }

        private void bersih_Click(object sender, EventArgs e)
        {
            jm.Text = "";
            nm.Text = "";
            jumlah.Text = "";
            harga.Text = "";
            diskon.Text = "";
            tb.Text = "";
            nota.Text = "";
            th.Text = "";

        }
    }
}
