
namespace BaiTapVeNha
{
    partial class fParent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParent));
            this.lblDN = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblThanhNgang = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDN
            // 
            this.lblDN.BackColor = System.Drawing.Color.Blue;
            this.lblDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.ForeColor = System.Drawing.Color.White;
            this.lblDN.Location = new System.Drawing.Point(369, -4);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(211, 31);
            this.lblDN.TabIndex = 4;
            this.lblDN.Text = "\r\n";
            this.lblDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDN.Visible = false;
            this.lblDN.Click += new System.EventHandler(this.label2_Click);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBall.BackgroundImage")));
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBall.Location = new System.Drawing.Point(12, 12);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(100, 50);
            this.picBall.TabIndex = 6;
            this.picBall.TabStop = false;
            this.picBall.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblThanhNgang
            // 
            this.lblThanhNgang.BackColor = System.Drawing.Color.Blue;
            this.lblThanhNgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhNgang.ForeColor = System.Drawing.Color.White;
            this.lblThanhNgang.Location = new System.Drawing.Point(175, 348);
            this.lblThanhNgang.Name = "lblThanhNgang";
            this.lblThanhNgang.Size = new System.Drawing.Size(211, 31);
            this.lblThanhNgang.TabIndex = 7;
            this.lblThanhNgang.Text = "\r\n";
            this.lblThanhNgang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThanhNgang.Visible = false;
            this.lblThanhNgang.Click += new System.EventHandler(this.lblThanhNgang_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(266, 167);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(0, 34);
            this.lblLose.TabIndex = 8;
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLose.UseCompatibleTextRendering = true;
            this.lblLose.Visible = false;
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(232, 167);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(84, 33);
            this.btnChoiLai.TabIndex = 9;
            this.btnChoiLai.Text = "Choi Lai";
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Visible = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 11;
            this.label1.Visible = false;
            // 
            // fParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblThanhNgang);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.lblDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblThanhNgang;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}