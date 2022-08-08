using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquaresCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int lowerLimit = 0;
            int upperLimit = 10;
            int countBy = 1;

            listBox1.Items.Clear();

            try
            {
                // store values from textbox to variables
                lowerLimit = int.Parse(txt_lowerLimit.Text);
                upperLimit = int.Parse(txt_UpperLimit.Text);
                countBy = int.Parse(txt_countBy.Text); 

                if (lowerLimit > upperLimit)
                {
                    // swap numbers
                    int temp = lowerLimit;
                    lowerLimit = upperLimit;
                    upperLimit = temp;
                }

                for (int i = lowerLimit; i < upperLimit; i += countBy)
                {
                    listBox1.Items.Add("i = " + i + " squared = " + i * i);
                    
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Enter numbers only");
            }

       



        }

        private void txt_countBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
