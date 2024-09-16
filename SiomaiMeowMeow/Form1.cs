using System.Windows.Forms.VisualStyles;

namespace SiomaiMeowMeow
{
    public partial class Form1 : Form
    {
        int TotalPrice = 0;
        string[] MainDish = { "Chksiomai", "PrkSiomai", "ShkFn", "BfWtn", "ShrmpWtn", "BfSiomai" };
        string[] ComboMeals = { "Comey", "Combi" };
        string[] Drinks = { "Gulaman", "Buko", "PApple", "Water" };
        string[] Addons = { "RegRice", "GRice", "JRizz"};
        string[] order;


        public Form1()
        {
            InitializeComponent();

            // Subscribe to the Timer's Tick event
            myTimer.Tick += new EventHandler(timer1_tick);

            // Start the Timer
            myTimer.Start();

        }
        private void timer1_tick(object sender, EventArgs e)
        {
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Chicken_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
        }

        private void Comey_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice +50;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Pinya_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 17;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Pork_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void SharkFin_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Beef_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Shrimp_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void BSiomai_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Combi_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Beef_Click_1(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void Gulat_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 15;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void koko_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 17;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void TubigKanal_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 20;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void ERice_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 10;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void JRice_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 25;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }

        private void GRice_Click(object sender, EventArgs e)
        {
            TotalPrice = TotalPrice + 20;
            TotalV.Text = $"₱{TotalPrice.ToString()}";
        }
    }
}
