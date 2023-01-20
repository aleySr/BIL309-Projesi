using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketInfoSystem
{
    public partial class Perakende : Form
    {
        public Perakende()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariSatis cariSatis = new CariSatis();
            cariSatis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesinSatis pesinSatis = new PesinSatis();
            pesinSatis.Show();
            this.Hide();
        }
    }
}
