using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IMovement;
using UMovement;
using AMovement;
using OMovement;

namespace MovementForm
{
    public partial class MainMovementForm : Form
    {
        public List<InterfaceMovement> MovementList = new List<InterfaceMovement>(); 

        public MainMovementForm()
        {
            InitializeComponent();
        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            MovementEnterForm addForm = new MovementEnterForm();
            addForm.Owner = this;
            addForm.ShowDialog();
        }

        private void MainMovementForm_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

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
