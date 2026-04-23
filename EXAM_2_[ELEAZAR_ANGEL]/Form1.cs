using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskManagerApp
{
    public partial class Form1 : Form
    {
        private Queue<ProjectTask> taskQueue = new Queue<ProjectTask>();
        private int nextId = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        // ✅ GRID SETUP
        private void InitializeGrid()
        {
            gridTasks.Columns.Clear();
            gridTasks.Columns.Add("colID", "ID");
            gridTasks.Columns.Add("colTitle", "Title");
            gridTasks.Columns.Add("colPriority", "Priority");
        }

        // ✅ ADD TASK
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtPriority.Text))
                {
                    MessageBox.Show("Please enter Title and Priority.");
                    return;
                }

                ProjectTask task = new ProjectTask
                {
                    Id = nextId++,
                    Title = txtTitle.Text,
                    Priority = int.Parse(txtPriority.Text)
                };

                // Add subtasks
                foreach (var item in listSubtasks.Items)
                {
                    task.SubTasks.Add(new ProjectTask
                    {
                        Title = item.ToString(),
                        Priority = 1
                    });
                }

                taskQueue.Enqueue(task);

                RefreshGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ✅ ADD SUBTASK
        private void btnAddSubtask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubtask.Text))
            {
                listSubtasks.Items.Add(txtSubtask.Text);
                txtSubtask.Clear();
                UpdateSubtaskCount();
            }
        }

        // ✅ REMOVE TASK (FIFO)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (taskQueue.Count > 0)
            {
                taskQueue.Dequeue();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("No tasks to remove.");
            }
        }

        // ✅ SEARCH TASK (Linear Search using txtTitle as ID input)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTitle.Text, out int id))
            {
                ProjectTask found = null;

                foreach (var task in taskQueue) // Linear Search
                {
                    if (task.Id == id)
                    {
                        found = task;
                        break;
                    }
                }

                if (found != null)
                {
                    MessageBox.Show($"Found: {found.Title} (Priority {found.Priority})");
                }
                else
                {
                    MessageBox.Show("Task not found.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid ID in Title box to search.");
            }
        }

        // ✅ REFRESH GRID
        private void RefreshGrid()
        {
            gridTasks.Rows.Clear();

            foreach (var task in taskQueue)
            {
                gridTasks.Rows.Add(task.Id, task.Title, task.Priority);
            }
        }

        // ✅ CLEAR INPUTS
        private void ClearInputs()
        {
            txtTitle.Clear();
            txtPriority.Clear();
            txtSubtask.Clear();
            listSubtasks.Items.Clear();
            txtTotalSubtasks.Text = "0";
        }

        // ✅ UPDATE SUBTASK COUNT
        private void UpdateSubtaskCount()
        {
            txtTotalSubtasks.Text = listSubtasks.Items.Count.ToString();
        }
    }
}