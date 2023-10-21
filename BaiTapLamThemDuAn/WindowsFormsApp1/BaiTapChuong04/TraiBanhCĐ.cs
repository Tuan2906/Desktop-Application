using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapChuong04
{
    public partial class TraiBanhCĐ : Form
    {
        int dx = 1, dy = 1;
        public TraiBanhCĐ()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pic2.Visible = false;
        }

        int demsoluot = 0;
        int demchay = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            /// if (picConChim.Left < 0 || picConChim.Right > ClientRectangle.Width)
            //{
            //dx = -dx;
            //}


            if (demsoluot == 1)
            {
                dy = pic2.Location.Y;
                dy++;
                pic2.Location = new Point(pic2.Location.X, dy);
                demchay = 1;
            }
            if (demsoluot == 0)
            {

                dy = picConChim.Location.Y;

                dy++;
                picConChim.Location = new Point(picConChim.Location.X, dy);
                demchay = 0;
            }
            if (dy == ClientRectangle.Height)
            {
                TraiBanhCĐ a = new TraiBanhCĐ();
                dy = a.Size.Height;

             
                if (demchay == 1)
                {
                    picConChim.Location = new Point(picConChim.Location.X, picConChim.Size.Height);
                    picConChim.Visible = true;
                    demsoluot = 0;
                }
                else
                {
                    // picConChim.Visible = false;
                    pic2.Visible = true;
                    pic2.Location = new Point(pic2.Location.X, pic2.Size.Height);
                    demsoluot = 1;
                }
                
               // demsoluot++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          ////  if (picConChim.Top < 0 || picConChim.Bottom > ClientRectangle.Height)
          ////  {
          ////       dy = -dy;
          ////  }
          ////picConChim.Left += dx;
          ////  picConChim.Top += dy;
        }
     }
}
