using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Bitmap DarwString(string txt) {

            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bm))
            {

                using (SolidBrush myBrush = new SolidBrush(Color.Black))
                {

                    using (Font myFont = new Font("Times New Roman", 12))
                    {

                        g.DrawString(txt, myFont, myBrush, 10, 10);

                        return bm;

                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DarwString("ss");

        }
    }
}
