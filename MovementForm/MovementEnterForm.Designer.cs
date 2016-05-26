namespace MovementForm
{
    partial class MovementEnterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OscillatingMovementRadio = new System.Windows.Forms.RadioButton();
            this.AccelerationMovementRadio = new System.Windows.Forms.RadioButton();
            this.UniformMovementRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OscillatingMovementRadio);
            this.groupBox1.Controls.Add(this.AccelerationMovementRadio);
            this.groupBox1.Controls.Add(this.UniformMovementRadio);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид расчета";
            // 
            // OscillatingMovementRadio
            // 
            this.OscillatingMovementRadio.AutoSize = true;
            this.OscillatingMovementRadio.Location = new System.Drawing.Point(8, 81);
            this.OscillatingMovementRadio.Margin = new System.Windows.Forms.Padding(4);
            this.OscillatingMovementRadio.Name = "OscillatingMovementRadio";
            this.OscillatingMovementRadio.Size = new System.Drawing.Size(196, 20);
            this.OscillatingMovementRadio.TabIndex = 2;
            this.OscillatingMovementRadio.TabStop = true;
            this.OscillatingMovementRadio.Text = "Колебательное движение";
            this.OscillatingMovementRadio.UseVisualStyleBackColor = true;
            this.OscillatingMovementRadio.CheckedChanged += new System.EventHandler(this.OscillatingMovementRadio_CheckedChanged);
            // 
            // AccelerationMovementRadio
            // 
            this.AccelerationMovementRadio.AutoSize = true;
            this.AccelerationMovementRadio.Location = new System.Drawing.Point(8, 53);
            this.AccelerationMovementRadio.Margin = new System.Windows.Forms.Padding(4);
            this.AccelerationMovementRadio.Name = "AccelerationMovementRadio";
            this.AccelerationMovementRadio.Size = new System.Drawing.Size(213, 20);
            this.AccelerationMovementRadio.TabIndex = 1;
            this.AccelerationMovementRadio.TabStop = true;
            this.AccelerationMovementRadio.Text = "Равноускоренное движение";
            this.AccelerationMovementRadio.UseVisualStyleBackColor = true;
            this.AccelerationMovementRadio.CheckedChanged += new System.EventHandler(this.AccelerationMovementRadio_CheckedChanged);
            // 
            // UniformMovementRadio
            // 
            this.UniformMovementRadio.AutoSize = true;
            this.UniformMovementRadio.Location = new System.Drawing.Point(8, 23);
            this.UniformMovementRadio.Margin = new System.Windows.Forms.Padding(4);
            this.UniformMovementRadio.Name = "UniformMovementRadio";
            this.UniformMovementRadio.Size = new System.Drawing.Size(184, 20);
            this.UniformMovementRadio.TabIndex = 0;
            this.UniformMovementRadio.TabStop = true;
            this.UniformMovementRadio.Text = "Равномерное движение";
            this.UniformMovementRadio.UseVisualStyleBackColor = true;
            this.UniformMovementRadio.CheckedChanged += new System.EventHandler(this.UniformMovementRadio_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 167);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 231);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите время (в сек)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите скорость (в км/ч)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите частоту";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите фазу";
            this.label4.Visible = false;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(256, 274);
            this.CalcButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(100, 28);
            this.CalcButton.TabIndex = 10;
            this.CalcButton.Text = "Рассчитать";
            this.CalcButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(16, 274);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(CancelButton_Click);
            // 
            // MovementEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 313);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovementEnterForm";
            this.Text = "Ввод данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OscillatingMovementRadio;
        private System.Windows.Forms.RadioButton AccelerationMovementRadio;
        private System.Windows.Forms.RadioButton UniformMovementRadio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button CancelButton;
    }
}