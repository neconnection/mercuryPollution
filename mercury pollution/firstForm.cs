using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mercuryPollution.Components;
using mercuryPollution.Controls;
using System.Threading;
using System.Threading.Tasks;

namespace mercuryPollution
{
    public partial class firstForm : ShadowedForm
    {
        Thread th;
        public firstForm()
        {
            InitializeComponent();
            Animator.Start();

            if (cmbStyle.Items.Count == 0)
            {
                windowcustom.fStyle selectedStyle = windowcustom.FormStyle;
                cmbStyle.DataSource = Enum.GetValues(typeof(windowcustom.fStyle));
                cmbStyle.SelectedItem = selectedStyle;
            }
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowcustom.FormStyle = (windowcustom.fStyle)cmbStyle.SelectedItem;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (btnGradient.BackColorGradientMode)
            {
                case LinearGradientMode.ForwardDiagonal:
                    btnGradient.BackColorGradientMode = LinearGradientMode.Vertical;
                    break;

                case LinearGradientMode.Vertical:
                    btnGradient.BackColorGradientMode = LinearGradientMode.BackwardDiagonal;
                    break;

                case LinearGradientMode.BackwardDiagonal:
                    btnGradient.BackColorGradientMode = LinearGradientMode.Horizontal;
                    break;

                case LinearGradientMode.Horizontal:
                    btnGradient.BackColorGradientMode = LinearGradientMode.ForwardDiagonal;
                    break;
            }

            btnGradient.Refresh();
        }

        public void startapp(object obj)
        {
            Application.Run(new mainForm());
        }

        private void btnGradient_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(startapp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
