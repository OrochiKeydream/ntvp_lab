namespace MovementForm
{
    partial class MainMovementForm
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
            this.MovementDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddObject = new System.Windows.Forms.Button();
            this.RemoveObject = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.objectControl = new MovementForm.ObjectControl();
            ((System.ComponentModel.ISupportInitialize)(this.MovementDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementDataGrid
            // 
            this.MovementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovementDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.MovementDataGrid.Location = new System.Drawing.Point(16, 15);
            this.MovementDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MovementDataGrid.Name = "MovementDataGrid";
            this.MovementDataGrid.ReadOnly = true;
            this.MovementDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MovementDataGrid.Size = new System.Drawing.Size(324, 236);
            this.MovementDataGrid.TabIndex = 0;
            this.MovementDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(MovementDataGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Движение";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Результат";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(348, 15);
            this.AddObject.Margin = new System.Windows.Forms.Padding(4);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(171, 28);
            this.AddObject.TabIndex = 1;
            this.AddObject.Text = "Добавить запись";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // RemoveObject
            // 
            this.RemoveObject.Location = new System.Drawing.Point(348, 50);
            this.RemoveObject.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveObject.Name = "RemoveObject";
            this.RemoveObject.Size = new System.Drawing.Size(171, 28);
            this.RemoveObject.TabIndex = 2;
            this.RemoveObject.Text = "Удалить запись";
            this.RemoveObject.UseVisualStyleBackColor = true;
            this.RemoveObject.Click += new System.EventHandler(this.RemoveObject_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(348, 223);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(163, 28);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Дополнительно";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // objectControl
            // 
            this.objectControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectControl.Location = new System.Drawing.Point(103, 10);
            this.objectControl.Margin = new System.Windows.Forms.Padding(5);
            this.objectControl.Name = "objectControl";
            this.objectControl.Size = new System.Drawing.Size(321, 235);
            this.objectControl.TabIndex = 4;
            this.objectControl.Visible = false;
            // 
            // MainMovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 260);
            this.Controls.Add(this.objectControl);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.RemoveObject);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.MovementDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMovementForm";
            this.Text = "Расчет движения";
            this.Activated += new System.EventHandler(this.MainMovementForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.MovementDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MovementDataGrid;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Button RemoveObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ShowButton;
        private ObjectControl objectControl;
    }
}