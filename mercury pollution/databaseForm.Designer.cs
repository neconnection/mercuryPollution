namespace yt_DesignUI
{
    partial class databaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(databaseForm));
            this.databasemercuryDataSet = new yt_DesignUI.databasemercuryDataSet();
            this.coordinateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coordinateTableAdapter = new yt_DesignUI.databasemercuryDataSetTableAdapters.coordinateTableAdapter();
            this.tableAdapterManager = new yt_DesignUI.databasemercuryDataSetTableAdapters.TableAdapterManager();
            this.pollutionvaluesTableAdapter = new yt_DesignUI.databasemercuryDataSetTableAdapters.pollutionvaluesTableAdapter();
            this.coordinateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.coordinateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coordinateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollutionvaluesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pollutionvaluesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.databasemercuryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateBindingNavigator)).BeginInit();
            this.coordinateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollutionvaluesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollutionvaluesDataGridView)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // databasemercuryDataSet
            // 
            this.databasemercuryDataSet.DataSetName = "databasemercuryDataSet";
            this.databasemercuryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coordinateBindingSource
            // 
            this.coordinateBindingSource.DataMember = "coordinate";
            this.coordinateBindingSource.DataSource = this.databasemercuryDataSet;
            // 
            // coordinateTableAdapter
            // 
            this.coordinateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coordinateTableAdapter = this.coordinateTableAdapter;
            this.tableAdapterManager.pollutionvaluesTableAdapter = this.pollutionvaluesTableAdapter;
            this.tableAdapterManager.UpdateOrder = yt_DesignUI.databasemercuryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pollutionvaluesTableAdapter
            // 
            this.pollutionvaluesTableAdapter.ClearBeforeFill = true;
            // 
            // coordinateBindingNavigator
            // 
            this.coordinateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coordinateBindingNavigator.BindingSource = this.coordinateBindingSource;
            this.coordinateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coordinateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coordinateBindingNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.coordinateBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coordinateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.coordinateBindingNavigatorSaveItem});
            this.coordinateBindingNavigator.Location = new System.Drawing.Point(835, 0);
            this.coordinateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coordinateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coordinateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coordinateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coordinateBindingNavigator.Name = "coordinateBindingNavigator";
            this.coordinateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coordinateBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.coordinateBindingNavigator.Size = new System.Drawing.Size(56, 491);
            this.coordinateBindingNavigator.TabIndex = 0;
            this.coordinateBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(53, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(53, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(53, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(53, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(53, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(53, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(53, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(53, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(53, 6);
            // 
            // coordinateBindingNavigatorSaveItem
            // 
            this.coordinateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coordinateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coordinateBindingNavigatorSaveItem.Image")));
            this.coordinateBindingNavigatorSaveItem.Name = "coordinateBindingNavigatorSaveItem";
            this.coordinateBindingNavigatorSaveItem.Size = new System.Drawing.Size(53, 24);
            this.coordinateBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.coordinateBindingNavigatorSaveItem.Click += new System.EventHandler(this.coordinateBindingNavigatorSaveItem_Click);
            // 
            // coordinateDataGridView
            // 
            this.coordinateDataGridView.AutoGenerateColumns = false;
            this.coordinateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coordinateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.coordinateDataGridView.DataSource = this.coordinateBindingSource;
            this.coordinateDataGridView.Location = new System.Drawing.Point(0, 3);
            this.coordinateDataGridView.Name = "coordinateDataGridView";
            this.coordinateDataGridView.RowHeadersWidth = 51;
            this.coordinateDataGridView.RowTemplate.Height = 24;
            this.coordinateDataGridView.Size = new System.Drawing.Size(751, 220);
            this.coordinateDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn1.HeaderText = "number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "coordinatelat";
            this.dataGridViewTextBoxColumn2.HeaderText = "coordinatelat";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "coordinatelong";
            this.dataGridViewTextBoxColumn3.HeaderText = "coordinatelong";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "noteaddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "noteaddress";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // pollutionvaluesBindingSource
            // 
            this.pollutionvaluesBindingSource.DataMember = "pollutionvalues";
            this.pollutionvaluesBindingSource.DataSource = this.databasemercuryDataSet;
            // 
            // pollutionvaluesDataGridView
            // 
            this.pollutionvaluesDataGridView.AutoGenerateColumns = false;
            this.pollutionvaluesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pollutionvaluesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pollutionvaluesDataGridView.DataSource = this.pollutionvaluesBindingSource;
            this.pollutionvaluesDataGridView.Location = new System.Drawing.Point(0, 232);
            this.pollutionvaluesDataGridView.Name = "pollutionvaluesDataGridView";
            this.pollutionvaluesDataGridView.RowHeadersWidth = 51;
            this.pollutionvaluesDataGridView.RowTemplate.Height = 24;
            this.pollutionvaluesDataGridView.Size = new System.Drawing.Size(420, 220);
            this.pollutionvaluesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numberpollution";
            this.dataGridViewTextBoxColumn5.HeaderText = "numberpollution";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pollutionval";
            this.dataGridViewTextBoxColumn6.HeaderText = "pollutionval";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.ContentPanel.Visible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(588, 246);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // databaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(891, 491);
            this.Controls.Add(this.coordinateBindingNavigator);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.pollutionvaluesDataGridView);
            this.Controls.Add(this.coordinateDataGridView);
            this.Name = "databaseForm";
            this.Text = "databaseForm";
            this.Load += new System.EventHandler(this.databaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasemercuryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateBindingNavigator)).EndInit();
            this.coordinateBindingNavigator.ResumeLayout(false);
            this.coordinateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollutionvaluesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollutionvaluesDataGridView)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private databasemercuryDataSet databasemercuryDataSet;
        private System.Windows.Forms.BindingSource coordinateBindingSource;
        private databasemercuryDataSetTableAdapters.coordinateTableAdapter coordinateTableAdapter;
        private databasemercuryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coordinateBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton coordinateBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView coordinateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private databasemercuryDataSetTableAdapters.pollutionvaluesTableAdapter pollutionvaluesTableAdapter;
        private System.Windows.Forms.BindingSource pollutionvaluesBindingSource;
        private System.Windows.Forms.DataGridView pollutionvaluesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}