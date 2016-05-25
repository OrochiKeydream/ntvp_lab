using System;
using System.Windows.Forms;
using UMovement;
using AMovement;
using OMovement;

namespace View
{
    /// <summary>
    /// Класс, содержащий форму пользовательского интерфейса.
    /// </summary>
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, обрабатывающий выбор равномерного движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Видимость текстовых полей.
            //
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = true;

            // Очистка текстовых полей.
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Отображение текста.
            //
            label1.Text = "Введите скорость (в км/ч)";
            label5.Text = "Расстояние";
            label1.Enabled = true;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Видимость текстовых полей.
            //
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = true;

            // Очистка текстовых полей.
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Отображение текста.
            //
            label1.Text = "Введите ускорение (м/с^2)";
            label5.Text = "Расстояние";
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Видимость текстовых полей.
            //
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            // Очистка текстовых полей.
            //
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Отображение текста.
            //
            label1.Text = "Введите амплитуду";
            label2.Text = "Введите частоту";
            label3.Text = "Введите фазу";
            label5.Text = "Координата Y";
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
        }

        /// <summary>
        /// Метод обработки нажатия кнопки "Рассчитать".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Если выбрано равномерное движение.
            //
            if (radioButton1.Checked)
            {
                // Обработка ошибок.
                //
                if ((textBox1.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Один или оба поля пусты.", "Ошибка");
                }
                else if (Convert.ToDouble(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Скорость не может иметь отрицательное" +
                                    " значение или равняться 0.", "Ошибка");
                }
                else if (Convert.ToInt32(textBox4.Text) <= 0)
                {
                    MessageBox.Show("Время не может иметь отрицательное" +
                                    " значение или равняться 0.", "Ошибка");
                }
                // Реализация расчета.
                //
                else
                {
                    UniformMovement obj =
                        new UniformMovement(Convert.ToDouble(textBox1.Text),
                        Convert.ToInt32(textBox4.Text));
                    textBox5.Text = Convert.ToString(obj.Calculation());
                }
            }
            // Если выбрано равноускоренное движение.
            //
            else if (radioButton2.Checked)
            {
                // Обработка ошибок.
                //
                if ((textBox1.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Один, два или все три поля пусты.",
                        "Ошибка");
                }
                else if (Convert.ToDouble(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Ускорение не может иметь" +
                                    " отрицательное значение или" +
                                    " равняться нулю.", "Ошибка");
                }
                else if (Convert.ToInt32(textBox4.Text) <= 0)
                {
                    MessageBox.Show("Время не может иметь" +
                                    " отрицательное значение" +
                                    " или равняться 0.", "Ошибка");
                }
                // Реализация расчета.
                //
                else
                {
                    AccelerationMovement obj = new AccelerationMovement(
                        Convert.ToDouble(textBox1.Text),
                        Convert.ToInt32(textBox4.Text));
                    textBox5.Text = Convert.ToString(obj.Calculation());
                }
            }
            // Если выбрано колебательное движение.
            //
            else if (radioButton3.Checked)
            {
                // Обработка ошибок.
                if ((textBox1.Text == "") || (textBox2.Text == "")
                    || (textBox3.Text == "") || (textBox4.Text == ""))
                {
                    MessageBox.Show("Все поля обязательны для заполнения.",
                        "Ошибка");
                }
                else if (Convert.ToInt32(textBox4.Text) <= 0)
                {
                    MessageBox.Show("Время не может иметь отрицательное" +
                                    " значение или равняться 0.", "Ошибка");
                }
                // Реализация расчета.
                //
                else
                {
                    OscillatingMovement obj = new OscillatingMovement(
                        Convert.ToDouble(textBox1.Text),
                        Convert.ToDouble(textBox2.Text),
                        Convert.ToDouble(textBox3.Text),
                        Convert.ToInt32(textBox4.Text));
                    textBox5.Text = Convert.ToString(obj.Calculation());
                }
            }     
        }
    }
}
