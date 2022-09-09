using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoWinApp
{
    /// <summary>
    /// View of the application
    /// </summary>
    public partial class ToDoView : Form, ITodoView
    {
        public ToDoView()
        {
            InitializeComponent();
        }

        public ToDoController _controller;

        // Task Name
        public string ToDoItemName
        {
            get { return txtTaskName.Text; }
            set { txtTaskName.Text = value; }
        }
        // Unique ID for Task
        public int ToDoUID
        {
            get { return (int)numTaskID.Value; }
            set { numTaskID.Value = value; }
        }
        // Category of the task
        public string Category
        {
            get { return cbCategory.Text; }
            set { cbCategory.Text = value; }
        }
        // Task's Current Status
        public int ToDoStatus
        {
            get 
            {
                if (rdbtnNew.Checked)
                    return 0;
                else if (rdBtnPending.Checked)
                    return 1;
                else if (rdBtnCompleted.Checked)
                    return 2;
                else
                    return 3;
            }
            set
            {
                if (value == 0)
                    rdbtnNew.Checked = true;
                else if (value == 1)
                    rdBtnPending.Checked = true;
                else if (value == 2)
                    rdBtnCompleted.Checked = true;
                else
                {
                    rdbtnNew.Checked = false;
                    rdBtnPending.Checked = false;
                    rdBtnCompleted.Checked = false;
                }
            }
        }
        // What estimated date to do task would complete?
        public DateTime EstimateCompletionDate
        {
            get { return dtpEstimatedDate.Value; }
            set { dtpEstimatedDate.Value = value; }
        }
        // Actual date when to do task completed.
        public DateTime ActualCompletionDate
        {
            get { return dtpActualDate.Value; }
            set { dtpActualDate.Value = value; }
        }

        /// <summary>
        /// Removing all data from Grid
        /// </summary>
        public void ClearGrid()
        {
            dgvTask.DataSource = null;
        }

        /// <summary>
        /// Selecting Unique ID from todo list
        /// </summary>
        /// <returns></returns>
        public int GetIdOfSelectedToDoInGrid()
        {
            if (this.dgvTask.SelectedRows.Count > 0)
                return Convert.ToInt32(this.dgvTask.SelectedRows[0].Cells[1].Value);
            else
                return 0;
        }

        /// <summary>
        /// Adding Item in to do list
        /// </summary>
        /// <param name="item"></param>
        void ITodoView.AddToDoItemToGrid(ToDoItem item)
        {
            string strStatus = string.Empty;
            if (item.ToDoStatus == 0)
                strStatus = "New";
            else if (item.ToDoStatus == 1)
                strStatus = "Pending";
            else if (item.ToDoStatus == 2)
                strStatus = "Completed";
            else
                strStatus = "";

            dgvTask.Rows.Add(item.ToDoItemName, item.ToDoUID, item.Category, strStatus, item.EstimateCompletionDate, item.ActualCompletionDate);
        }

        /// <summary>
        /// Removing Item from the todo list
        /// </summary>
        /// <param name="item"></param>
        void ITodoView.RemoveToDoItemFromGrid(ToDoItem item)
        {
            foreach(DataGridViewRow row in this.dgvTask.SelectedRows)
            {
                dgvTask.Rows.RemoveAt(row.Index);
            }
        }

        /// <summary>
        /// Attaching controller in view
        /// </summary>
        /// <param name="controller"></param>
        void ITodoView.SetController(ToDoController controller)
        {
            _controller = controller;
        }

        /// <summary>
        /// Select item in the to do list
        /// </summary>
        /// <param name="item"></param>
        void ITodoView.SetSelectedToDoItemInGrid(ToDoItem item)
        {
          foreach(DataGridViewRow row in this.dgvTask.SelectedRows)
            {
                if (Convert.ToInt32(this.dgvTask.SelectedRows[0].Cells[1].Value) == item.ToDoUID)
                    row.Selected = true;
            }
        }

        /// <summary>
        /// Update item in todo list after selecting row
        /// </summary>
        /// <param name="item"></param>
        void ITodoView.UpdateGridWithChangedToDoItem(ToDoItem item)
        {
            foreach (DataGridViewRow rowToUpdate in this.dgvTask.SelectedRows)
            {
                if (Convert.ToInt32(rowToUpdate.Cells[1].Value) == item.ToDoUID)
                {
                    rowToUpdate.Cells[0].Value = item.ToDoItemName;
                    rowToUpdate.Cells[1].Value = item.ToDoUID;
                    rowToUpdate.Cells[2].Value = item.Category;
                    if (item.ToDoStatus == 0)
                        rowToUpdate.Cells[3].Value = "New";
                    else if (item.ToDoStatus == 1)
                        rowToUpdate.Cells[3].Value = "Pending";
                    else if (item.ToDoStatus == 2)
                        rowToUpdate.Cells[3].Value = "Completed";
                    else
                        rowToUpdate.Cells[3].Value = string.Empty;

                    rowToUpdate.Cells[4].Value = item.EstimateCompletionDate;
                    rowToUpdate.Cells[5].Value = item.ActualCompletionDate;
                }
            }
        }

        /// <summary>
        /// Reset button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            _controller.AddNewToDoItem();
        }

        /// <summary>
        /// Remove button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            _controller.RemoveToDoItem();
        }

        /// <summary>
        /// Update buttong click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
 
            _controller.Save();
        }

        /// <summary>
        /// Selection Changed event for datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTask_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows == null || dgvTask.SelectedRows.Count <=0)
                return;
            
            int taskID = 0;
            if (dgvTask.SelectedRows[0].Cells[1].Value != null)
                taskID = Convert.ToInt32(dgvTask.SelectedRows[0].Cells[1].Value);
            _controller.SelectedToDoItemChanged(taskID);
        }
    }
}
