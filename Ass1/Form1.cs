namespace Ass1
{
    public partial class Form1 : Form
    {
        // Public vars
        // Num vars

        double numero1;
        double numero2;
        double sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert string to float
            numero1 = double.Parse(leftBox.Text);
            numero2 = double.Parse(rightBox.Text);
            // Calculate sum of numero1 and numero2
            sum = numero1 + numero2;
            itsALabel.Text = sum.ToString();
            theOperator.Text = "+";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Convert string to float (again)
            numero1 = double.Parse(leftBox.Text);
            numero2 = double.Parse(rightBox.Text);

            // Calculate subtraction of numero1 and numero2
            sum = numero1 - numero2;
            itsALabel.Text = sum.ToString();
            theOperator.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            // Convert string to float yet again
            numero1 = double.Parse(leftBox.Text);
            numero2 = double.Parse(rightBox.Text);

            //Calculate multiplication of numero1 and numero2
            sum = numero1 * numero2;
            itsALabel.Text = sum.ToString();
            theOperator.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // oh my god
            numero1 = double.Parse(leftBox.Text);
            numero2 = double.Parse(rightBox.Text);

            // divide
            sum = numero1 / numero2;
            itsALabel.Text = sum.ToString();
            theOperator.Text = "/";
        }
    }
}