using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using QuanLyHangKhongBUS;
using QuanLyHangKhongDAL;
using QuanLyHangKhongEntity;
using QuanLyHangKhongDAL;

namespace QuanLiHangKhong
{
    public partial class frmChonghe : Form
    {


        Bus_tableThonhTinMuaVe buschonghe = new Bus_tableThonhTinMuaVe();
        EC_ThongTinMuaVe ecChonGhe = new EC_ThongTinMuaVe();
        List<int> arrLayMaKH = new List<int>();
       List<string> arrLayGhe = new List<string>();
        private List<string> arrLayMaCBDaChon = new List<string>();
        public frmChonghe()
        {
            InitializeComponent();
        }

        int demCB = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // xu ly ghe khu hồi bằng cách cho kiểm tra macb theo kiểu vòng lặp;
            MessageBox.Show("Ghế màu đỏ đã chọn, ghế màu trắng còn trống, ghế màu vàng đang chọn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            xuligheGiaoDien();
            inDayGhe();
           
            foreach (Control control in pnGhe.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.Click += lblGhe_Click;
                }
            }

            dataLayGhe.DataSource = buschonghe.LayDuLieuGHe(arrLayMaCBDaChon[0]);// lay tat ca cac ghe 

                dataLayGhe.Visible = false;
                int demsoluongghetrong = 0;
                if (dataLayGhe.Rows.Count > 0)
                {


                    string text = "";
                    for (int i = 0; i < dataLayGhe.Rows.Count - 1; i++)
                    {


                        string t = dataLayGhe.Rows[i].Cells[0].Value.ToString();

                        if (t != "")
                        {
                            foreach (Control a in pnGhe.Controls)
                            {
                                if (t.Remove(0, 1).ToString() == pnGhe.GetRow(a).ToString())
                                {
                                    TableLayoutPanelCellPosition position = pnGhe.GetCellPosition(a);

                                    text = pnGhe.GetControlFromPosition(position.Column, 0).Text;
                                }
                                if (text == t.Substring(0, 1))
                                {

                                    demsoluongghetrong++;
                                    a.BackColor = Color.Red;
                                    a.Enabled = false;
                                    break;

                                }
                            }
                        }
                    }
                    lblHetCho.Text += ":" + demsoluongghetrong.ToString();
                    demsoluongghetrong = pnGhe.Controls.Count - 6 - demsoluongghetrong;
                    lblcontrongghe.Text += ":" + demsoluongghetrong.ToString();
                  

                demCB++;
            }
            
        }

        private void xuligheGiaoDien()
        {
            pnGhe.Controls.Clear();
            //int ghe = 1;
            int i = 0;
            int j = 0;
            bool check = true;
            for ( ; i < pnGhe.RowCount; i++)
            {
                for ( ; j < pnGhe.ColumnCount; j++)
                {
                   
                    Label lbghe = new Label();
                    if (check == true)
                    {
                        if (i == 0)
                        {
                            lbghe.Text = "F";
                            pnGhe.Controls.Add(lbghe,j,j);
                            lbghe.AutoSize = false;
                            lbghe.Dock = DockStyle.Fill;
                            lbghe.TextAlign = ContentAlignment.MiddleCenter;
                            lbghe.Width = lbghe.Height + 350;
                            lbghe.BackColor = Color.Red;
                            break;
                        }
                        if (i == 1)
                        {
                            lbghe.Text = "E";
                            pnGhe.Controls.Add(lbghe,j,j);
                            lbghe.AutoSize = false;
                            lbghe.Dock = DockStyle.Fill;
                            lbghe.TextAlign = ContentAlignment.MiddleCenter;
                            lbghe.Width = lbghe.Height + 350;
                            lbghe.BackColor = Color.Red;
                            break;
                        }
                        if (i == 2)
                        {
                            lbghe.Text = "D";
                            pnGhe.Controls.Add(lbghe,j,j);
                            lbghe.AutoSize = false;
                            lbghe.Dock = DockStyle.Fill;
                            lbghe.TextAlign = ContentAlignment.MiddleCenter;
                            lbghe.Width = lbghe.Height + 1000;
                            lbghe.BackColor = Color.Red;
                            break;
                        }
                        if (i == 3)
                        {
                            lbghe.Text = "C";
                            pnGhe.Controls.Add(lbghe,j,j);
                            lbghe.AutoSize = false;
                            lbghe.Dock = DockStyle.Fill;
                            lbghe.TextAlign = ContentAlignment.MiddleCenter;
                            lbghe.Width = lbghe.Height + 350;
                            lbghe.BackColor = Color.Red;
                            break;
                        }
                        if (i == 4)
                        {
                            lbghe.Text = "B";
                            lbghe.AutoSize = false;
                            lbghe.Dock = DockStyle.Fill;
                            lbghe.TextAlign = ContentAlignment.MiddleCenter;
                            lbghe.Width = lbghe.Height + 350;
                            lbghe.BackColor = Color.Red;
                            pnGhe.Controls.Add(lbghe,j,j);
                            break;
                        }
                        if (i == 5)
                        {
                            lbghe.Text = "A";
                            lbghe.AutoSize = false;
                            lbghe.Dock = DockStyle.Fill;
                            lbghe.TextAlign = ContentAlignment.MiddleCenter;
                            lbghe.Width = lbghe.Height + 350;
                            lbghe.BackColor = Color.Red;
                            pnGhe.Controls.Add(lbghe,j,j);
                            check = false;

                            break;
                        }
                      
                        
                    }
                   
                  
                }
              
            }
        }
        private void inDayGhe()
        {
            int ghe = 1;
            int col = 0;
            for (int row = 1; row < pnGhe.RowCount; row++)
            {
               
               
                Label lbghe = new Label();
                lbghe.Text = ghe + "";
                lbghe.AutoSize = false;
                lbghe.Dock = DockStyle.Fill;
                lbghe.TextAlign = ContentAlignment.MiddleCenter;
                lbghe.Width = lbghe.Height + 1000;
                lbghe.BackColor = Color.White;
                pnGhe.Controls.Add(lbghe, col, row);
                ghe++;
               
                if (row == pnGhe.RowCount-1)
                {
                    row = 0;
                    ghe = 1;
                    col++;

                }
                if (col > 5)
                    break;
                //row = 1;        

            }
        }
        int demsoluong = 0;
        public List<int> ArrLayMaKH1 { get => arrLayMaKH; set => arrLayMaKH = value; }
        public List<string> ArrLayMaCBDaChon { get => ArrLayMaCBDaChon1; set => ArrLayMaCBDaChon1 = value; }
        public List<string> ArrLayMaCBDaChon1 { get => arrLayMaCBDaChon; set => arrLayMaCBDaChon = value; }

