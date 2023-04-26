namespace appsdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string putValueFirst
        {
            set
            {
                inputOne.Text = value;
            }
        }

        public string putValueSecond
        {
            set
            {
                inputTwo.Text = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_Two1.Hide();
        }

        private void panelOne_Click(object sender, EventArgs e)
        {
            panel_One1.Show();
            panel_Two1.Hide();
        }

        private void panelTwo_Click(object sender, EventArgs e)
        {
            panel_One1.Hide();
            panel_Two1.Show();
        }
    }
}