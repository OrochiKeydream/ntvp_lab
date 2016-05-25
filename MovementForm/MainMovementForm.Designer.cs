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
            this.movementDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddObject = new System.Windows.Forms.Button();
            this.RemoveObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movementDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // movementDataGrid
            // 
            this.movementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movementDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.movementDataGrid.Location = new System.Drawing.Point(12, 12);
            this.movementDataGrid.Name = "movementDataGrid";
            this.movementDataGrid.ReadOnly = true;
            this.movementDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movementDataGrid.Size = new System.Drawing.Size(243, 244);
            this.movementDataGrid.TabIndex = 0;
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
            this.AddObject.Location = new System.Drawing.Point(261, 12);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(128, 23);
            this.AddObject.TabIndex = 1;
            this.AddObject.Text = "Добавить запись";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // RemoveObject
            // 
            this.RemoveObject.Location = new System.Drawing.Point(261, 41);
            this.RemoveObject.Name = "RemoveObject";
            this.RemoveObject.Size = new System.Drawing.Size(128, 23);
            this.RemoveObject.TabIndex = 2;
            this.RemoveObject.Text = "Удалить запись";
            this.RemoveObject.UseVisualStyleBackColor = true;
            this.RemoveObject.Click += new System.EventHandler(this.RemoveObject_Click);
            // 
            // MainMovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 268);
            this.Controls.Add(this.RemoveObject);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.movementDataGrid);
            this.Name = "MainMovementForm";
            this.Text = "Расчет движения";
            this.Activated += new System.EventHandler(this.MainMovementForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.movementDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView movementDataGrid;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Button RemoveObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}