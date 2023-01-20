using MarketInfoSystem.Context;
using MarketInfoSystem.Entities;
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
    public partial class Stok : Form
    {
        private DataContext _context;
        public Stok()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Products.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.

            var newProduct = new Product();
            newProduct.Barcode = "assdas23453";
            newProduct.Name = "Çilek";
            newProduct.Stock = 123;
            newProduct.StockUnit = "kg";
            newProduct.SelllingUnitPrice = 15;
            newProduct.CreatedDate = DateTime.Now;
            _context.Products.AddAsync(newProduct);
            dataGridView1.Refresh();
        }
    }
}
