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
    public partial class PerakendeSatis : Form
    {
        public PerakendeSatis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariSat cariSat = new CariSat();
            cariSat.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesinSat pesinSat = new PesinSat();
            pesinSat.Show();
            this.Hide();
        }
    }
}
