/*
 * Created by: Linh Ho
 * Created on: September 9th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International 
 * This program displays the greeting Hello World! in
 * different languages depending on which radio button is clicked
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

namespace HelloIntLinh
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Change the greeting to English
            this.lblGreeting.Text = "Hello, everyone";
        }

        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            // Change the greeting to Spanish
            this.lblGreeting.Text = "Hola";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Change the greeting to French
            this.lblGreeting.Text = "Bonjour, le monde";
        }

        private void RadVietnamese_CheckedChanged(object sender, EventArgs e)
        {
            // Change the greeting to Vietnamese 
            this.lblGreeting.Text = "Xin Chao";
        }

        private void FrmHelloInt_Load(object sender, EventArgs e)
        {

        }
    }
}
