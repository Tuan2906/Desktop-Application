using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHangKhongBUS;
using QuanLyHangKhongDAL;
using QuanLyHangKhongEntity;
namespace QuanLiHangKhong
{
    public partial class frmDatVe : Form
    {
        Bus_tableKhachHang1 busVeMua = new Bus_tableKhachHang1();
        Bus_tableChuyenBay busChuyenBay = new Bus_tableChuyenBay();
    
        public frmDatVe()
        {
            InitializeComponent();
        }
        private void show(string dieukien)
        {
            cbGaDi.DataSource = busChuyenBay.LayThongTin(dieukien);
            cbGaDi.DisplayMember = "gaDi";
            cbGaDi.ValueMember= "gaDi";
            cbGaDen.DataSource = busChuyenBay.LayThongTinGaDen(dieukien);
            cbGaDen.DisplayMember = "gaDen";
            cbGaDen.ValueMember = "gaDen";
           
        }
        private void showChuyenBay(string dieukien)
        {
            dataGridView1.DataSource = busChuyenBay.TaoBang(dieukien);
        }
        private void showKhuHoi(string dieuKien)
        {
            dataGridView1.DataSource = busChuyenBay.LayThongTinKhuHoi(dieuKien);
        }
        
        
  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            //show("");
           // gpbChu.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gpbChu.Visible = true;
            try
            {
                if (nudSonguoi.Value <= 0)
                {
                    MessageBox.Show("So nguoi phai it nhat 1 nguoi", "Thong bao!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                if (rdKhuHoi.Checked)
                {



                    showKhuHoi("select Gaden,Gadi from chuyenbay group by Gaden,Gadi having GaDen like" + "'%" + cbGaDen.SelectedItem + "%'" + "or GaDi like" + "'%" + cbGaDen.SelectedItem + "%'" + ")B on A.GaDi = B.GaDen and A.GaDen = B.GaDi where A.GioDi like" + "'%" + datatimeNgayDi.Text + "%' or A.GioDi like"+ "'%"+dTPickerNgayVe.Text+"%'");// dad
                    int indx = dataGridView1.CurrentCell.RowIndex;
                    for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
                    {
                        if (!dataGridView1.Rows[row].Cells[2].Value.ToString().Contains((string)cbGaDen.SelectedItem))// kiem tra ko co khu hoi 
                        {
                            gpbChu.Visible = false;
                            MessageBox.Show("Chua cập nhật dữ liệu cho chuyen di khu hoi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            gpbChu.Visible = true;
                            showKhuHoi("select Gaden,Gadi  from chuyenbay group by Gaden,Gadi having GaDen like" + "'%"+
                                cbGaDen.SelectedItem +"%'" + "or GaDi like" +"'%"+cbGaDen.SelectedItem + "%'"+")B " +
                                "on A.GaDi = B.GaDen and A.GaDen = B.GaDi where A.GioDi like"+ "'%"+
                                datatimeNgayDi.Text+"%' or A.GioDi like"+ "'%"+dTPickerNgayVe.Text+"%'");
                           
                            break;
                        }

                    }


                }
                else if (rdMotChieu.Checked)
                {

                    showChuyenBay("GaDi like '%" + cbGaDi.SelectedItem + "%'and GaDen like'%" + cbGaDen.SelectedItem + "%'and date(gioDi) like'%" + datatimeNgayDi.Text + "%'");
                   
                    if (dataGridView1.Rows.Count == 1)
                    {
                        MessageBox.Show("Chua cập nhật dữ liệu cho chuyen di nay !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                }
            }
            catch (Exception ex)
            {
                gpbChu.Visible = false;
               
                MessageBox.Show("Khong tim thay","Thong bao!!!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);  
            }
           
            
        }

        private void rdKhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            lblNgayVe.Visible = true;
            dTPickerNgayVe.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (dataGridView1.RowCount <= 1)
            {
                MessageBox.Show("DON'T CLICK FIRST ROW", "CẢNH BÁO LỖI!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                frmKhachHang frmKhachHang = new frmKhachHang();
                for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
                {
                    frmKhachHang.MaCB = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    frmKhachHang.gaDi = dataGridView1.Rows[row].Cells[1].Value.ToString();
                    frmKhachHang.gaDen = dataGridView1.Rows[row].Cells[2].Value.ToString();
                    frmKhachHang.soTien.Add(double.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString()));
                    frmKhachHang.ArrLuu.Add(frmKhachHang.MaCB);
                    
                }
                frmKhachHang.demSoluongKHachDatVe = int.Parse(nudSonguoi.Value.ToString());
                if (rdKhuHoi.Checked)
                {
                    frmKhachHang.check = false;

                    frmKhachHang.loaive = rdKhuHoi.Text;
                   // frmKhachHang.demSoluongKHachDatVe = int.Parse(nudSonguoi.Value.ToString())*2;
                }
                if (rdMotChieu.Checked)
                {
                    frmKhachHang.loaive = rdMotChieu.Text;
                }
                frmKhachHang.ShowDialog();
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("DON'T CLICK FIRST ROW", "CẢNH BÁO LỖI!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gpbChu_Enter(object sender, EventArgs e)
        {

        }

        private void rdMotChieu_CheckedChanged(object sender, EventArgs e)
        {
            dTPickerNgayVe.Visible = false; ;
            lblNgayVe.Visible = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
