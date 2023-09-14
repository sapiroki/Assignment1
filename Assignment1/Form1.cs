namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Jack of Hearts";
            label2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ten of Diamonds";
            label2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "Ace of Clubs";
            label2.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "King of Spades";
            label2.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "Queen of Hearts";
            label2.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "Six of Clubs";
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}