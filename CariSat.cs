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
    public partial class CariSat : Form
    {
        private readonly DataContext _context;
        public CariSat()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        private void CariSat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Products.ToList();
        }
    }
}
