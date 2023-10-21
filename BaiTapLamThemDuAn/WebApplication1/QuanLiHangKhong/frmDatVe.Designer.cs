
namespace QuanLiHangKhong
{
    partial class frmDatVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatVe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSonguoi = new System.Windows.Forms.NumericUpDown();
            this.btnSearchCB = new System.Windows.Forms.Button();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPickerNgayVe = new System.Windows.Forms.DateTimePicker();
            this.datatimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbGaDen = new System.Windows.Forms.ComboBox();
            this.cbGaDi = new System.Windows.Forms.ComboBox();
            this.rdMotChieu = new System.Windows.Forms.RadioButton();
            this.rdKhuHoi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbChu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSonguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudSonguoi);
            this.groupBox1.Controls.Add(this.btnSearchCB);
            this.groupBox1.Controls.Add(this.lblNgayVe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTPickerNgayVe);
            this.groupBox1.Controls.Add(this.datatimeNgayDi);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbGaDen);
            this.groupBox1.Controls.Add(this.cbGaDi);
            this.groupBox1.Controls.Add(this.rdMotChieu);
            this.groupBox1.Controls.Add(this.rdKhuHoi);
            this.groupBox1.Location = new System.Drawing.Point(669, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyến bay";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số  người";
            // 
            // nudSonguoi
            // 
            this.nudSonguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSonguoi.Location = new System.Drawing.Point(121, 253);
            this.nudSonguoi.Name = "nudSonguoi";
            this.nudSonguoi.Size = new System.Drawing.Size(172, 31);
            this.nudSonguoi.TabIndex = 12;
            // 
            // btnSearchCB
            // 
            this.btnSearchCB.BackColor = System.Drawing.Color.Yellow;
            this.btnSearchCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCB.Location = new System.Drawing.Point(97, 317);
            this.btnSearchCB.Name = "btnSearchCB";
            this.btnSearchCB.Size = new System.Drawing.Size(149, 40);
            this.btnSearchCB.TabIndex = 11;
            this.btnSearchCB.Text = "Tìm chuyến bay";
            this.btnSearchCB.UseVisualStyleBackColor = false;
            this.btnSearchCB.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVe.Location = new System.Drawing.Point(0, 215);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(91, 25);
            this.lblNgayVe.TabIndex = 10;
            this.lblNgayVe.Text = "Ngày về";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày đi";
            // 
            // dTPickerNgayVe
            // 
            this.dTPickerNgayVe.CustomFormat = "yyyy-MM-dd";
            this.dTPickerNgayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerNgayVe.Location = new System.Drawing.Point(97, 210);
            this.dTPickerNgayVe.Name = "dTPickerNgayVe";
            this.dTPickerNgayVe.Size = new System.Drawing.Size(202, 31);
            this.dTPickerNgayVe.TabIndex = 7;
            // 
            // datatimeNgayDi
            // 
            this.datatimeNgayDi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatimeNgayDi.CustomFormat = "yyyy-MM-dd";
            this.datatimeNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datatimeNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datatimeNgayDi.Location = new System.Drawing.Point(86, 144);
            this.datatimeNgayDi.Name = "datatimeNgayDi";
            this.datatimeNgayDi.Size = new System.Drawing.Size(213, 31);
            this.datatimeNgayDi.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbGaDen
            // 
            this.cbGaDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGaDen.FormattingEnabled = true;
            this.cbGaDen.Items.AddRange(new object[] {
            "DIN",
            "HUI",
            "CXR",
            "HPH",
            "DAD",
            "UIH",
            "BMV",
            "VII",
            "CAH",
            "DLI",
            "PQC",
            "SGN",
            "PXU"});
            this.cbGaDen.Location = new System.Drawing.Point(45, 105);
            this.cbGaDen.Name = "cbGaDen";
            this.cbGaDen.Size = new System.Drawing.Size(254, 33);
            this.cbGaDen.TabIndex = 3;
            this.cbGaDen.Text = "          Điểm đến";
            // 
            // cbGaDi
            // 
            this.cbGaDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGaDi.ForeColor = System.Drawing.Color.Red;
            this.cbGaDi.FormattingEnabled = true;
            this.cbGaDi.Items.AddRange(new object[] {
            "Tp. Hồ Chí Minh (SGN)",
            "Đà Nẵng (DAD)",
            "Hà Nội (HAN)",
            "Vinh(VII)",
            "Pleiku (PXU)",
            "Quy Nhơn (UIH)"});
            this.cbGaDi.Location = new System.Drawing.Point(45, 56);
            this.cbGaDi.Name = "cbGaDi";
            this.cbGaDi.Size = new System.Drawing.Size(254, 33);
            this.cbGaDi.TabIndex = 2;
            this.cbGaDi.Text = "      Điểm khởi hành";
            this.cbGaDi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdMotChieu
            // 
            this.rdMotChieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdMotChieu.AutoSize = true;
            this.rdMotChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMotChieu.Location = new System.Drawing.Point(155, 19);
            this.rdMotChieu.Name = "rdMotChieu";
            this.rdMotChieu.Size = new System.Drawing.Size(114, 28);
            this.rdMotChieu.TabIndex = 1;
            this.rdMotChieu.Text = "Một Chiều";
            this.rdMotChieu.UseVisualStyleBackColor = true;
            this.rdMotChieu.CheckedChanged += new System.EventHandler(this.rdMotChieu_CheckedChanged);
            // 
            // rdKhuHoi
            // 
            this.rdKhuHoi.AutoSize = true;
            this.rdKhuHoi.Checked = true;
            this.rdKhuHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKhuHoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdKhuHoi.Location = new System.Drawing.Point(6, 19);
            this.rdKhuHoi.Name = "rdKhuHoi";
            this.rdKhuHoi.Size = new System.Drawing.Size(93, 28);
            this.rdKhuHoi.TabIndex = 0;
            this.rdKhuHoi.TabStop = true;
            this.rdKhuHoi.Text = "Khứ hồi";
            this.rdKhuHoi.UseVisualStyleBackColor = true;
            this.rdKhuHoi.CheckedChanged += new System.EventHandler(this.rdKhuHoi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(974, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Công ty Cổ Phần hàng không Việt Nam";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gpbChu
            // 
            this.gpbChu.Controls.Add(this.dataGridView1);
            this.gpbChu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbChu.Location = new System.Drawing.Point(0, 33);
            this.gpbChu.Name = "gpbChu";
            this.gpbChu.Size = new System.Drawing.Size(608, 430);
            this.gpbChu.TabIndex = 3;
            this.gpbChu.TabStop = false;
            this.gpbChu.Text = "Bảng chọn chuyến bay ";
            this.gpbChu.Visible = false;
            this.gpbChu.Enter += new System.EventHandler(this.gpbChu_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.GaDi,
            this.Gaden,
            this.Column6,
            this.Column3,
            this.ChiPhI});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaCB";
            this.Column1.FillWeight = 60.44989F;
            this.Column1.HeaderText = "Mã Chuyến Bay";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GaDi
            // 
            this.GaDi.DataPropertyName = "GaDi";
            this.GaDi.HeaderText = "Ga Đi";
            this.GaDi.Name = "GaDi";
            // 
            // Gaden
            // 
            this.Gaden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gaden.DataPropertyName = "GaDen";
            this.Gaden.FillWeight = 58.93607F;
            this.Gaden.HeaderText = "Ga Đến";
            this.Gaden.Name = "Gaden";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "GioDi";
            this.Column6.FillWeight = 58.93607F;
            this.Column6.HeaderText = "Giờ Đi";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "GioDen";
            this.Column3.FillWeight = 58.93607F;
            this.Column3.HeaderText = "Giờ Đến";
            this.Column3.Name = "Column3";
            // 
            // ChiPhI
            // 
            this.ChiPhI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChiPhI.DataPropertyName = "giave";
            this.ChiPhI.FillWeight = 99.74577F;
            this.ChiPhI.HeaderText = "Gia vé(chưa thuế)";
            this.ChiPhI.Name = "ChiPhI";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(974, 54);
            this.label6.TabIndex = 14;
            this.label6.Text = "Copyright © Công Ty Cổ Phần Hàng Không Việt Nam";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 517);
            this.Controls.Add(this.gpbChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatVe";
            this.Text = "frmDatVe";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSonguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdKhuHoi;
        private System.Windows.Forms.ComboBox cbGaDi;
        private System.Windows.Forms.ComboBox cbGaDen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPickerNgayVe;
        private System.Windows.Forms.DateTimePicker datatimeNgayDi;
        private System.Windows.Forms.Button btnSearchCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbChu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSonguoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdMotChieu;
    }
}