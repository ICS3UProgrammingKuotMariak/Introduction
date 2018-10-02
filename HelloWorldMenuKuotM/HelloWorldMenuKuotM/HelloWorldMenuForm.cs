/*
 * Created by: Kuot Mariak
 * Created on: 11-Sep-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays Hello World but with an exit menu
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

namespace HelloWorldMenuKuotM
{
    public partial class frmHelloWorldMenu : Form
    {
        public frmHelloWorldMenu()
        {
            InitializeComponent();
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void mniProgram_Click(object sender, EventArgs e)
        {
            // This closes the program
            Close();
        }
    }
}
