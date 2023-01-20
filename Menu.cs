using MarketInfoSystem.Entities;

namespace MarketInfoSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Irsaliyeler irsaliyeler = new Irsaliyeler();
            irsaliyeler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perakende perakende = new Perakende();
            perakende.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veresiye veresiye = new Veresiye();
            veresiye.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PerakendeSatis perakendeSatis = new PerakendeSatis();
            perakendeSatis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.Show();
        }
    }
}
