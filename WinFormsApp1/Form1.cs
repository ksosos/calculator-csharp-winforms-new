namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string num = "";
        string ope = "";
        private void button10_Click(object sender, EventArgs e)
        {
            if(num.Length < 8)
            {
                num += (sender as Button).Text;
                label1.Text = num;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(num.Length == 0) { return; }
            num = num.Substring(0, num.Length - 1);
            label1.Text = num;
        }

  
       

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = long.Parse(label2.Text.Replace("+", "").Replace("-", "").Replace("/","").Replace("*",""));
                var num2 = long.Parse(label1.Text);
                if (ope == "+")
                {
                    label1.Text = (num1 + num2).ToString();
                }
                else if (ope == "-")
                {
                    label1.Text = (num1 - num2).ToString();
                }
                else if (ope == "*")
                {
                    label1.Text = (num1 * num2).ToString();

                }
                else if (ope == "/")
                {
                    label1.Text = (num1 / num2).ToString();

                }
                ope = "";
                num = "";
                label2.Text = "";
            }
            catch(FormatException) { };
            
        }

       

        private void button15_Click(object sender, EventArgs e) // del
        {
            var op = (sender as Button).Text;
            if (ope.Length == 0)
            {
                ope = op;
                label2.Text = label1.Text + " " + ope;
                num = "";
                label1.Text = "";
            }
            else
            {
                ope = op;
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 2);
                label2.Text += " " + ope;
            }
        }
    }
}