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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OscillatingMovementRadio);
            this.groupBox1.Controls.Add(this.AccelerationMovementRadio);
            this.groupBox1.Controls.Add(this.UniformMovementRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид расчета";
            // 
            // OscillatingMovementRadio
            // 
            this.OscillatingMovementRadio.AutoSize = true;
            this.OscillatingMovementRadio.Location = new System.Drawing.Point(6, 66);
            this.OscillatingMovementRadio.Name = "OscillatingMovementRadio";
            this.OscillatingMovementRadio.Size = new System.Drawing.Size(156, 17);
            this.OscillatingMovementRadio.TabIndex = 2;
            this.OscillatingMovementRadio.TabStop = true;
            this.OscillatingMovementRadio.Text = "Колебательное движение";
            this.OscillatingMovementRadio.UseVisualStyleBackColor = true;
            this.OscillatingMovementRadio.CheckedChanged += new System.EventHandler(this.OscillatingMovementRadio_CheckedChanged);
            // 
            // AccelerationMovementRadio
            // 
            this.AccelerationMovementRadio.AutoSize = true;
            this.AccelerationMovementRadio.Location = new System.Drawing.Point(6, 43);
            this.AccelerationMovementRadio.Name = "AccelerationMovementRadio";
            this.AccelerationMovementRadio.Size = new System.Drawing.Size(168, 17);
            this.AccelerationMovementRadio.TabIndex = 1;
            this.AccelerationMovementRadio.TabStop = true;
            this.AccelerationMovementRadio.Text = "Равноускоренное движение";
            this.AccelerationMovementRadio.UseVisualStyleBackColor = true;
            this.AccelerationMovementRadio.CheckedChanged += new System.EventHandler(this.AccelerationMovementRadio_CheckedChanged);
            // 
            // UniformMovementRadio
            // 
            this.UniformMovementRadio.AutoSize = true;
            this.UniformMovementRadio.Location = new System.Drawing.Point(6, 19);
            this.UniformMovementRadio.Name = "UniformMovementRadio";
            this.UniformMovementRadio.Size = new System.Drawing.Size(147, 17);
            this.UniformMovementRadio.TabIndex = 0;
            this.UniformMovementRadio.TabStop = true;
            this.UniformMovementRadio.Text = "Равномерное движение";
            this.UniformMovementRadio.UseVisualStyleBackColor = true;
            this.UniformMovementRadio.CheckedChanged += new System.EventHandler(this.UniformMovementRadio_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(167, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите время (в сек)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите скорость (в км/ч)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите частоту";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите фазу";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Рассчитать";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MovementEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 254);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MovementEnterForm";
            this.Text = "MovementEnterForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}