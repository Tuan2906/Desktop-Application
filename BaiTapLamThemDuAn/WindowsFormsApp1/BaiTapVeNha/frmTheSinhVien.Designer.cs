
namespace BaiTapVeNha
{
    partial class frmTheSinhVien
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
            this.picThe = new System.Windows.Forms.PictureBox();
            this.lblMau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picThe)).BeginInit();
            this.SuspendLayout();
            // 
            // picThe
            // 
            this.picThe.Location = new System.Drawing.Point(12, 12);
            this.picThe.Name = "picThe";
            this.picThe.Size = new System.Drawing.Size(139, 108);
            this.picThe.TabIndex = 0;
            this.picThe.TabStop = false;
            this.picThe.Paint += new System.Windows.Forms.PaintEventHandler(this.picThe_Paint);
            // 
            // lblMau
            // 
            this.lblMau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMau.Location = new System.Drawing.Point(31, 24);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(107, 23);
            this.lblMau.TabIndex = 1;
            // 
            // frmTheSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMau);
            this.Controls.Add(this.picThe);
            this.Name = "frmTheSinhVien";
            this.Text = "frmTheSinhVien";
            this.Load += new System.EventHandler(this.frmTheSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThe;
        private System.Windows.Forms.Label lblMau;
    }
}