        private void capNhapSoGhe(int makh,string macb, string soghe)
        {
            ecChonGhe.MAKH1 = makh;
            ecChonGhe.MaCB1 = macb;
            ecChonGhe.Soghe = soghe;
          
        }

        // Xu ly luu tru ghe
        int demsoghedangchon = 0;
        private void lblGhe_Click(object sender, EventArgs e)
        {
            // Label lblGhr = (Label)sender;
            Label lblGhr = (Label)sender;
            if (lblGhr.BackColor == Color.White)
            {
                demsoghedangchon++;
                lblGhr.BackColor = Color.Yellow;// mau dang chon

                foreach (Control a in pnGhe.Controls)
                {
                    if (lblGhr.Text == pnGhe.GetRow(a).ToString())
                    {
                        TableLayoutPanelCellPosition position = pnGhe.GetCellPosition(lblGhr);
                        DialogResult result = MessageBox.Show("Ghe chon:" + (pnGhe.GetControlFromPosition(position.Column, 0).Text + lblGhr.Text).ToString(), "THong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        // luu so ghe vao du lieu
                        if (result == DialogResult.OK)
                        {
                            arrLayGhe.Add((pnGhe.GetControlFromPosition(position.Column, 0).Text + lblGhr.Text).ToString());
                        }
                        else
                        {
                            lblGhr.BackColor = Color.White;
                            demsoghedangchon--;
                            demsoluong--;
                        }
                        break;
                    }
                    
                }
                demsoluong++;// 1

            }
            else if (lblGhr.BackColor == Color.Yellow)
            {
                lblGhr.BackColor = Color.White;// bo chon
                demsoghedangchon--;//0
                demsoluong--;//0
            }
            else if (lblGhr.BackColor == Color.Red)
            {
                lblGhr.Enabled = false;
            }

            if (demsoluong == frmKhachHang.demSoluongKHachDatVe)
            {
                int j = 0;
                int tam = 0;
                for (int i = 0; i < arrLayMaKH.Count; i++)// 2
                {
                    if (tam != arrLayMaKH[i])
                    {
                        InFile.laymakh = int.Parse(arrLayMaKH[0].ToString());
                        
                        
                            capNhapSoGhe(arrLayMaKH[i], arrLayMaCBDaChon[i], arrLayGhe[j].ToString());
                        
                        j++;
                        buschonghe.suaSoGhe(ecChonGhe);
                        tam = int.Parse(arrLayMaKH[i].ToString());
                    }
                }
                if (demCB == 2)
                {
                    pnGhe.Enabled = false;
                }
                else
                {
                    ReloadForm();
                  
                }
            }
            lblDangChon.Text = "ghe dang chon:" + demsoghedangchon.ToString();
        
    }
        private void ReloadForm()
        {
            // Lưu trữ dữ liệu trong các biến hoặc thuộc tính của form
            int savedData =demCB;
            
            // Tạo instance mới của form
            frmChonghe newForm = new frmChonghe();

            // Gán dữ liệu đã lưu trữ vào các trường (controls) tương ứng trên form mới
            newForm.demCB = savedData;
            newForm.arrLayMaCBDaChon.Add(arrLayMaCBDaChon[savedData]);
            newForm.arrLayMaKH.Add(arrLayMaKH[savedData]);
            if (demsoluong >= 2)
            {
                for (int i = 3; i < arrLayMaKH.Count; i++)// 4
                {
                    if (i % 2 != 0)
                    {
                        newForm.arrLayMaKH.Add(arrLayMaKH[i]);
                        newForm.ArrLayMaCBDaChon.Add(arrLayMaCBDaChon[savedData]);
                    }
                }
            }
            // Hiển thị form mới
            
            newForm.Show();
            MessageBox.Show("Vui lòng chọn ghế cho chuyến bay đi về trước khi in vé","Chú ý",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            this.Close();
        }
    

    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmChonghe_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            InFile hienthiFile = new InFile();
            this.Controls.Add(hienthiFile);
            hienthiFile.Width = 1000;
            hienthiFile.Height = 400;
            pnGhe.Visible = false;
            pnlKhungGhe.Visible = false;
            lblTenSoDo.Visible = false;
            pnlGhiChu.Visible = false;
        }

        private void pnGhe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblcontrongghe_Click(object sender, EventArgs e)
        {

        }
    }
}
