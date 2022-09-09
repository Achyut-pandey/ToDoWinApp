namespace ToDoWinApp
{
    partial class ToDoView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpActualDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnCompleted = new System.Windows.Forms.RadioButton();
            this.rdBtnPending = new System.Windows.Forms.RadioButton();
            this.rdbtnNew = new System.Windows.Forms.RadioButton();
            this.numTaskID = new System.Windows.Forms.NumericUpDown();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtpEstimatedDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskEstCompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskActualCompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.7324F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.2676F));
            this.tableLayoutPanel1.Controls.Add(this.dtpActualDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTaskName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numTaskID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpEstimatedDate, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.675F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 245);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpActualDate
            // 
            this.dtpActualDate.Location = new System.Drawing.Point(259, 203);
            this.dtpActualDate.Name = "dtpActualDate";
            this.dtpActualDate.Size = new System.Drawing.Size(398, 26);
            this.dtpActualDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Task Actual Completion Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Task Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Task Estimated Completion Date";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(259, 3);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(398, 26);
            this.txtTaskName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnCompleted);
            this.panel1.Controls.Add(this.rdBtnPending);
            this.panel1.Controls.Add(this.rdbtnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(259, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 34);
            this.panel1.TabIndex = 12;
            // 
            // rdBtnCompleted
            // 
            this.rdBtnCompleted.AutoSize = true;
            this.rdBtnCompleted.Location = new System.Drawing.Point(201, 4);
            this.rdBtnCompleted.Name = "rdBtnCompleted";
            this.rdBtnCompleted.Size = new System.Drawing.Size(111, 24);
            this.rdBtnCompleted.TabIndex = 2;
            this.rdBtnCompleted.TabStop = true;
            this.rdBtnCompleted.Text = "Completed";
            this.rdBtnCompleted.UseVisualStyleBackColor = true;
            // 
            // rdBtnPending
            // 
            this.rdBtnPending.AutoSize = true;
            this.rdBtnPending.Location = new System.Drawing.Point(95, 4);
            this.rdBtnPending.Name = "rdBtnPending";
            this.rdBtnPending.Size = new System.Drawing.Size(92, 24);
            this.rdBtnPending.TabIndex = 1;
            this.rdBtnPending.TabStop = true;
            this.rdBtnPending.Text = "Pending";
            this.rdBtnPending.UseVisualStyleBackColor = true;
            // 
            // rdbtnNew
            // 
            this.rdbtnNew.AutoSize = true;
            this.rdbtnNew.Checked = true;
            this.rdbtnNew.Location = new System.Drawing.Point(4, 4);
            this.rdbtnNew.Name = "rdbtnNew";
            this.rdbtnNew.Size = new System.Drawing.Size(65, 24);
            this.rdbtnNew.TabIndex = 0;
            this.rdbtnNew.TabStop = true;
            this.rdbtnNew.Text = "New";
            this.rdbtnNew.UseVisualStyleBackColor = true;
            // 
            // numTaskID
            // 
            this.numTaskID.Location = new System.Drawing.Point(259, 43);
            this.numTaskID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTaskID.Name = "numTaskID";
            this.numTaskID.Size = new System.Drawing.Size(398, 26);
            this.numTaskID.TabIndex = 13;
            this.numTaskID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Official",
            "Personal",
            "Others"});
            this.cbCategory.Location = new System.Drawing.Point(259, 83);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(398, 28);
            this.cbCategory.TabIndex = 14;
            // 
            // dtpEstimatedDate
            // 
            this.dtpEstimatedDate.Location = new System.Drawing.Point(259, 163);
            this.dtpEstimatedDate.Name = "dtpEstimatedDate";
            this.dtpEstimatedDate.Size = new System.Drawing.Size(398, 26);
            this.dtpEstimatedDate.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(11, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(209, 53);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveTask.Location = new System.Drawing.Point(441, 11);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(209, 53);
            this.btnRemoveTask.TabIndex = 2;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateTask.Location = new System.Drawing.Point(226, 11);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(209, 53);
            this.btnUpdateTask.TabIndex = 3;
            this.btnUpdateTask.Text = "Add / Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AllowUserToResizeRows = false;
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskID,
            this.TaskCategory,
            this.TaskStatus,
            this.TaskEstCompletionDate,
            this.TaskActualCompletionDate});
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(0, 320);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.RowHeadersWidth = 62;
            this.dgvTask.RowTemplate.Height = 28;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(661, 339);
            this.dgvTask.TabIndex = 4;
            this.dgvTask.SelectionChanged += new System.EventHandler(this.dgvTask_SelectionChanged);
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.MinimumWidth = 8;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "Unique ID";
            this.TaskID.MinimumWidth = 8;
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            // 
            // TaskCategory
            // 
            this.TaskCategory.HeaderText = "Category";
            this.TaskCategory.MinimumWidth = 8;
            this.TaskCategory.Name = "TaskCategory";
            this.TaskCategory.ReadOnly = true;
            // 
            // TaskStatus
            // 
            this.TaskStatus.HeaderText = "Status";
            this.TaskStatus.MinimumWidth = 8;
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.ReadOnly = true;
            // 
            // TaskEstCompletionDate
            // 
            this.TaskEstCompletionDate.HeaderText = "Est. Completion Date";
            this.TaskEstCompletionDate.MinimumWidth = 8;
            this.TaskEstCompletionDate.Name = "TaskEstCompletionDate";
            this.TaskEstCompletionDate.ReadOnly = true;
            // 
            // TaskActualCompletionDate
            // 
            this.TaskActualCompletionDate.HeaderText = "Actual Completion Date";
            this.TaskActualCompletionDate.MinimumWidth = 8;
            this.TaskActualCompletionDate.Name = "TaskActualCompletionDate";
            this.TaskActualCompletionDate.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveTask, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateTask, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 245);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(661, 75);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // ToDoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 659);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ToDoView";
            this.Text = "ToDo App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnCompleted;
        private System.Windows.Forms.RadioButton rdBtnPending;
        private System.Windows.Forms.RadioButton rdbtnNew;
        private System.Windows.Forms.DateTimePicker dtpActualDate;
        private System.Windows.Forms.NumericUpDown numTaskID;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtpEstimatedDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskEstCompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskActualCompletionDate;
    }
}

