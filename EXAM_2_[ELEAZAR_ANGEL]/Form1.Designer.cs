namespace TaskManagerApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddTask = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTaskQueue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddSubtask = new System.Windows.Forms.Button();
            this.listSubtasks = new System.Windows.Forms.ListBox();
            this.txtSubtask = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSubtasks = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 79);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Tasks and Subtasks Efficiently";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Management System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddTask);
            this.panel2.Controls.Add(this.txtPriority);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.lblPriority);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblAddTask);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 165);
            this.panel2.TabIndex = 1;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTask.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTask.Location = new System.Drawing.Point(72, 127);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(118, 26);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "+ Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(29, 101);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(212, 20);
            this.txtPriority.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(29, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(17, 83);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(72, 15);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priority (1-5)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Task Title";
            // 
            // lblAddTask
            // 
            this.lblAddTask.AutoSize = true;
            this.lblAddTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.Location = new System.Drawing.Point(16, 11);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(130, 22);
            this.lblAddTask.TabIndex = 0;
            this.lblAddTask.Text = "Add New Task";
            this.lblAddTask.UseMnemonic = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.gridTasks);
            this.panel3.Controls.Add(this.lblTaskQueue);
            this.panel3.Location = new System.Drawing.Point(286, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 393);
            this.panel3.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(170, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 26);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "🗑 Remove Selected Task";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.TextChanged += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(3, 355);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "🔍 Search Task by ID";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridTasks
            // 
            this.gridTasks.BackgroundColor = System.Drawing.Color.White;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colPriority});
            this.gridTasks.Location = new System.Drawing.Point(3, 42);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.RowHeadersVisible = false;
            this.gridTasks.Size = new System.Drawing.Size(318, 307);
            this.gridTasks.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 40;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 230;
            // 
            // colPriority
            // 
            this.colPriority.HeaderText = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.Width = 45;
            // 
            // lblTaskQueue
            // 
            this.lblTaskQueue.AutoSize = true;
            this.lblTaskQueue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskQueue.Location = new System.Drawing.Point(16, 11);
            this.lblTaskQueue.Name = "lblTaskQueue";
            this.lblTaskQueue.Size = new System.Drawing.Size(226, 22);
            this.lblTaskQueue.TabIndex = 1;
            this.lblTaskQueue.Text = "Task Queue (FIFO Order)";
            this.lblTaskQueue.UseMnemonic = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddSubtask);
            this.panel4.Controls.Add(this.listSubtasks);
            this.panel4.Controls.Add(this.txtSubtask);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(12, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 222);
            this.panel4.TabIndex = 2;
            // 
            // btnAddSubtask
            // 
            this.btnAddSubtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddSubtask.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubtask.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddSubtask.Location = new System.Drawing.Point(72, 87);
            this.btnAddSubtask.Name = "btnAddSubtask";
            this.btnAddSubtask.Size = new System.Drawing.Size(118, 26);
            this.btnAddSubtask.TabIndex = 8;
            this.btnAddSubtask.Text = "+ Add Subtask";
            this.btnAddSubtask.UseVisualStyleBackColor = false;
            this.btnAddSubtask.TextChanged += new System.EventHandler(this.btnAddSubtask_Click);
            // 
            // listSubtasks
            // 
            this.listSubtasks.FormattingEnabled = true;
            this.listSubtasks.Location = new System.Drawing.Point(20, 115);
            this.listSubtasks.Name = "listSubtasks";
            this.listSubtasks.Size = new System.Drawing.Size(221, 95);
            this.listSubtasks.TabIndex = 7;
            // 
            // txtSubtask
            // 
            this.txtSubtask.Location = new System.Drawing.Point(29, 61);
            this.txtSubtask.Name = "txtSubtask";
            this.txtSubtask.Size = new System.Drawing.Size(212, 20);
            this.txtSubtask.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Subtask Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Subtasks";
            this.label8.UseMnemonic = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total Subtasks:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // txtTotalSubtasks
            // 
            this.txtTotalSubtasks.Location = new System.Drawing.Point(105, 492);
            this.txtTotalSubtasks.Name = "txtTotalSubtasks";
            this.txtTotalSubtasks.Size = new System.Drawing.Size(21, 20);
            this.txtTotalSubtasks.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(622, 515);
            this.Controls.Add(this.txtTotalSubtasks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.Label lblTaskQueue;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.TextBox txtSubtask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listSubtasks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddSubtask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSubtasks;
    }
}

