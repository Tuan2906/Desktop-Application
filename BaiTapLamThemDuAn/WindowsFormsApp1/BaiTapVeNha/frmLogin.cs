using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaiTapVeNha
{
    
    public partial class frmLogin : Form
    {
        fParent f;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(fParent fmain)
        {
            f = fmain;
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s, s1;
            StreamReader read = new StreamReader("CSDL.txt");
            s = read.ReadLine();
            s1 = read.ReadLine();
            read.Close();
            if (txtDangNhap.Text != string.Empty && txtMK.Text != string.Empty)
            {
               
                if (txtMK.Text.Equals(s1) && txtDangNhap.Text.Equals(s))
                {
                    f.setName(txtDangNhap.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("mat khau hoac ten dang nhap khonng chinh xac", "Thong bao!!!");
                    txtDangNhap.Text = "";
                    txtMK.Text = "";
                    StreamWriter r = new StreamWriter("CSDL.txt", true);
                    //StreamWriter r1 = new StreamWriter(txtMK.Text, true);
                    r.WriteLine(txtDangNhap.Text);
                    r.WriteLine(txtMK.Text);
                    r.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap ten dang nhap va mk");
            }

            
               

        }
    }
}
