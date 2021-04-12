using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace EmblemCounterSA
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        bool sadx130;
        bool sadx20;
        bool sa2b180;
        int emblemtotal;
        int emblemnumber1;
        int emblemnumber2;
        int emblemnumber3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void emblemGetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (emblemnumber1 == 9)
            {
                emblemnumber2++;
                emblemtotal++;
                emblemnumber1 = 0;
                emblemnum2.Image = imageList1.Images[emblemnumber1];
                emblemnum1.Image = imageList1.Images[emblemnumber2];

            }
            else
            {
                emblemnumber1++;
                emblemtotal++;
                emblemnum2.Image = imageList1.Images[emblemnumber1];
            }
            if (emblemnumber1 == 9 && emblemnumber2 == 9)
            {
                emblemnum3.Visible = true;
                emblemnumber1 = 0;
                emblemnumber2 = 0;
                emblemnumber3++;
                emblemtotal++;
                emblemnum3.Image = imageList1.Images[emblemnumber3];
                emblemnum2.Image = imageList1.Images[emblemnumber1];
                emblemnum1.Image = imageList1.Images[emblemnumber2];
                emblemnum1.Location = new System.Drawing.Point(447, 51);
                emblemnum2.Location = new System.Drawing.Point(503, 51);
            }
            if (sadx130 == true && emblemtotal == 130)
            {
                MessageBox.Show("Congrats", "WINNER", System.Windows.Forms.MessageBoxButtons.OK);
            }
            if (sadx20 == true && emblemtotal == 20)
            {
                MessageBox.Show("Congrats", "WINNER", System.Windows.Forms.MessageBoxButtons.OK);
            }
            if (sa2b180 == true && emblemtotal == 180)
            {
                MessageBox.Show("Congrats", "WINNER", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emblemnumber1 = 0;
            emblemnumber2 = 0;
            emblemnumber3 = 0;
            emblemtotal = 0;
            emblemnum3.Visible = false;
            emblemnum3.Image = imageList1.Images[emblemnumber3];
            emblemnum2.Image = imageList1.Images[emblemnumber1];
            emblemnum1.Image = imageList1.Images[emblemnumber2];
            emblemnum1.Location = new System.Drawing.Point(391, 51);
            emblemnum2.Location = new System.Drawing.Point(427, 51);
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
                toolStripMenuItem2.Checked = true;
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem4.Checked = false;
                sadx130 = true;
                sadx20 = false;
                sa2b180 = false;
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
                toolStripMenuItem3.Checked = true;
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem4.Checked = false;
                sadx20 = true;
                sadx130 = false;
                sa2b180 = false;
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
                toolStripMenuItem4.Checked = true;
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem3.Checked = false;
                sadx20 = false;
                sadx130 = false;
                sa2b180 = true;
            
        }

    }
}