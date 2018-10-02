/*
 * Created by: Kuot Mariak
 * Created on: 13-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Name of Program
 * Calculations...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculations_KuotM_
{
    public partial class CalculationsForm : Form
    {
        public CalculationsForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        // This hides the label
            lblAnswer1.Hide();
            lblAnswer2.Hide();
            lblAnswer3.Hide();
            lblAnswer4.Hide();
        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
        // This calculates the equation and converts the text to a string
            lblAnswer1.Text = Convert.ToString(5 + Math.Pow(2, 3));
        // This shows the label when clicked
            lblAnswer1.Show();
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
        // This calculates the equation and converts the text to a string
            lblAnswer2.Text = Convert.ToString(4 / 2 + 8);
        // This shows the label when clicked
            lblAnswer2.Show();
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
        // This calculates the equation and converts the text to a string
            lblAnswer3.Text = Convert.ToString(15 - Math.Pow(3, 2));
        // This shows the label when clicked
            lblAnswer3.Show();
        }

        private void btnQuestion4_Click(object sender, EventArgs e)
        {
        // This calculates the equation and converts the text to a string
            lblAnswer4.Text = Convert.ToString(9 + 4 - 2);
        // This shows the label when clicked
            lblAnswer4.Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // This exits the program
            Close();
        }
    }
}
