using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeOPP
{
    public partial class PhepToanPhanSo : Form
    {
        public PhepToanPhanSo()
        {
            InitializeComponent();
        }

        private void PhanSo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            PhanSo a, b, kq;
            a = new PhanSo();
            kq = new PhanSo();
            try
            {
                a.Tu = int.Parse(txtTuso1.Text);
                a.Mau = int.Parse(txtMauSo1.Text);
                b = new PhanSo(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text));
                kq = a.tong(b);
                txtTuSo3.Text = kq.Tu.ToString();
                txtMauSo3.Text = kq.Mau.ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message,"ERRROLL");
                txtTuSo3.Clear();
                txtMauSo3.Clear();
            }
            finally{
                txtTuso1.Clear();
                txtTuSo2.Clear();
                txtMauSo1.Clear();
                txtMauSo2.Clear();
               
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txttuSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMauSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMauSoKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
   
}
