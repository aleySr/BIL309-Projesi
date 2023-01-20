using MarketInfoSystem.Context;

namespace MarketInfoSystem
{
    public partial class Form1 : Form
    {
        private readonly DataContext _context;
        public Form1()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_context.Administrators
                .Any(x => x.Email == emailBox.Text && x.Password == textBox1.Text))
            {
                MessageBox.Show("Giriþ Yapýldý!");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}