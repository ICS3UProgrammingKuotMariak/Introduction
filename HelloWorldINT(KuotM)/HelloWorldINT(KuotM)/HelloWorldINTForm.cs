/*
 * Created by: Kuot Mariak
 * Created on: 12-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Name of Program
 * Hello World International...
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

namespace HelloWorldINT_KuotM_
{
    public partial class frmHelloWorldINT : Form
    {
        public frmHelloWorldINT()
        {
            InitializeComponent();
        }
        //This changes the language to English when clicked
        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World";
            mnuFile.Text = "File";
            mniExit.Text = "Exit";
        }

        private void frmHelloWorldINT_Load(object sender, EventArgs e)
        {

        }
        //This changes the language to Spanish when clicked
        private void radEspañol_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hola Mundo";
            mnuFile.Text = "Archivo";
            mniExit.Text = "Salida";
        }
        //This changes the language to Swahili when clicked
        private void radKiswahili_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Salamu, Dunia";
            mnuFile.Text = "Funga";
            mniExit.Text = "Utgång";
        }
        //This changes the language to Arabic when clicked
        private void radعربى_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "مرحبا بالعالم";
            mnuFile.Text = "ملف";
            mniExit.Text = "ىخرج";
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {
            
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
