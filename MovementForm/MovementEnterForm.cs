using System;
using System.Windows.Forms;
using AMovement;
using UMovement;
using OMovement;

namespace MovementForm
{
    public partial class MovementEnterForm : Form
    {
        public MovementEnterForm()
        {
            InitializeComponent();
        }

        private void UniformMovementRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Видимость текстовых полей.
            //
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;

            // Очистка текстовых полей.
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Отображение текста.
            //
            label2.Text = "Введите скорость (в км/ч)";
            label3.Visible = false;
            label4.Visible = false;
        }

        private void AccelerationMovementRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Видимость текстовых полей.
            //
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;

            // Очистка текстовых полей.
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Отображение текста.
            //
            label2.Text = "Введите ускорение (м/с^2)";
            label3.Visible = false;
            label4.Visible = false;
        }

        private void OscillatingMovementRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Видимость текстовых полей.
            //
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;

            // Очистка текстовых полей.
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Отображение текста.
            //
            label2.Text = "Введите амплитуду";
            label3.Text = "Введите частоту";
            label4.Text = "Введите фазу";
            label3.Visible = true;
            label4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Если выбрано равномерное движение.
            //
            if (UniformMovementRadio.Checked)
            {
                // Обработка ошибок.
                //
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Один или оба поля пусты.", "Ошибка");
                }
                else if (Convert.ToDouble(textBox2.Text) <= 0)
                {
                    MessageBox.Show("Скорость не может иметь отрицательное" +
                                    " значение или равняться 0.", "Ошибка");
                }
                else if (Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Время не может иметь отрицательное" +
                                    " значение или равняться 0.", "Ошибка");
                }
                // Реализация расчета.
                //
                else
                {
                    MainMovementForm main = this.Owner as MainMovementForm;
                    UniformMovement obj =
                        new UniformMovement(Convert.ToDouble(textBox2.Text),
                        Convert.ToInt32(textBox1.Text));
                    main.MovementList.Add(obj);
                    Close();
                }

            }
            // Если выбрано равноускоренное движение.
            //
            else if (AccelerationMovementRadio.Checked)
            {
                // Обработка ошибок.
                //
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Один или оба поля пусты.",
                        "Ошибка");
                }
                else if (Convert.ToDouble(textBox2.Text) <= 0)
                {
                    MessageBox.Show("Ускорение не может иметь" +
                                    " отрицательное значение или" +
                                    " равняться нулю.", "Ошибка");
                }
                else if (Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Время не может иметь" +
                                    " отрицательное значение" +
                                    " или равняться 0.", "Ошибка");
                }
                // Реализация расчета.
                //
                else
                {
                    MainMovementForm main = this.Owner as MainMovementForm;
                    AccelerationMovement obj = new AccelerationMovement(
                        Convert.ToDouble(textBox2.Text),
                        Convert.ToInt32(textBox1.Text));
                    main.MovementList.Add(obj);
                    Close();
                }
            }
            // Если выбрано колебательное движение.
            //
            else if (OscillatingMovementRadio.Checked)
            {
                // Обработка ошибок.
                if ((textBox1.Text == "") || (textBox2.Text == "")
                    || (textBox3.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Все поля обязательны для заполнения.",
                        "Ошибка");
                }
                else if (Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Время не может иметь отрицательное" +
                                    " значение или равняться 0.", "Ошибка");
                }
                // Реализация расчета.
                //
                else
                {
                    MainMovementForm main = this.Owner as MainMovementForm;
                    OscillatingMovement obj = new OscillatingMovement(
                        Convert.ToDouble(textBox2.Text),
                        Convert.ToDouble(textBox3.Text),
                        Convert.ToDouble(textBox4.Text),
                        Convert.ToInt32(textBox1.Text));
                    main.MovementList.Add(obj);
                    Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
