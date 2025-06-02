namespace JihaneBouhajbane
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

        private void button2_Click(object sender, EventArgs e)
        {
            Ad ad = new Ad();
            ad.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Ensegnant es = new Ensegnant();
            es.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Et et = new Et();
            et.Show();
        }
    }
}
