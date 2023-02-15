namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            const double FOUR_FEET = 4;
            const double SEVEN_FEET = 7;
            const double BANNER_PRICE_1 = 69.95;
            const double BANNER_PRICE_2 = 119.99;
            const double BANNER_PRICE_3 = 179.95;

            double user_input;
            string user_message = "The price for your banner in US dollars is $";
            double user_fee;

            user_input = Convert.ToDouble(textBox1.Text);
            

            if (user_input < FOUR_FEET)
                user_fee = BANNER_PRICE_1;
                else if (user_input <= SEVEN_FEET)
                    user_fee = BANNER_PRICE_2;
            else 
                user_fee = BANNER_PRICE_3;

            lblOutput.Text = user_message + user_fee;

            

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}