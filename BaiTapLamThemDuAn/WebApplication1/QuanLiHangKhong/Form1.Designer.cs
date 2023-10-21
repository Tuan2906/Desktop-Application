
namespace QuanLiHangKhong
{
    partial class frmChonghe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblHetCho = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlGhiChu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDangChon = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblcontrongghe = new System.Windows.Forms.Label();
            this.pnGhe = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKhungGhe = new System.Windows.Forms.Panel();
            this.lblTenSoDo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLayGhe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGhiChu.SuspendLayout();
            this.pnlKhungGhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ghi Chú";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHetCho
            // 
            this.lblHetCho.AutoSize = true;
            this.lblHetCho.Location = new System.Drawing.Point(67, 43);
            this.lblHetCho.Name = "lblHetCho";
            this.lblHetCho.Size = new System.Drawing.Size(45, 13);
            this.lblHetCho.TabIndex = 1;
            this.lblHetCho.Text = "Hết chỗ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(5, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlGhiChu
            // 
            this.pnlGhiChu.Controls.Add(this.button3);
            this.pnlGhiChu.Controls.Add(this.lblDangChon);
            this.pnlGhiChu.Controls.Add(this.button2);
            this.pnlGhiChu.Controls.Add(this.lblcontrongghe);
            this.pnlGhiChu.Controls.Add(this.button1);
            this.pnlGhiChu.Controls.Add(this.lblHetCho);
            this.pnlGhiChu.Controls.Add(this.label1);
            this.pnlGhiChu.Location = new System.Drawing.Point(672, 17);
            this.pnlGhiChu.Name = "pnlGhiChu";
            this.pnlGhiChu.Size = new System.Drawing.Size(266, 183);
            this.pnlGhiChu.TabIndex = 3;
            this.pnlGhiChu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(5, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 29);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblDangChon
            // 
            this.lblDangChon.AutoSize = true;
            this.lblDangChon.Location = new System.Drawing.Point(67, 123);
            this.lblDangChon.Name = "lblDangChon";
            this.lblDangChon.Size = new System.Drawing.Size(60, 13);
            this.lblDangChon.TabIndex = 5;
            this.lblDangChon.Text = "Đang chọn";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(5, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 29);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblcontrongghe
            // 
            this.lblcontrongghe.AutoSize = true;
            this.lblcontrongghe.Location = new System.Drawing.Point(67, 78);
            this.lblcontrongghe.Name = "lblcontrongghe";
            this.lblcontrongghe.Size = new System.Drawing.Size(53, 13);
            this.lblcontrongghe.TabIndex = 3;
            this.lblcontrongghe.Text = "Còn trống";
            this.lblcontrongghe.Click += new System.EventHandler(this.lblcontrongghe_Click);
            // 
            // pnGhe
            // 
            this.pnGhe.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.pnGhe.ColumnCount = 6;
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93989F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93989F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93989F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39344F));
            this.pnGhe.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnGhe.Location = new System.Drawing.Point(0, 0);
            this.pnGhe.Name = "pnGhe";
            this.pnGhe.RowCount = 17;
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.729167F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.989583F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.365771F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.365771F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.365771F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.365771F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.365771F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.046651F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.146644F));
            this.pnGhe.Size = new System.Drawing.Size(363, 386);
            this.pnGhe.TabIndex = 4;
            this.pnGhe.Click += new System.EventHandler(this.lblGhe_Click);
            this.pnGhe.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlKhungGhe
            // 
            this.pnlKhungGhe.Controls.Add(this.pnGhe);
            this.pnlKhungGhe.Location = new System.Drawing.Point(76, 60);
            this.pnlKhungGhe.Name = "pnlKhungGhe";
            this.pnlKhungGhe.Size = new System.Drawing.Size(368, 386);
            this.pnlKhungGhe.TabIndex = 5;
            this.pnlKhungGhe.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTenSoDo
            // 
            this.lblTenSoDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSoDo.Location = new System.Drawing.Point(76, 9);
            this.lblTenSoDo.Name = "lblTenSoDo";
            this.lblTenSoDo.Size = new System.Drawing.Size(404, 48);
            this.lblTenSoDo.TabIndex = 8;
            this.lblTenSoDo.Text = "Sơ đồ chỗ ngồi trên máy bay";
            this.lblTenSoDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(857, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 42);
            this.button4.TabIndex = 34;
            this.button4.Text = "In vé";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.Location = new System.Drawing.Point(757, 413);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(77, 42);
            this.btnThanhToan.TabIndex = 29;
            this.btnThanhToan.Text = "Thanh toan";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "soGhe";
            this.Column1.HeaderText = "So Ghe";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataLayGhe
            // 
            this.dataLayGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLayGhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataLayGhe.Location = new System.Drawing.Point(594, 244);
            this.dataLayGhe.Name = "dataLayGhe";
            this.dataLayGhe.Size = new System.Drawing.Size(240, 62);
            this.dataLayGhe.TabIndex = 7;
            this.dataLayGhe.Visible = false;
            this.dataLayGhe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Thiết kế bởi Nguyễn Châu Tuấn";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(576, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "Copyright © Công Ty Cổ Phần Hàng Không Việt Nam";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChonghe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTenSoDo);
            this.Controls.Add(this.dataLayGhe);
            this.Controls.Add(this.pnlKhungGhe);
            this.Controls.Add(this.pnlGhiChu);
            this.Name = "frmChonghe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChonghe_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGhiChu.ResumeLayout(false);
            this.pnlGhiChu.PerformLayout();
            this.pnlKhungGhe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayGhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHetCho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlGhiChu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDangChon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblcontrongghe;
        private System.Windows.Forms.TableLayoutPanel pnGhe;
        private System.Windows.Forms.Panel pnlKhungGhe;
        private System.Windows.Forms.Label lblTenSoDo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataLayGhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

