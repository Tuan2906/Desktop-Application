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
    public partial class Behoctoan : Form
    {
        public Behoctoan()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txtso1.Text));// checked kiem tra xem co bi tran so hay khong
                int b = checked(int.Parse(txtso2.Text));
                if (rbtncong.Checked)
                {
                    txtKQ.Text = String.Format("{0}", checked(a + b));
                }
                else if (rbtntru.Checked)
                {
                    txtKQ.Text = String.Format("{0}", checked(a - b));
                }
                else if (rbtnnhan.Checked)
                {
                    txtKQ.Text = String.Format("{0}", checked(a * b));
                }
                else 
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Loi chia cho 0");
                    }
                    if(rbtnchiahet.Checked)
                    {
                        txtKQ.Text = String.Format("{0:0.0}", (double)a / b);
                    }
                    else
                    {
                        txtKQ.Text = String.Format("{0}", a % b);
                    }

                }
               
            }
            catch (FormatException)
            {
                txtKQ.Text = "Phai nhap 2 so";
            }
            catch (DivideByZeroException ex)
            {
                txtKQ.Text = ex.Message;

            }
            catch (OverflowException)
            {
                txtKQ.Text = "So qua lon";
            }
          
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
