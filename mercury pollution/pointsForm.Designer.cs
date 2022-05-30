namespace yt_DesignUI
{
    partial class pointsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pointsForm));
            this.windowcustom = new mercuryPollution.Components.windowcustom(this.components);
            this.checkedPoint = new System.Windows.Forms.CheckedListBox();
            this.transparentPanel1 = new yt_DesignUI.TransparentPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.yt_Button2 = new mercuryPollution.yt_Button();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowcustom
            // 
            this.windowcustom.AllowUserResize = false;
            this.windowcustom.BackColor = System.Drawing.Color.DarkGray;
            this.windowcustom.ContextMenuForm = null;
            this.windowcustom.ControlBoxButtonsWidth = 36;
            this.windowcustom.EnableControlBoxIconsLight = false;
            this.windowcustom.EnableControlBoxMouseLight = false;
            this.windowcustom.Form = this;
            this.windowcustom.FormStyle = mercuryPollution.Components.windowcustom.fStyle.UserStyle;
            this.windowcustom.HeaderColor = System.Drawing.Color.RosyBrown;
            this.windowcustom.HeaderColorAdditional = System.Drawing.Color.DarkGray;
            this.windowcustom.HeaderColorGradientEnable = true;
            this.windowcustom.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.windowcustom.HeaderHeight = 28;
            this.windowcustom.HeaderImage = global::yt_DesignUI.Properties.Resources.air_pollution;
            this.windowcustom.HeaderTextColor = System.Drawing.Color.White;
            this.windowcustom.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // checkedPoint
            // 
            this.checkedPoint.BackColor = System.Drawing.Color.DimGray;
            this.checkedPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedPoint.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkedPoint.FormattingEnabled = true;
            this.checkedPoint.Location = new System.Drawing.Point(12, 48);
            this.checkedPoint.Name = "checkedPoint";
            this.checkedPoint.Size = new System.Drawing.Size(1193, 204);
            this.checkedPoint.TabIndex = 0;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.Gray;
            this.transparentPanel1.Controls.Add(this.label1);
            this.transparentPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.transparentPanel1.Location = new System.Drawing.Point(115, 12);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(989, 279);
            this.transparentPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(859, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете ниже две или более опорных точки для проведения рассчетов.";
            // 
            // yt_Button2
            // 
            this.yt_Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yt_Button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.yt_Button2.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_Button2.BackColorGradientEnabled = true;
            this.yt_Button2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button2.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorEnabled = false;
            this.yt_Button2.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorOnHoverEnabled = false;
            this.yt_Button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.yt_Button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yt_Button2.Location = new System.Drawing.Point(438, 308);
            this.yt_Button2.Margin = new System.Windows.Forms.Padding(4);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.RippleColor = System.Drawing.Color.Black;
            this.yt_Button2.Rounding = 80;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(308, 39);
            this.yt_Button2.TabIndex = 24;
            this.yt_Button2.Text = "Точки выбраны";
            this.yt_Button2.TextHover = "Точки для расчета выбраны.";
            this.yt_Button2.UseDownPressEffectOnClick = true;
            this.yt_Button2.UseRippleEffect = true;
            this.yt_Button2.UseZoomEffectOnHover = true;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
            // 
            // pointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1217, 389);
            this.Controls.Add(this.yt_Button2);
            this.Controls.Add(this.checkedPoint);
            this.Controls.Add(this.transparentPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pointsForm";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mercuryPollution";
            this.transparentPanel1.ResumeLayout(false);
            this.transparentPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mercuryPollution.Components.windowcustom windowcustom;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedPoint;
        private mercuryPollution.yt_Button yt_Button2;
    }
}