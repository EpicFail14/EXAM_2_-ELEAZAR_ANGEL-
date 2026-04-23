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

        private void InitializeGrid()
        {
            gridTasks.Columns.Clear();
            gridTasks.Columns.Add("colID", "ID");
            gridTasks.Columns.Add("colTitle", "Title");
            gridTasks.Columns.Add("colPriority", "Priority");

            gridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTasks.MultiSelect = false;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            if (!int.TryParse(txtPriority.Text, out int priority))
            {
                MessageBox.Show("Priority must be a number (1-5).");
                return;
            }

            try
            {
                ProjectTask task = new ProjectTask
                {
                    Id = nextId++,
                    Title = txtTitle.Text.Trim(),
                    Priority = priority
                };

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

                MessageBox.Show("Task added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSubtask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubtask.Text))
            {
                listSubtasks.Items.Add(txtSubtask.Text.Trim());
                txtSubtask.Clear();
                txtTotalSubtasks.Text = listSubtasks.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Enter a subtask first.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridTasks.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(gridTasks.SelectedRows[0].Cells[0].Value);

                Queue<ProjectTask> newQueue = new Queue<ProjectTask>();

                foreach (var task in taskQueue)
                {
                    if (task.Id != selectedId)
                        newQueue.Enqueue(task);
                }

                taskQueue = newQueue;
                RefreshGrid();

                MessageBox.Show("Task removed.");
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                Text = "Search Task"
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Enter Task ID:" };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
            Button confirm = new Button() { Text = "Search", Left = 20, Width = 100, Top = 80 };

            confirm.Click += (s, ev) =>
            {
                if (!int.TryParse(inputBox.Text, out int id))
                {
                    MessageBox.Show("Invalid ID.");
                    return;
                }

                ProjectTask found = FindTaskById(id);

                if (found != null)
                    MessageBox.Show($"Found: {found.Title} (Priority {found.Priority})");
                else
                    MessageBox.Show("Task not found.");

                prompt.Close();
            };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirm);
            prompt.ShowDialog();
        }

        private ProjectTask FindTaskById(int id)
        {
            foreach (var task in taskQueue)
            {
                if (task.Id == id)
                    return task;
            }
            return null;
        }

        private void btnRemoveSubtask_Click(object sender, EventArgs e)
        {
            if (listSubtasks.SelectedItem != null)
            {
                listSubtasks.Items.Remove(listSubtasks.SelectedItem);
                txtTotalSubtasks.Text = listSubtasks.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Select a subtask to remove.");
            }
        }

        private void RefreshGrid()
        {
            gridTasks.Rows.Clear();

            foreach (var task in taskQueue)
            {
                gridTasks.Rows.Add(task.Id, task.Title, task.Priority);
            }
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtPriority.Clear();
            txtSubtask.Clear();
            listSubtasks.Items.Clear();
            txtTotalSubtasks.Text = "0";
        }
    }
}