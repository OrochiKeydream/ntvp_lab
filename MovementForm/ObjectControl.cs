using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMovement;
using UMovement;
using AMovement;
using OMovement;

namespace MovementForm
{
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
        }

        public void SetValue(UniformMovement obj)
        {
            textBox1.Text = Convert.ToString(obj.Time);
            label2.Text = "Скорость (в км/ч)";
            textBox2.Text = Convert.ToString(obj.Speed);
            label3.Text = "Расстояние";
            textBox3.Text = Convert.ToString(obj.Length);

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        public void SetValue(AccelerationMovement obj)
        {
            textBox1.Text = Convert.ToString(obj.Time);
            label2.Text = "Ускорение (в м/с^2)";
            textBox2.Text = Convert.ToString(obj.Acceleration);
            label3.Text = "Расстояние";
            textBox3.Text = Convert.ToString(obj.Length);

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        public void SetValue(OscillatingMovement obj)
        {
            textBox1.Text = Convert.ToString(obj.Time);
            label2.Text = "Амплитуда";
            textBox2.Text = Convert.ToString(obj.Amplitude);
            label3.Text = "Частота";
            textBox3.Text = Convert.ToString(obj.Frequency);
            label4.Text = "Фаза";
            textBox4.Text = Convert.ToString(obj.Phase);
            label5.Text = "Значение функции";
            textBox5.Text = Convert.ToString(obj.FuncValue);

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
