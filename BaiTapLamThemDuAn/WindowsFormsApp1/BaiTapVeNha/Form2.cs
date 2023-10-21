using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class fParent : Form
    {
        int dx = 10;
        int dy = 10;
        public fParent() {
            InitializeComponent();
            UpdateTextPosition();
        }
        private void UpdateTextPosition(){
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;
            while ((tmpWidth + widthOfASpace) < startingPoint){
                tmp += " ";
                tmpWidth += widthOfASpace;
            }
            this.Text = tmp + this.Text.Trim();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin(this);
            fr.MdiParent = this;
            fr.BringToFront();
            fr.Show();
            timer1.Start();
        }
        public void setName(string name)
        {
            lblDN.Text = name;
           lblThanhNgang.Visible= lblDN.Visible = lblDN.Visible == true ? false : true;

            picBall.Visible = picBall.Visible == true ? false : true;
        }
        int demDiem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (lblThanhNgang.Bounds.IntersectsWith(picBall.Bounds))
            {
                dy = -dy;
                demDiem++;
                label1.Visible = true;
                label1.Text = "Diem:" + demDiem;
            }
          
            if (picBall.Left < 0 || picBall.Right >= ClientRectangle.Width)
            {
                dx = -dx;
            }
            if (picBall.Top < 0 || picBall.Bottom >= ClientRectangle.Height)
            {
                dy = -dy;
            }
            if (picBall.Bottom > lblThanhNgang.Bottom)
            {
                demDiem = 0;
                label1.Text = "";
                lblLose.Visible = true;
               lblLose.Text="GAME OVER";
                timer1.Enabled = false;
                timer1.Stop();
               timer2.Start();
                
                
            }
            picBall.Left += dx;
            picBall.Top += dy;
        }
        bool checkChay = true;
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S:
                    if (checkChay)
                    {
                        timer1.Stop();
                        checkChay = false;
                    }
                    else
                    {
                        timer1.Start();
                        checkChay = true;
                    }
                    
                    break;
                case Keys.Left:
                    if(lblThanhNgang.Left >0)
                    {
                        lblThanhNgang.Left -= 10;

                    }
                    break;
                case Keys.Right:
                    if (lblThanhNgang.Right < ClientRectangle.Right)
                    {
                        lblThanhNgang.Left += 10;

                    }
                    break;
                  
            }
            return base.ProcessDialogKey(keyData);
        }
        private void lblThanhNgang_Click(object sender, EventArgs e)
        {

        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(12,12);
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer2.Stop();
            
            timer1.Start();
            btnChoiLai.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblLose.Text.Contains("GAME OVER"))
            {
                demDiem = 0;
                lblLose.Visible = false;
                btnChoiLai.Visible = true;
               
            }
        }
    }
}
