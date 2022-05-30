namespace yt_DesignUI
{
    partial class mapForm
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.popup = new Tulpep.NotificationWindow.PopupNotifier();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yt_Button6 = new mercuryPollution.yt_Button();
            this.yt_Button5 = new mercuryPollution.yt_Button();
            this.yt_Button4 = new mercuryPollution.yt_Button();
            this.yt_Button2 = new mercuryPollution.yt_Button();
            this.yt_Button1 = new mercuryPollution.yt_Button();
            this.yt_Button3 = new mercuryPollution.yt_Button();
            this.roundingButtonsComponent = new mercuryPollution.Components.RoundingButtonsComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.LightSlateGray;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(1, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1348, 488);
            this.gMapControl1.TabIndex = 24;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // popup
            // 
            this.popup.ContentFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popup.ContentText = null;
            this.popup.Image = null;
            this.popup.IsRightToLeft = false;
            this.popup.OptionsMenu = null;
            this.popup.ShowCloseButton = false;
            this.popup.Size = new System.Drawing.Size(400, 100);
            this.popup.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popup.TitleText = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::yt_DesignUI.Properties.Resources.location;
            this.pictureBox2.Location = new System.Drawing.Point(29, 574);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 41);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::yt_DesignUI.Properties.Resources.math;
            this.pictureBox1.Location = new System.Drawing.Point(1072, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // yt_Button6
            // 
            this.yt_Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button6.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button6.BackColorAdditional = System.Drawing.SystemColors.ButtonShadow;
            this.yt_Button6.BackColorGradientEnabled = true;
            this.yt_Button6.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button6.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button6.BorderColorEnabled = false;
            this.yt_Button6.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button6.BorderColorOnHoverEnabled = false;
            this.yt_Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button6.Location = new System.Drawing.Point(11, 498);
            this.yt_Button6.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button6.Name = "yt_Button6";
            this.yt_Button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yt_Button6.RippleColor = System.Drawing.Color.Black;
            this.yt_Button6.Rounding = 40;
            this.yt_Button6.RoundingEnable = true;
            this.yt_Button6.Size = new System.Drawing.Size(325, 57);
            this.yt_Button6.TabIndex = 27;
            this.yt_Button6.Text = "Выбор точек";
            this.yt_Button6.TextHover = "Выбор опорных точек для визуализации.";
            this.yt_Button6.UseDownPressEffectOnClick = true;
            this.yt_Button6.UseRippleEffect = true;
            this.yt_Button6.UseZoomEffectOnHover = true;
            this.yt_Button6.Click += new System.EventHandler(this.yt_Button6_Click);
            // 
            // yt_Button5
            // 
            this.yt_Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button5.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button5.BackColorAdditional = System.Drawing.SystemColors.ButtonShadow;
            this.yt_Button5.BackColorGradientEnabled = true;
            this.yt_Button5.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button5.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button5.BorderColorEnabled = false;
            this.yt_Button5.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button5.BorderColorOnHoverEnabled = false;
            this.yt_Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button5.Location = new System.Drawing.Point(106, 562);
            this.yt_Button5.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button5.Name = "yt_Button5";
            this.yt_Button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yt_Button5.RippleColor = System.Drawing.Color.Black;
            this.yt_Button5.Rounding = 40;
            this.yt_Button5.RoundingEnable = true;
            this.yt_Button5.Size = new System.Drawing.Size(325, 57);
            this.yt_Button5.TabIndex = 26;
            this.yt_Button5.Text = "Отобразить источник загрязнения";
            this.yt_Button5.TextHover = "Отображает источник загрязнения на карте.";
            this.yt_Button5.UseDownPressEffectOnClick = true;
            this.yt_Button5.UseRippleEffect = true;
            this.yt_Button5.UseZoomEffectOnHover = true;
            this.yt_Button5.Click += new System.EventHandler(this.yt_Button5_Click);
            // 
            // yt_Button4
            // 
            this.yt_Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button4.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button4.BackColorAdditional = System.Drawing.SystemColors.ButtonShadow;
            this.yt_Button4.BackColorGradientEnabled = true;
            this.yt_Button4.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button4.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button4.BorderColorEnabled = false;
            this.yt_Button4.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button4.BorderColorOnHoverEnabled = false;
            this.yt_Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button4.Location = new System.Drawing.Point(811, 562);
            this.yt_Button4.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button4.Name = "yt_Button4";
            this.yt_Button4.RippleColor = System.Drawing.Color.Black;
            this.yt_Button4.Rounding = 40;
            this.yt_Button4.RoundingEnable = true;
            this.yt_Button4.Size = new System.Drawing.Size(325, 57);
            this.yt_Button4.TabIndex = 25;
            this.yt_Button4.Text = "Скрыть точки";
            this.yt_Button4.TextHover = "Скрыть точки пробоотбора с карты.";
            this.yt_Button4.UseDownPressEffectOnClick = true;
            this.yt_Button4.UseRippleEffect = true;
            this.yt_Button4.UseZoomEffectOnHover = true;
            this.yt_Button4.Click += new System.EventHandler(this.yt_Button4_Click);
            // 
            // yt_Button2
            // 
            this.yt_Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button2.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button2.BackColorAdditional = System.Drawing.SystemColors.ButtonShadow;
            this.yt_Button2.BackColorGradientEnabled = true;
            this.yt_Button2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button2.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorEnabled = false;
            this.yt_Button2.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorOnHoverEnabled = false;
            this.yt_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button2.Location = new System.Drawing.Point(723, 498);
            this.yt_Button2.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.RippleColor = System.Drawing.Color.Black;
            this.yt_Button2.Rounding = 40;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(325, 57);
            this.yt_Button2.TabIndex = 23;
            this.yt_Button2.Text = "Экспортировать";
            this.yt_Button2.TextHover = "Экспорт карты в формате .PNG";
            this.yt_Button2.UseDownPressEffectOnClick = true;
            this.yt_Button2.UseRippleEffect = true;
            this.yt_Button2.UseZoomEffectOnHover = true;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
            // 
            // yt_Button1
            // 
            this.yt_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button1.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button1.BackColorAdditional = System.Drawing.SystemColors.ButtonShadow;
            this.yt_Button1.BackColorGradientEnabled = true;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button1.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button1.Location = new System.Drawing.Point(367, 498);
            this.yt_Button1.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.Rounding = 40;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(325, 57);
            this.yt_Button1.TabIndex = 22;
            this.yt_Button1.Text = "Рассчитать";
            this.yt_Button1.TextHover = "Расчёт визуализации полей загрязнения.";
            this.yt_Button1.UseDownPressEffectOnClick = true;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = true;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // yt_Button3
            // 
            this.yt_Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button3.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button3.BackColorAdditional = System.Drawing.SystemColors.ButtonShadow;
            this.yt_Button3.BackColorGradientEnabled = true;
            this.yt_Button3.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button3.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button3.BorderColorEnabled = false;
            this.yt_Button3.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button3.BorderColorOnHoverEnabled = false;
            this.yt_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button3.Location = new System.Drawing.Point(459, 563);
            this.yt_Button3.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button3.Name = "yt_Button3";
            this.yt_Button3.RippleColor = System.Drawing.Color.Black;
            this.yt_Button3.Rounding = 40;
            this.yt_Button3.RoundingEnable = true;
            this.yt_Button3.Size = new System.Drawing.Size(325, 57);
            this.yt_Button3.TabIndex = 21;
            this.yt_Button3.Text = "Отобразить точки";
            this.yt_Button3.TextHover = "Отображение точек пробоотбора на карте.";
            this.yt_Button3.UseDownPressEffectOnClick = true;
            this.yt_Button3.UseRippleEffect = true;
            this.yt_Button3.UseZoomEffectOnHover = true;
            this.yt_Button3.Click += new System.EventHandler(this.yt_Button3_Click);
            // 
            // roundingButtonsComponent
            // 
            this.roundingButtonsComponent.Rounding = 40;
            this.roundingButtonsComponent.RoundingEnable = true;
            this.roundingButtonsComponent.TargetForm = this;
            // 
            // mapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1358, 643);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yt_Button6);
            this.Controls.Add(this.yt_Button5);
            this.Controls.Add(this.yt_Button4);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.yt_Button2);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.yt_Button3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mapForm";
            this.Text = "mapForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private mercuryPollution.yt_Button yt_Button3;
        private mercuryPollution.yt_Button yt_Button1;
        private mercuryPollution.yt_Button yt_Button2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private mercuryPollution.yt_Button yt_Button4;
        public mercuryPollution.Components.RoundingButtonsComponent roundingButtonsComponent;
        private Tulpep.NotificationWindow.PopupNotifier popup;
        private mercuryPollution.yt_Button yt_Button5;
        private mercuryPollution.yt_Button yt_Button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}