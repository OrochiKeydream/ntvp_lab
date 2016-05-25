using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IMovement;
using UMovement;
using AMovement;
using OMovement;

namespace MovementForm
{
    /// <summary>
    /// Класс, отображающий форму для отображения, добавления и удаления
    /// записей о расчете движения.
    /// </summary>
    public partial class MainMovementForm : Form
    {
        public List<InterfaceMovement> MovementList = new List<InterfaceMovement>(); 

        public MainMovementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, обрабатывающий события нажатия на кнопку "Добавить
        /// запись".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddObject_Click(object sender, EventArgs e)
        {
            MovementEnterForm addForm = new MovementEnterForm();
            addForm.Owner = this;
            addForm.ShowDialog();
        }

        /// <summary>
        /// Метод, обрабатывающий событие, возникающее при фокусе формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMovementForm_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        /// <summary>
        /// Метод, обновляющий данные в форме.
        /// </summary>
        private void UpdateDataGridView()
        {
            movementDataGrid.Rows.Clear();
            for (int i = 0; i < MovementList.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(movementDataGrid);
                if (MovementList[i] is UniformMovement)
                {
                    row.Cells[0].Value = "Равномерное";
                }
                if (MovementList[i] is AccelerationMovement)
                {
                    row.Cells[0].Value = "Равноускоренное";
                }
                if (MovementList[i] is OscillatingMovement)
                {
                    row.Cells[0].Value = "Колебательное";
                }
                row.Cells[1].Value = Math.Round(MovementList[i].Calculation(), 2);
                movementDataGrid.Rows.Add(row);
            }
        }

        /// <summary>
        /// Метод, обрабатывающий событие нажатия кнопки "Удалить запись".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveObject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in movementDataGrid.SelectedRows)
            {
                MovementList.RemoveAt(row.Index);
            }
            UpdateDataGridView();
        }
    }
}
