using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hoctapcuabe : Form
    {
        Random r = new Random();
        String[] s = { "+", "-", "*", "/" };

        int idx = 0;
        public hoctapcuabe()
        {
            InitializeComponent();
        }

        private void hoctapcuabe_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            txtDoan.Text += bt.Text;
        
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            do
            {
                so1 = r.Next(10);
                so2 = r.Next(10);
                idx = r.Next(4);

            } while (idx == 3 && so2 == 0);
           lbl1.Text = so1.ToString();
            lbl2.Text = so2.ToString();
            lbltoantu.Text = s[idx];
            txtKQ.Text = "";
            txtDoan.Text = "";

        }


        private void btnXem_Click(object sender, EventArgs e)
        {   
            int kq = 0;
            switch (idx)
            {
                case 0:
                    kq = int.Parse(lbl1.Text) + int.Parse(lbl2.Text);
                    break;
                case 1:
                    kq = int.Parse(lbl1.Text) - int.Parse(lbl2.Text);
                    break;
                case 2:
                    kq = int.Parse(lbl1.Text) * int.Parse(lbl2.Text);
                    break;
                case 3:
                    kq = int.Parse(lbl1.Text) / int.Parse(lbl2.Text);
                    break;
            }
            try
            {
                int user = int.Parse(txtDoan.Text);
                if (user == kq)
                {
                    txtKQ.Text = "CHuc mungg em lam dung\n";
                }
                else
                {
                    txtKQ.Text = "Ban lam sai roi| ket qua phai la:" + kq.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ban can du doan", "Thong bao!!!");
            };

        }
        private void txtXoa_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text == "") return;
            txtDoan.Text = txtDoan.Text.Substring(0, txtDoan.Text.Length - 1);

        }
    }
}
