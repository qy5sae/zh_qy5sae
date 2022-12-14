namespace zh_qy5sae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Models.Receptcontext context = new Models.Receptcontext();
        }

        private void buttonFogasview_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        }

        private void buttonHozzavalo_Click(object sender, EventArgs e)
        {
            UserControl2 uc2 = new UserControl2();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc2);
            uc2.Dock= DockStyle.Fill;
        }
    }
}