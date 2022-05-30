using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt_DesignUI
{
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }
        class TransparentPanel : Panel
        {         
            public TransparentPanel()
            {
                SetStyle(ControlStyles.Opaque, true);
            }
        
            protected override CreateParams CreateParams
            {
                get
                {
                    const int WS_EX_TRANSPARENT = 0x00000020;
                    CreateParams createParams = base.CreateParams;
                    createParams.ExStyle |= WS_EX_TRANSPARENT;
                    return createParams;
                }
            }
       
            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Gray)),
                 0, 0, Width, Height);
            }
            protected override void OnMove(EventArgs e)
            {
                if (Parent != null)
                    Parent.Invalidate(Bounds, true);
            }
        }
    }
}
