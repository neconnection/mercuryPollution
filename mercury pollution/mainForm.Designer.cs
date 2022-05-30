namespace mercuryPollution
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.egoldsCard3 = new mercuryPollution.EgoldsCard();
            this.egoldsCard1 = new mercuryPollution.EgoldsCard();
            this.egoldsCard2 = new mercuryPollution.EgoldsCard();
            this.roundingButtonsComponent = new mercuryPollution.Components.RoundingButtonsComponent(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windowcustom = new mercuryPollution.Components.windowcustom(this.components);
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.context.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbStyle);
            this.panel1.Location = new System.Drawing.Point(264, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 624);
            this.panel1.TabIndex = 11;
            // 
            // cmbStyle
            // 
            this.cmbStyle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(14, 558);
            this.cmbStyle.Margin = new System.Windows.Forms.Padding(5);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(217, 24);
            this.cmbStyle.TabIndex = 15;
            this.cmbStyle.Visible = false;
            // 
            // egoldsCard3
            // 
            this.egoldsCard3.BackColor = System.Drawing.Color.MistyRose;
            this.egoldsCard3.BackColorCurtain = System.Drawing.Color.RosyBrown;
            this.egoldsCard3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egoldsCard3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard3.FontDescrition = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard3.FontHeader = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard3.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard3.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard3.Location = new System.Drawing.Point(11, 229);
            this.egoldsCard3.Margin = new System.Windows.Forms.Padding(5);
            this.egoldsCard3.Name = "egoldsCard3";
            this.egoldsCard3.Rounding = 70;
            this.egoldsCard3.RoundingEnable = true;
            this.egoldsCard3.Size = new System.Drawing.Size(234, 196);
            this.egoldsCard3.TabIndex = 18;
            this.egoldsCard3.Text = "Работа с базой данных.";
            this.egoldsCard3.TextDescrition = "В этом разделе производится работа с базой данных.";
            this.egoldsCard3.TextHeader = "База данных";
            this.egoldsCard3.Click += new System.EventHandler(this.egoldsCard3_Click);
            // 
            // egoldsCard1
            // 
            this.egoldsCard1.BackColor = System.Drawing.Color.MistyRose;
            this.egoldsCard1.BackColorCurtain = System.Drawing.Color.RosyBrown;
            this.egoldsCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egoldsCard1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard1.FontDescrition = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard1.FontHeader = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard1.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard1.ForeColorHeader = System.Drawing.Color.WhiteSmoke;
            this.egoldsCard1.Location = new System.Drawing.Point(11, 11);
            this.egoldsCard1.Margin = new System.Windows.Forms.Padding(5);
            this.egoldsCard1.Name = "egoldsCard1";
            this.egoldsCard1.Rounding = 70;
            this.egoldsCard1.RoundingEnable = true;
            this.egoldsCard1.Size = new System.Drawing.Size(234, 196);
            this.egoldsCard1.TabIndex = 16;
            this.egoldsCard1.Text = "Работа с картой.";
            this.egoldsCard1.TextDescrition = "В этом разделе можно выполнить работы с картой.";
            this.egoldsCard1.TextHeader = "Карта";
            this.egoldsCard1.Click += new System.EventHandler(this.egoldsCard1_Click);
            // 
            // egoldsCard2
            // 
            this.egoldsCard2.BackColor = System.Drawing.Color.MistyRose;
            this.egoldsCard2.BackColorCurtain = System.Drawing.Color.RosyBrown;
            this.egoldsCard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egoldsCard2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard2.FontDescrition = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard2.FontHeader = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard2.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard2.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard2.Location = new System.Drawing.Point(11, 450);
            this.egoldsCard2.Margin = new System.Windows.Forms.Padding(5);
            this.egoldsCard2.Name = "egoldsCard2";
            this.egoldsCard2.Rounding = 70;
            this.egoldsCard2.RoundingEnable = true;
            this.egoldsCard2.Size = new System.Drawing.Size(234, 196);
            this.egoldsCard2.TabIndex = 17;
            this.egoldsCard2.Text = "Информация о проекте.";
            this.egoldsCard2.TextDescrition = "В этом разделе можно узнать о проекте.";
            this.egoldsCard2.TextHeader = "Информация";
            this.egoldsCard2.Click += new System.EventHandler(this.egoldsCard2_Click);
            // 
            // roundingButtonsComponent
            // 
            this.roundingButtonsComponent.Rounding = 70;
            this.roundingButtonsComponent.RoundingEnable = true;
            this.roundingButtonsComponent.TargetForm = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(-23, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 660);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox2.Image = global::yt_DesignUI.Properties.Resources.server;
            this.pictureBox2.Location = new System.Drawing.Point(198, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 49);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox3.Image = global::yt_DesignUI.Properties.Resources.information;
            this.pictureBox3.Location = new System.Drawing.Point(198, 457);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 50);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Image = global::yt_DesignUI.Properties.Resources.map;
            this.pictureBox1.Location = new System.Drawing.Point(196, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // windowcustom
            // 
            this.windowcustom.AllowUserResize = true;
            this.windowcustom.BackColor = System.Drawing.Color.DarkGray;
            this.windowcustom.ContextMenuForm = this.context;
            this.windowcustom.ControlBoxButtonsWidth = 36;
            this.windowcustom.EnableControlBoxIconsLight = false;
            this.windowcustom.EnableControlBoxMouseLight = false;
            this.windowcustom.Form = this;
            this.windowcustom.FormStyle = mercuryPollution.Components.windowcustom.fStyle.UserStyle;
            this.windowcustom.HeaderColor = System.Drawing.Color.DarkGray;
            this.windowcustom.HeaderColorAdditional = System.Drawing.Color.RosyBrown;
            this.windowcustom.HeaderColorGradientEnable = true;
            this.windowcustom.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.windowcustom.HeaderHeight = 28;
            this.windowcustom.HeaderImage = global::yt_DesignUI.Properties.Resources.air_pollution;
            this.windowcustom.HeaderTextColor = System.Drawing.Color.Black;
            this.windowcustom.HeaderTextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // context
            // 
            this.context.BackColor = System.Drawing.Color.Transparent;
            this.context.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(188, 82);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Image = global::yt_DesignUI.Properties.Resources.map;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.toolStripMenuItem1.Text = "Карта";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem2.Image = global::yt_DesignUI.Properties.Resources.server;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 26);
            this.toolStripMenuItem2.Text = "База данных";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Image = global::yt_DesignUI.Properties.Resources.information;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 26);
            this.toolStripMenuItem3.Text = "Информация";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.context;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "mercuryPollution";
            this.notifyIcon.Visible = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1539, 658);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.egoldsCard3);
            this.Controls.Add(this.egoldsCard1);
            this.Controls.Add(this.egoldsCard2);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mercuyPollution";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.context.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStyle;
        private EgoldsCard egoldsCard1;
        private EgoldsCard egoldsCard2;
        private EgoldsCard egoldsCard3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Components.windowcustom windowcustom;
        private Components.RoundingButtonsComponent roundingButtonsComponent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}