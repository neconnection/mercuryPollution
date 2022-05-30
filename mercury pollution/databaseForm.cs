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
    public partial class databaseForm : Form
    {
        public databaseForm()
        {
            InitializeComponent();
        }

        private void coordinateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coordinateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasemercuryDataSet);

        }

        private void databaseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasemercuryDataSet.pollutionvalues". При необходимости она может быть перемещена или удалена.
            this.pollutionvaluesTableAdapter.Fill(this.databasemercuryDataSet.pollutionvalues);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasemercuryDataSet.coordinate". При необходимости она может быть перемещена или удалена.
            this.coordinateTableAdapter.Fill(this.databasemercuryDataSet.coordinate);

        }
    }
}
