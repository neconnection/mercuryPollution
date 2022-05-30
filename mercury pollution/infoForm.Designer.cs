namespace yt_DesignUI
{
    partial class infoForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            //this.label1 = new System.Windows.Forms.Label();
            this.transparentPanel3 = new yt_DesignUI.TransparentPanel();
            this.transparentPanel4 = new yt_DesignUI.TransparentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::yt_DesignUI.Properties.Resources.dust;
            this.pictureBox1.Location = new System.Drawing.Point(794, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 643);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            //this.label1.AutoSize = true;
            //this.label1.BackColor = System.Drawing.Color.Transparent;
            //this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.label1.Image = global::yt_DesignUI.Properties.Resources.air_pollution;
            //this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            //this.label1.Location = new System.Drawing.Point(-2, 1);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(358, 49);
            //this.label1.TabIndex = 2;
            //this.label1.Text = "mercury Pollution";
            // 
            // transparentPanel3
            // 
            this.transparentPanel3.Location = new System.Drawing.Point(7, 92);
            this.transparentPanel3.Name = "transparentPanel3";
            this.transparentPanel3.Size = new System.Drawing.Size(349, 705);
            this.transparentPanel3.TabIndex = 3;
            // 
            // transparentPanel4
            // 
            this.transparentPanel4.Location = new System.Drawing.Point(369, 1);
            this.transparentPanel4.Name = "transparentPanel4";
            this.transparentPanel4.Size = new System.Drawing.Size(803, 796);
            this.transparentPanel4.TabIndex = 4;
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1471, 820);
            this.Controls.Add(this.transparentPanel4);
            this.Controls.Add(this.transparentPanel3);
           // this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "infoForm";
            this.Text = "infoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private yt_DesignUI.TransparentPanel transparentPanel3;
        private yt_DesignUI.TransparentPanel transparentPanel4;
    }
}