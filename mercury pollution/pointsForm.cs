using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mercuryPollution.Controls;

namespace yt_DesignUI
{
    public partial class pointsForm : ShadowedForm
    {
        public pointsForm()
        {
            InitializeComponent();
        }

        //private void CreatePointElement(string number)
        //{
        //    switch (numberPointsAndAquatories[number])
        //    {
        //        case 1:
        //            nouthCheckedList.Items.Add(number);
        //            break;
        //        case 2:
        //            centerCheckedList.Items.Add(number);
        //            break;
        //        case 3:
        //            southCheckedList.Items.Add(number);
        //            break;
        //    }
        //}

        //private void GetCheckedData(MaterialCheckedListBox listBox)
        //{
        //    foreach (var item in listBox.Items)
        //    {
        //        if (item.Checked == true)
        //        {
        //            selectedPoints.Add(item.Text);
        //        }
        //    }
        //}

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            //GetCheckedData(southCheckedList);

            //if (selectedPoints.Count > 1)
            //{
            //    currentMathematicModelWindow.DrawPolygon(selectedPoints);
            //    Close();
            //}
            //else
            //{
            //    string errorText = "Вы выбрали менее двух точек пробоотбора!";
            //    ErrorWindow.errorText = errorText;
            //    ErrorWindow errorWindow = new ErrorWindow();
            //    errorWindow.Show();
            //    selectedPoints.Clear();
            //}
        }
    }
}
