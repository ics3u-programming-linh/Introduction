/*
 * Created by: Linh Ho
 * Created on: September 10th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Perimeter Area Volume
 * This program calculates the perimeter of a rectangle,
 * the area of a circle and the volume of a sphere.
 * It displays the answers in labels when the respective
 * button is clicked
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

namespace PerAreaVolLinhH
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Calculate the perimeter
            lblAPerimeter.Text = Convert.ToString(5 * 4);
        }

        private void FrmPerAreaVol_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            // Calculate the area of a circle
            lblAArea.Text = Convert.ToString(Math.PI * Math.Pow(7, 2));
        }

        private void LblAPerimeter_Click(object sender, EventArgs e)
        {

        }

        private void LblAArea_Click(object sender, EventArgs e)
        {

        }

        private void BtnQVolume_Click(object sender, EventArgs e)
        {
            // Calculate the Volume of the sphere
            lblAVolume.Text = Convert.ToString((double) 4 / (double)3 * Math.PI * Math.Pow(4, 3));
        }
    }
}
