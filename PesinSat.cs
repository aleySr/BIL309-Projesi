using MarketInfoSystem.Context;
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
    public partial class PesinSat : Form
    {
        private readonly DataContext _context;
        public PesinSat()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PesinSat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Products.ToList();
        }
    }
}
