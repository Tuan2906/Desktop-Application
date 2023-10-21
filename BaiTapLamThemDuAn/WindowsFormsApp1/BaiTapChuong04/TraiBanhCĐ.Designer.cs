
namespace BaiTapChuong04
{
    partial class TraiBanhCĐ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraiBanhCĐ));
            this.picConChim = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picConChim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // picConChim
            // 
            this.picConChim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picConChim.BackgroundImage")));
            this.picConChim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConChim.Location = new System.Drawing.Point(111, 69);
            this.picConChim.Name = "picConChim";
            this.picConChim.Size = new System.Drawing.Size(81, 41);
            this.picConChim.TabIndex = 0;
            this.picConChim.TabStop = false;
            this.picConChim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(238, 60);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 50);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // TraiBanhCĐ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.picConChim);
            this.Name = "TraiBanhCĐ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picConChim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picConChim;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Timer timer1;
    }
}

