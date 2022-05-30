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
using yt_DesignUI;

namespace mercuryPollution
{
    public partial class mainForm : ShadowedForm
    {
        private Form active;

        public mainForm()
        {
            InitializeComponent();
            PanelForm(new greetingForm());
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
        private void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }

        private void egoldsCard1_Click(object sender, EventArgs e)
        {
            PanelForm(new mapForm());
        }

        private void egoldsCard3_Click(object sender, EventArgs e)
        {
            PanelForm(new databaseForm());
        }

        private void egoldsCard2_Click(object sender, EventArgs e)
        {
            PanelForm(new infoForm());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelForm(new mapForm());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PanelForm(new databaseForm());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PanelForm(new infoForm());
        }
    }
}
