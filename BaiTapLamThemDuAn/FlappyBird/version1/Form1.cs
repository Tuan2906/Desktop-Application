using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version1
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }
        int x_ongdoi, y_ongtren1, x_ongdoi2, y_ongtren2;
        int y_ongduoi1, y_ongduoi2;
        int x_conchim, y_conchim;

        private void Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int dem = 0;
       
        

        int dem2=0;

        private void button1_Click(object sender, EventArgs e)
        {
            dem2++;
            if (dem2 % 2 != 0)
            {
                btnPlay.Hide();

            }
            timer1.Start();
            
        }
        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                y_conchim -= 20;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblgameover.Hide();
            x_ongdoi -= 5;
            x_ongdoi2 -= 5;
            int flag = 0;

            ongtru1.Location = new Point(x_ongdoi, y_ongtren1);

            ongtruduoi.Location = new Point(x_ongdoi, y_ongduoi1);
            ongtruc2.Location = new Point(x_ongdoi2, y_ongtren2);
            ongtrucduoi2.Location = new Point(x_ongdoi2, y_ongduoi2);
            // check cặp ống 1 đi qua khõi form thì cho nó hiện lại 
            if (x_ongdoi + ongtru1.Width <= 0)
            {

                x_ongdoi = 800;
                dem++;
                Random rd = new Random();
                y_ongtren1 = rd.Next(-50, 10);
                y_ongduoi1 = 300 + y_ongtren1 + khoangCachHaiOng;
                ongtru1.Location = new Point(x_ongdoi, y_ongtren1);
                ongtruduoi.Location = new Point(x_ongdoi, y_ongduoi1);
            }
            lblDiem.Text = "Score:" + dem.ToString();
            if (x_ongdoi2 + ongtruc2.Width <= 0)
            {
                x_ongdoi2 = 800;
                dem++;
                Random rd = new Random();
                y_ongtren2 = rd.Next(-50, -10);
                // MessageBox.Show(y_ongtren2.ToString());
                ongtruc2.Location = new Point(x_ongdoi2, y_ongtren2);
                y_ongduoi2 = 300 + y_ongtren2 + khoangCachHaiOng;
                ongtrucduoi2.Location = new Point(x_ongdoi, y_ongduoi2);
            }
            if (y_conchim + conchim.Height <= this.Height)
            {
                y_conchim += 10;
                conchim.Location = new Point(x_conchim, y_conchim);
                if (x_conchim + conchim.Width >= x_ongdoi && x_conchim + conchim.Width <= x_ongdoi + ongtru1.Width)
                {

                    if (y_conchim <= 300 + y_ongtren1 || y_ongtren1 >= y_ongduoi1)
                    {
                        timer1.Stop();
                        lblgameover.Show();
                        lblgameover.Text = "GAME OVER";

                    }
                    if (y_conchim >= y_ongduoi1 || y_ongduoi1 <= y_ongtren1)
                    {
                        timer1.Stop();
                       
                        lblgameover.Show();
                        lblgameover.Text = "GAME OVER";

                    }
                }

                if (x_conchim + conchim.Width >= x_ongdoi2 && x_conchim + conchim.Width <= x_ongdoi2 + ongtruc2.Width)
                {

                    if (y_conchim <= 300 + y_ongtren2 || y_ongtren2 >= y_ongduoi2)
                    {
                        timer1.Stop();
                      
                     
                        lblgameover.Show();
                        lblgameover.Text = "GAME OVER";

                    }
                    if (y_conchim >=y_ongduoi2 || y_ongduoi2 <= y_ongtren2)
                    {
                        timer1.Stop();
                        
                     
                        lblgameover.Show();
                        lblgameover.Text = "GAME OVER";

                    }
                }
            }
            else
            {
                timer1.Stop();
                lblgameover.Show();
               lblgameover.Text = "GAME OVER";
            }
            
                 
        }

        int khoangCachHaiOng = 180;
        private void FlappyBird_Load(object sender, EventArgs e)
        {
            // Code full man hinh
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            // MessageBox.Show("CHieu rong:" + this.Width, "& Chieu cao" + this.Height);\
            // ong tru tren 1
            x_ongdoi = 400;
            y_ongtren1 = -10;
            ongtru1.Size = new Size(55, 300);
            ongtru1.Location = new Point(x_ongdoi, y_ongtren1);
            // ong tru duoi 1
            ongtruduoi.Size = new Size(55, 300);
            y_ongduoi1 = 300 + y_ongtren1 + khoangCachHaiOng;
            ongtruduoi.Location = new Point(x_ongdoi, y_ongduoi1);
            // ong tru tren thu 2
            x_ongdoi2 = x_ongdoi + ongtru1.Width + 400;
            y_ongtren2 = -10;
            ongtruc2.Size = new Size(55, 300);
            ongtruc2.Location = new Point(x_ongdoi2, y_ongtren2);
            // ong tru duoi thu 2
            y_ongduoi2 = (400 + y_ongtren2) + khoangCachHaiOng;
            ongtrucduoi2.Size = new Size(55, 300);
            ongtrucduoi2.Location = new Point(x_ongdoi2, y_ongduoi2);
            conchim.Size = new Size(127, 100);
            x_conchim = conchim.Location.X;
            y_conchim = conchim.Location.Y;
            timer1.Interval = 1;
          // timer1.Start();
            lblDiem.Location = new Point(1200, -1);
            btnPlay.Location = new Point(600, 300);
            lblgameover.Location= new Point(500, 200);
        }
        private void onTruc()
        {
            x_ongdoi = 400;
            y_ongtren1 = -10;
            ongtru1.Size = new Size(55, 300);
            ongtru1.Location = new Point(x_ongdoi, y_ongtren1);
            // ong tru duoi 1
            ongtruduoi.Size = new Size(55, 300);
            y_ongduoi1 = 300 + y_ongtren1 + khoangCachHaiOng;
            ongtruduoi.Location = new Point(x_ongdoi, y_ongduoi1);
            // ong tru tren thu 2
            x_ongdoi2 = x_ongdoi + ongtru1.Width + 400;
            y_ongtren2 = -10;
            ongtruc2.Size = new Size(55, 300);
            ongtruc2.Location = new Point(x_ongdoi2, y_ongtren2);
            // ong tru duoi thu 2
            y_ongduoi2 = (400 + y_ongtren2) + khoangCachHaiOng;
            ongtrucduoi2.Size = new Size(55, 300);
            ongtrucduoi2.Location = new Point(x_ongdoi2, y_ongduoi2);
            conchim.Size = new Size(127, 100);
            x_conchim = conchim.Location.X;
            y_conchim = conchim.Location.Y;
            // timer1.Interval = 1;
            timer1.Interval = 1;
            timer1.Start();

        }

        private void ongtru1_Click(object sender, EventArgs e)
        {

        }
    }
}
