using MarketInfoSystem.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class Irsaliyeler : Form
    {
        private readonly DataContext _context;
        public Irsaliyeler()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        private void Irsaliyeler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Irsaliyeler.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
