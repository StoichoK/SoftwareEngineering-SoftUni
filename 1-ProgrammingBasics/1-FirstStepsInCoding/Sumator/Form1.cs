using System;
using System.Windows.Forms;

namespace Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(this.textBox1.Text);
                decimal num2 = decimal.Parse(this.textBox2.Text);
                decimal sum = num1 + num2;
                textBoxSum.Text = sum.ToString();
            }
            catch (Exception)
            {
                textBoxSum.Text = "error";
            }
        }
    }
}
