namespace LetsGetGui
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            //theBigRedBTN.MouseEnter += theBigRedBTN_MouseEnter;
        }

        /*
        private void theBigRedBTN_Click(object sender, EventArgs e)
        {
            theBigRedBTN.Text = "You clicked the button!";
        }

        private void theBigRedBTN_MouseEnter(object sender, EventArgs e)
        {
            int randx = rand.Next(this.Width - theBigRedBTN.Width);
            int randy = rand.Next(this.Height - theBigRedBTN.Height);

            theBigRedBTN.Location = new Point(randx, randy);
            theBigRedBTN.BackColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));

        }
    */
    }
}