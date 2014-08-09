namespace Samuelito
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label regionDescriptionLabel;
            System.Windows.Forms.Label regionIDLabel;
            this.regionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.regionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.regionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionIDTextBox = new System.Windows.Forms.TextBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regionDescriptionLabel = new System.Windows.Forms.Label();
            regionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingNavigator)).BeginInit();
            this.regionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // regionBindingNavigator
            // 
            this.regionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.regionBindingNavigator.BindingSource = this.regionBindingSource;
            this.regionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.regionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.regionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.regionBindingNavigatorSaveItem});
            this.regionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.regionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.regionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.regionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.regionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.regionBindingNavigator.Name = "regionBindingNavigator";
            this.regionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.regionBindingNavigator.Size = new System.Drawing.Size(427, 25);
            this.regionBindingNavigator.TabIndex = 0;
            this.regionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // regionBindingNavigatorSaveItem
            // 
            this.regionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.regionBindingNavigatorSaveItem.Enabled = false;
            this.regionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("regionBindingNavigatorSaveItem.Image")));
            this.regionBindingNavigatorSaveItem.Name = "regionBindingNavigatorSaveItem";
            this.regionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.regionBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // regionDescriptionLabel
            // 
            regionDescriptionLabel.AutoSize = true;
            regionDescriptionLabel.Location = new System.Drawing.Point(93, 36);
            regionDescriptionLabel.Name = "regionDescriptionLabel";
            regionDescriptionLabel.Size = new System.Drawing.Size(100, 13);
            regionDescriptionLabel.TabIndex = 1;
            regionDescriptionLabel.Text = "Region Description:";
            // 
            // regionDescriptionTextBox
            // 
            this.regionDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionBindingSource, "RegionDescription", true));
            this.regionDescriptionTextBox.Location = new System.Drawing.Point(199, 33);
            this.regionDescriptionTextBox.Name = "regionDescriptionTextBox";
            this.regionDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.regionDescriptionTextBox.TabIndex = 2;
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.Location = new System.Drawing.Point(93, 62);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(58, 13);
            regionIDLabel.TabIndex = 3;
            regionIDLabel.Text = "Region ID:";
            // 
            // regionIDTextBox
            // 
            this.regionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regionBindingSource, "RegionID", true));
            this.regionIDTextBox.Location = new System.Drawing.Point(199, 59);
            this.regionIDTextBox.Name = "regionIDTextBox";
            this.regionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.regionIDTextBox.TabIndex = 4;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataSource = typeof(Samuelito.Region);
            // 
            // regionDataGridView
            // 
            this.regionDataGridView.AutoGenerateColumns = false;
            this.regionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.regionDataGridView.DataSource = this.regionBindingSource;
            this.regionDataGridView.Location = new System.Drawing.Point(35, 119);
            this.regionDataGridView.Name = "regionDataGridView";
            this.regionDataGridView.Size = new System.Drawing.Size(344, 220);
            this.regionDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RegionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegionDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegionDescription";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Territories";
            this.dataGridViewTextBoxColumn3.HeaderText = "Territories";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 359);
            this.Controls.Add(this.regionDataGridView);
            this.Controls.Add(regionDescriptionLabel);
            this.Controls.Add(this.regionDescriptionTextBox);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(this.regionIDTextBox);
            this.Controls.Add(this.regionBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingNavigator)).EndInit();
            this.regionBindingNavigator.ResumeLayout(false);
            this.regionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource regionBindingSource;
        private System.Windows.Forms.BindingNavigator regionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton regionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox regionDescriptionTextBox;
        private System.Windows.Forms.TextBox regionIDTextBox;
        private System.Windows.Forms.DataGridView regionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}